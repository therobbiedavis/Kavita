using System.Collections.Generic;
using API.DTOs.Filter;
using API.Entities.Enums;

namespace API.Entities.Collections
{
    public class QuerySet
    {
        public int Id { get; set; }
        /// <summary>
        /// How many items to pull from DB. If 0 (default), no Take will be applied.
        /// </summary>
        public int Limit { get; set; }
        /// <summary>
        /// How to Sort entities. Defaults to Name
        /// </summary>
        public string SortKey { get; set; } = "Name";
        public SortDirection SortDirection { get; set; } = SortDirection.Ascending;
        public ICollection<WhereClause> WhereClauses { get; set; }

    }
}