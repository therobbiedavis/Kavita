using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.DTOs.Filter;
using API.Entities.Enums;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    public class FilterController : BaseApiController
    {
        private readonly ILogger<FilterController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public FilterController(ILogger<FilterController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        
        [HttpPost("results")]
        public async Task<ActionResult<IEnumerable<SeriesDto>>> GetFilteredSeries(FilterDto filterDto)
        {
            return Ok(await _unitOfWork.SeriesRepository.CreateQuery(filterDto).ToListAsync());
        }
        
        [HttpGet("conditionals")]
        public ActionResult<IEnumerable<string>> GetWhereClauses()
        {
            // Let's just hardcode it
            return Ok(Enum.GetNames(typeof(WhereConditional)));
        }
    }
}