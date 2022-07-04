using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Response
{
    public class GetTrialsResponse : PaginationResponse
    {
        public List<TrialTableDto> Trials { get; set; }
    }
}
