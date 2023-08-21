using System.Collections.Generic;
using Workplace.Domain.User;

namespace Workplace.Application.Services.Common
{
    public class ListResult
    {
        public ListResult(List<User> users)
        {
            Users = users;
        }

        public List<User> Users { get;}
    }
}
