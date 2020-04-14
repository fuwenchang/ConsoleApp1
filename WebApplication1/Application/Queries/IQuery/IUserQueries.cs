using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Application.Queries.IQuery
{
    public interface IUserQueries: IQueries
    {
        Task<string> GetUserIdAsync();
    }
}
