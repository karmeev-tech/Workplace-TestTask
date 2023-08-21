using Workplace.Domain.User;

namespace Workplace.Application.Services.Common
{
    public class GetResult
    {
        public GetResult(User user)
        {
            User = user;
        }

        public User User { get; }
    }
}
