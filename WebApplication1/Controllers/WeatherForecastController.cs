using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApplication1.Application.Queries.IQuery;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IUserQueries _userQueries;
        private readonly IConfiguration Configuration;
        private readonly DomainConfig domainConfig;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IUserQueries userQueries,
            IConfiguration _configuration,
            IOptions<DomainConfig> options)
        {
            _logger = logger;
            _userQueries = userQueries;
            Configuration = _configuration;
            domainConfig = options.Value;
        }

        /// <summary>
        /// 获取userId
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUserId/{bventId:required}")]
        public async Task<string> GetUserIdAsync(string bventId)
        {
            var userId = await _userQueries.GetUserIdAsync();

            var x = domainConfig.MySql;

            return userId;
        }
    }
}
