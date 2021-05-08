using System.Collections.Generic;
using System.Data.SqlClient;

namespace API.DTOs.Filter
{
    public class FilterDto
    {
        public int Id { get; set; }
        public IEnumerable<WhereClause> WhereClauses { get; set; }
        public string SortKey { get; set; }
        public SortOrder SortOrder { get; set; }
        public int Limit { get; set; }
    }
}