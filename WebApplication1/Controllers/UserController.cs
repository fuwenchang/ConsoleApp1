using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fwc.netcore.demo.CommonHelper;
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
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UserController> _logger;
        private readonly IUserQueries _userQueries;
        private readonly IConfiguration Configuration;
        private readonly DomainConfig domainConfig;
        private readonly RedisManager _redisManager;

        public UserController(
            ILogger<UserController> logger,
            IUserQueries userQueries,
            IConfiguration _configuration,
            IOptions<DomainConfig> options,
            RedisManager redisManager)
        {
            _logger = logger;
            _userQueries = userQueries;
            Configuration = _configuration;
            domainConfig = options.Value;
            _redisManager = redisManager;
        }

        /// <summary>
        /// 获取userId
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUserId")]
        public async Task<string> GetUserIdAsync(string bventId)
        {
            var userId = await _userQueries.GetUserIdAsync();

            var x = domainConfig.MySql;

            await _redisManager.StringSetAsync("fuwenchang", "xixi");

            return userId;
        }

        [HttpGet("GetRedis")]
        public async Task<string> GetUserByKey() 
        {
            var description = await _redisManager.StringGetAsync("fuwenchang");

            return description;
        }
    }
}
