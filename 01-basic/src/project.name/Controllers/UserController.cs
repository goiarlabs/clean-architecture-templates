using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace project.name.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            _logger.LogInformation("Starting Users Get");
            
            var users = new[]
            {
                new User()
                {
                    Id = Guid.NewGuid(),
                    Email = "xenon@someemail.com",
                    FirstName = "Xenon",
                    LastName = "Lafuente"
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    Email = "noah@otheremail.com",
                    FirstName = "Noah",
                    LastName = "Marti"
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    Email = "noe@anotheremail.com",
                    FirstName = "Noe",
                    LastName = "Vazquez"
                }
            };
            
            _logger.LogInformation("Ending Users Get");
            
            return users;
        }
    }
}
