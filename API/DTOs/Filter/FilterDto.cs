using System.Data.SqlClient;

namespace API.DTOs
{
    public class FilterDto
    {
        public int Id { get; set; }
        
        public string SortKey { get; set; }
        public SortOrder SortOrder { get; set; }
        public int Limit { get; set; }
    }
}