using System.Collections.Generic;

namespace API.Entities.Collections
{
    public class SmartCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public QuerySet QuerySet { get; set; }
        /// <summary>
        /// When Public, the SmartCollection can be seen by other users
        /// </summary>
        public bool Public { get; set; }
    }
}