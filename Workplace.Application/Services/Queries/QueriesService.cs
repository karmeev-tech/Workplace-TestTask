using System.Collections.Generic;
using Workplace.Application.Mapping;
using Workplace.Application.Queries;
using Workplace.Application.Services.Common;
using Workplace.Domain.User;
using Workplace.Infrastructure.Interfaces;
using Workplace.Infrastructure.Model;

namespace Workplace.Application.Services.Queries
{
    public class QueriesService : IQueriesService
    {
        public IRepository<UserEntity> _userRepository;

        public QueriesService(IRepository<UserEntity> userRepository)
        {
            _userRepository = userRepository;
        }

        public ListResult GetAllUsers()
        {
            var result = _userRepository.GetAll();
            var dto = ObjectMapper.Mapper.Map<List<User>>(result);

            return new ListResult(dto);
        }

        public GetResult GetUser(GetQuery query)
        {
            var result = _userRepository.Get(query.Email);
            var dto = ObjectMapper.Mapper.Map<User>(result);

            return new GetResult(dto);
        }
    }
}
