using Workplace.Domain.User;

namespace Workplace.Contracts.Responses
{
    public class ListResponse
    {
        public ListResponse(List<User> users)
        {
            Users = users;
        }

        public List<User> Users { get; }
    }}
