using Workplace.Domain.User;

namespace Workplace.Application.Services.Common
{
    public class UpdateResult
    {
        public UpdateResult(User user)
        {
            User = user;
        }

        public User User { get; }
    }
}
