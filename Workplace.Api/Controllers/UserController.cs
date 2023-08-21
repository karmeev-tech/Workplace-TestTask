using Microsoft.AspNetCore.Mvc;
using System;
using Workplace.Contracts.Responses;
using Workplace.Contracts.Requests;
using AutoMapper;
using Workplace.Application.Queries;
using Workplace.Application.Services.Queries;
using Workplace.Infrastructure.Interfaces;
using Workplace.Infrastructure.Model;
using Workplace.Application.Commands;
using Workplace.Application.Services.Commands;

namespace Workplace.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IQueriesService _listQueriesService;
        private readonly ICommandsService _commandsService;
        private readonly IRepository<UserEntity> _repository;

        public UserController(IMapper mapper,
                              IQueriesService listQueriesService,
                              IRepository<UserEntity> repository,
                              ICommandsService commandsService)
        {
            _mapper = mapper;
            _listQueriesService = listQueriesService;
            _repository = repository;
            _commandsService = commandsService;
        }

        [HttpGet("/List")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _listQueriesService.GetAllUsers();
                var response = _mapper.Map<ListResponse>(result);

                if (response.Users.Count > 0)
                {
                    return Ok(response);
                }
                else
                {
                    return Problem("Database has not Users");
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/Get/{email}")]
        public IActionResult Get(string email)
        {
            try
            {
                var request = new GetRequest(email);
                var query = _mapper.Map<GetQuery>(request);
                var result = _listQueriesService.GetUser(query);
                var response = _mapper.Map<GetResponse>(result);

                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return Problem("User undefined");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("/Create")]
        public IActionResult Post(string nickname,
                                  string email,
                                  string comments)
        {
            try
            {
                var request = new CreateRequest(nickname, email, comments, DateTime.Now.ToString());
                var command = _mapper.Map<CreateCommand>(request);
                var result = _commandsService.CreateUser(command);
                var response = _mapper.Map<CreateResponse>(result);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("/Update")]
        public IActionResult Put(string nickName,
                                 string email,
                                 string comments)
        {
            try
            {
                var request = new UpdateRequest(nickName, email, comments);
                var command = _mapper.Map<UpdateCommand>(request);
                var result = _commandsService.UpdateUser(command);
                var resonse = _mapper.Map<UpdateResponse>(result);

                return Ok(resonse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("/Delete/{email}")]
        public IActionResult Delete(string email)
        {
            try
            {
                var request = new DeleteRequest(email);
                var command = _mapper.Map<DeleteCommand>(request);
                var result = _commandsService.DeleteUser(command);
                var response = _mapper.Map<DeleteResponse>(result);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
