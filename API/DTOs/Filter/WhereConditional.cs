using System.ComponentModel;

namespace API.DTOs.Filter
{
    public enum WhereConditional
    {
        [Description("Equals")]
        Equals = 0,
        [Description("Less than")]
        LessThan = 1,
        [Description("Greater than")]
        GreaterThan = 2,
        [Description("Less than or equal to")]
        LessThanEqualTo = 3,
        [Description("Greater than or equal to")]
        GreaterThanEqualTo = 4,
        [Description("Contains")]
        Contains = 5,
        [Description("Has")]
        Has = 6, // Maps to Not NULL or Not ""
    }
}