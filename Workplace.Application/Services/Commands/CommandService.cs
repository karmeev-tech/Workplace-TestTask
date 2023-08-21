using System;
using Workplace.Application.Commands;
using Workplace.Application.Mapping;
using Workplace.Application.Services.Common;
using Workplace.Domain.User;
using Workplace.Infrastructure.Interfaces;
using Workplace.Infrastructure.Model;

namespace Workplace.Application.Services.Commands
{
    public class CommandService : ICommandsService
    {
        public IRepository<UserEntity> _userRepository;

        public CommandService(IRepository<UserEntity> userRepository)
        {
            _userRepository = userRepository;
        }

        public CreateResult CreateUser(CreateCommand command)
        {
            var user = new User
            {
                NickName = command.NickName,
                Email = command.Email,
                Comments = command.Comments,
                CreateDate = command.CreateDate
            };
            var result = _userRepository.Create(user);
            var dto = ObjectMapper.Mapper.Map<User>(result);
            
            if(dto != null)
            {
                return new CreateResult("Ok");
            }
            else
            {
                return new CreateResult("Bad");
            }
        }

        public DeleteResult DeleteUser(DeleteCommand command)
        {
            try
            {
                _userRepository.Delete(command.Email);
                return new DeleteResult("Ok");
            }
            catch(Exception)
            {
                return new DeleteResult("Bad");
            }
        }

        public UpdateResult UpdateUser(UpdateCommand command)
        {
            try
            {
                var user = new User
                {
                    NickName = command.NickName,
                    Email = command.Email,
                    Comments = command.Comments
                };

                var userEntity = ObjectMapper.Mapper.Map<UserEntity>(user);
                _userRepository.Update(userEntity);

                return new UpdateResult(user);
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
