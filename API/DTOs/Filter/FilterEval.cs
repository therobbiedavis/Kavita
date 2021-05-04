namespace API.DTOs
{
    public class FilterEval
    {
        public int Id { get; set; }
        /// <summary>
        /// The actual SQL to use
        /// <example>=, !=</example>
        /// </summary>
        public string Criteria { get; set; }

        /// <summary>
        /// What shows to the user
        /// <example>Equal to, Does not equal</example>
        /// </summary>
        public string VisibleCriteria { get; set; }
        /// <summary>
        /// Integer representing order of options
        /// </summary>
        public int SortOrder { get; set; }
        
        public bool DefaultChoice { get; set; }
        /// <summary>
        /// Type of filter this Eval applies to
        /// </summary>
        public string Type { get; set; }

    }
}