namespace Domain.Dtos
{
    public class PaginationResponse : PaginationRequest
    {
        public int Count { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)Count / PageSize);
    }
}
