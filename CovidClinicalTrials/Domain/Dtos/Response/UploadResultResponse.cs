namespace Domain.Dtos.Response
{
    /// <summary>
    /// Respuesta de resultados de subida de registros
    /// </summary>
    public class UploadResultResponse
    {
        public int LinesRead { get; set; }
        public int UpdatedRecords { get; set; }
        public int InsertedRecords { get; set; }
        public List<string> Errors { get; set; } = new ();
    }
}
