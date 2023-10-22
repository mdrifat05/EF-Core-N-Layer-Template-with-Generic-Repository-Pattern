using AutoMapper;
using EFConfigureExample.BusinessLogicLayer.Abstraction;
using EFConfigureExample.DataAccessLayer.Models;
using EFConfigureExample.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFConfigureExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserService _userService;
        readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {

            _userService = userService;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = _userService.GetAll();

            if (response == null)
            {
                var NotFoundResult = new
                {
                    StatusCode = StatusCodes.Status204NoContent,
                    Message = "No Data Found"
                };
                return NotFound(NotFoundResult);
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = _userService.GetById(id);
            if (response == null)
            {
                var NotFoundResult = new
                {
                    StatusCode = StatusCodes.Status204NoContent,
                    Message = "No Data Found"
                };
                return NotFound(NotFoundResult);
            }
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserCreateDto userCreateDto)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<User>(userCreateDto);
                var isSuccess = _userService.Add(user);

                if (isSuccess)
                {
                    var success = new
                    {
                        StatusCode = StatusCodes.Status200OK,
                        Message = "Success"
                    }; 
                    return Ok(success);
                }
                return BadRequest("Failded to create user");
            }
            return BadRequest(ModelState);
        }
        [HttpPut]
        public IActionResult Put([FromBody] UserUpdateDto userUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<User>(userUpdateDto);
                var isSuccess = _userService.Update(user);
                if (isSuccess)
                {
                    var success = new
                    {
                        StatusCode = StatusCodes.Status200OK,
                        Message = "Success"
                    };
                    return Ok(success);
                }
                return BadRequest("Failded to Update user");
            }
            return BadRequest(ModelState);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var entity = _userService.GetById(id);

            if (entity == null)
            {
                return NotFound(new
                {
                    StatusCode = StatusCodes.Status204NoContent,
                    Message = "No Data Found"
                });
            }

            if (_userService.Delete(entity))
            {
                return Ok(new
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success"
                });
            }

            return BadRequest();
        }

    }
}
