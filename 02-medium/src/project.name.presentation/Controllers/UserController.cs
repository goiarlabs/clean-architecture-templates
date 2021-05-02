using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using project.name.application.Services;
using project.name.domain.Models;

namespace project.name.presentation.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<User> Get()
        {
            var users = _userService.GetUsers();
            
            return users;
        }
    }
}
