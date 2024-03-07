using System;
using Microsoft.AspNetCore.Mvc;
using Refit;
using ReqrestRefitA.Models;
using ReqrestRefitA.Services;

namespace ReqrestRefitA.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;

        }

        [HttpGet]
        [Route("getUsers")]
        public async Task<ResponseUser> getAllUsers()
        {
            return await _userService.getUsers();
        }

        [HttpGet("getUsers/{id}")]
        public async Task<ResponseUserSingle> getUserById(int id)
        {
            return await _userService.getUserById(id);
        }

        [HttpPost("register")]
        public async Task<Responsea> saveUser([FromBody] Usera usera)
        {
            return await _userService.saveUser(usera);
        }

        [HttpPut("users/{id}")]
        public async Task<ResponseUpdateUser> updateUser([FromBody] UserUpdate userUpdate, int id)
        {
            return await _userService.updateUser(id, userUpdate);
        }

        [HttpDelete("users/{id}")]
        public async Task<IActionResult> deleteUser(int id)
        {
            await _userService.deleteUser(id);
            return StatusCode(204);
        }
    }
}

