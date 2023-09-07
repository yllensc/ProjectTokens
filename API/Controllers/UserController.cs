using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserController : ApiBaseController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService){
            _userService = userService;
        }
        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync(RegisterDto model){
            var result = await _userService.RegisterAsync(model);
            return Ok(result);
        }
        [HttpPost("token")]
        public async Task<ActionResult> GetTokenAsync(LogDto model){
            var result = await _userService.GetTokenAsync(model);
            return Ok(result);
        }
        [HttpPost("addrol")]
        public async Task<ActionResult> AddRoleAsync(AddRoleDto model){
            var result = await _userService.AddRoleAsync(model);
            return Ok(result);
        }

    }
}