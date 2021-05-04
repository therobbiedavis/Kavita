namespace API.DTOs
{
    public class FilterSearch
    {
        public int Id { get; set; }
        public string SearchFunction { get; set; }
        public string BaseClause { get; set; }
        public string Table { get; set; }
    }
}