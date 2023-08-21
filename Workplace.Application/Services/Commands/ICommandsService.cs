using Workplace.Application.Commands;
using Workplace.Application.Services.Common;

namespace Workplace.Application.Services.Commands
{
    public interface ICommandsService
    {
        public CreateResult CreateUser(CreateCommand command);
        public DeleteResult DeleteUser(DeleteCommand command);
        public UpdateResult UpdateUser(UpdateCommand command);
    }
}
