namespace API.DTOs.Filter
{
    public class WhereClauseDto
    {
        public WhereConditional Conditional { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}