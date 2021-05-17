using API.DTOs.Filter;

namespace API.Entities.Collections
{
    public class WhereClause
    {
        public int Id { get; set; }
        public WhereConditional Conditional { get; set; }
        public string Key { get; set; }
        /// <summary>
        /// This must be cleaned SQL
        /// </summary>
        public string Value { get; set; }
    }
}