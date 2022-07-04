using Domain.Dtos.Request;
using Domain.Dtos.Response;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;
using System.Globalization;

namespace Services.Implementations
{
    public class ClinicalTrialUploaderService : IClinicalTrialUploaderService
    {

        private readonly DbContext _dbContext;

        public ClinicalTrialUploaderService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetTrialsResponse> Get(GetTrialsRequest request)
        {

            List<TrialTableDto> records = await _dbContext.Set<ClinicalTrialRecord>()
                .Skip(request.PageSize * (request.Page - 1))
                .Take(request.PageSize)
                .Select(x => new
                TrialTableDto()
                {
                    Id = x.Id,
                    Name = x.ScientificTitle,
                    Countries = x.Countries

                })
                .ToListAsync();

            int count = await _dbContext.Set<ClinicalTrialRecord>().CountAsync();

            return new GetTrialsResponse()
            {
                Count = count,
                Trials = records,
                Page = request.Page,
                PageSize = request.PageSize
            };
        }

        public async Task<UploadResultResponse> UploadFile(UploadTrialsFileRequest request)
        {
            UploadResultResponse response = new();
            List<ClinicalTrialRecord> records = new ();
            string text = "";
            string textRow;
            bool isHeader = true;
            List<string> rowsArrays = new List<string>();
            using (var fileStream = request.File.OpenReadStream())
            using (var reader = new StreamReader(fileStream))
            {

                while ((textRow = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }
                    text += textRow;
                    if (text[text.Length-1] == '"' && text.Split("\",\"").Length >= 40)
                    {
                        try
                        {
                            records.Add(ParseRow(text));
                            response.InsertedRecords++;
                        }
                        catch(Exception ex)
                        {
                            response.Errors.Add(string.Format("{0}:{1}", text, ex.Message));
                        }
                        finally
                        {
                            text = "";
                        }
                    }
                }
            }
            foreach(ClinicalTrialRecord record in records)
            {
                _dbContext.Set<ClinicalTrialRecord>().Add(record);
            }
            await _dbContext.SaveChangesAsync();

            return response;
        }

        private bool FormatBool(string value)
        {
            List<string> trueSinonims = new List<string>()
            {
                "yes", "true"
            };

            return trueSinonims.Contains(value.Trim().ToLower());
        }

        private DateTime? FormatDate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            DateTime date;
            if (DateTime.TryParse(value, out date))
            {
                return date;
            }
            else if(DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.InvariantCulture,
                    DateTimeStyles.RoundtripKind, out date))
            {
                return date;
            }
            else if(DateTime.TryParseExact(value, "M/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out date))
            {
                return date;
            }
            else
            {

            }
            return date;
        }


        private ClinicalTrialRecord ParseRow(string row)
        {
            int left = 0;
            int right = 0;
            List<string> cols = new();
            while(right < row.Length)
            {
                if (row[left] == '"')
                {
                    left++;
                }
                right = row.IndexOf("\",\"", left);
                if (right != -1)
                {
                    cols.Add(row.Substring(left, right - left));
                    right += 2;
                    left = right;
                }
                else
                {
                    right = row.Length;
                    cols.Add(row.Substring(left, right - left - 1));

                }
            }

            return new ClinicalTrialRecord()
            {
                Id = cols.ElementAt(0),
                LastRefreshedOn = cols.ElementAt(1),
                PublicTitle = cols.ElementAt(2),
                ScientificTitle = cols.ElementAt(3),
                Acronym = cols.ElementAt(4),
                PrimarySponsor = cols.ElementAt(5),
                DateRegistration = FormatDate(cols.ElementAt(6)),
                DateRegistration3 = FormatDate(cols.ElementAt(7)),
                ExportDate = FormatDate(cols.ElementAt(8)),
                SourceRegister = cols.ElementAt(9),
                WebAddress = cols.ElementAt(10),
                RecruitmentStatus = cols.ElementAt(11),
                OtherRecords = cols.ElementAt(12),
                Inclusion = new Inclusion()
                {
                    AgeMin = cols.ElementAt(13),
                    AgeMax = cols.ElementAt(14),
                    Gender = cols.ElementAt(15),
                    InclusionText = cols.ElementAt(28),
                },

                DateEnrollement = cols.ElementAt(16),
                TargetSize = cols.ElementAt(17),
                StudyType = cols.ElementAt(18),
                StudyDesign = cols.ElementAt(19),
                Phase = cols.ElementAt(20),
                Countries = cols.ElementAt(21),
                Contact = new Contact()
                {
                    FirstName = cols.ElementAt(22),
                    LastName = cols.ElementAt(23),
                    Address = cols.ElementAt(24),
                    Email = cols.ElementAt(25),
                    Tel = cols.ElementAt(26),
                    Affiliation = cols.ElementAt(27),
                },
                ExclusionCriteria = cols.ElementAt(29),
                Condition = cols.ElementAt(30),
                Intervention = cols.ElementAt(31),
                PrimaryOutcome = cols.ElementAt(32),
                ResultsDatePosted = cols.ElementAt(33),
                ResultsDateCompleted = cols.ElementAt(34),
                ResultsUrlLink = cols.ElementAt(35),
                Retrospective = FormatBool(cols.ElementAt(36)),
                Bridging = FormatBool(cols.ElementAt(37)),
                BridgedType = cols.ElementAt(38),
                Results = FormatBool(cols.ElementAt(39)),
            };
        }
    }
}
