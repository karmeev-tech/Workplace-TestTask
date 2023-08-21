using Workplace.Application.Queries;
using Workplace.Application.Services.Common;

namespace Workplace.Application.Services.Queries
{
    public interface IQueriesService
    {
        public ListResult GetAllUsers();
        public GetResult GetUser(GetQuery query);
    }
}
