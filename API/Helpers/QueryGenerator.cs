using System;
using System.Linq;
using API.DTOs;
using API.DTOs.Filter;

namespace API.Helpers
{
    public static class QueryGenerator
    {
        // public static IQueryable<SeriesDto> CreateQuery(FilterDto filterDto)
        // {
        //     var series = _context.Series.AsNoTracking();
        //
        //     if (filterDto.SortOrder == SortOrder.Unspecified || filterDto.SortOrder == SortOrder.Ascending)
        //     {
        //         series = !string.IsNullOrEmpty(filterDto.SortKey) ? series.OrderBy(filterDto.SortKey) : series.OrderBy(s => s.SortName);
        //     }
        //     else
        //     {
        //         series = !string.IsNullOrEmpty(filterDto.SortKey) ? series.OrderBy(filterDto.SortKey + " Desc") : series.OrderByDescending(s => s.SortName);
        //     }
        //
        //     // Where conditions will be implemented by using Enums which map to DynamicLinq syntax
        //     series = series
        //         .Where(s => s.LibraryId == libraryId);
        //
        //
        //     if (filterDto.Limit > 0)
        //     {
        //         series = series.Take(filterDto.Limit);
        //     }
        //
        //     return series.ProjectTo<SeriesDto>(_mapper.ConfigurationProvider);
        // } 

        public static string ConvertWhereClause(WhereConditional conditional)
        {
            switch (conditional)
            {
                case WhereConditional.Equals:
                    return " = ";
                case WhereConditional.LessThan:
                    return " < ";
                case WhereConditional.GreaterThan:
                    return " >";
                case WhereConditional.LessThanEqualTo:
                    return " <= ";
                case WhereConditional.GreaterThanEqualTo:
                    return " >= ";
                case WhereConditional.Contains:
                    return ".Contains() ";
                case WhereConditional.Has:
                    return " = NULL "; // might nee something else here
                default:
                    throw new ArgumentOutOfRangeException(nameof(conditional), conditional, null);
            }
        }
    }
}