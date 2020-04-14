using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Application.Queries.IQuery;

namespace WebApplication1.Application.Queries
{
    public class UserQueries : IUserQueries
    {
        public async Task<string> GetUserIdAsync()
        {
            return await Task.FromResult("hahahaha");
        }
    }
}
