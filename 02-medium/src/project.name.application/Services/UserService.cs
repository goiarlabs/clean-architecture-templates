using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

using project.name.domain.Models;

namespace project.name.application.Services
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;

        public UserService(ILogger<UserService> logger)
        {
            _logger = logger;
        }

        public List<User> GetUsers()
        {
            _logger.LogInformation($"Starting Users Get from {nameof(UserService)}");

            var users = new List<User>
            {
                new ()
                {
                    Id = Guid.NewGuid(),
                    Email = "xenon@someemail.com",
                    FirstName = "Xenon",
                    LastName = "Lafuente"
                },
                new ()
                {
                    Id = Guid.NewGuid(),
                    Email = "noah@otheremail.com",
                    FirstName = "Noah",
                    LastName = "Marti"
                },
                new ()
                {
                    Id = Guid.NewGuid(),
                    Email = "noe@anotheremail.com",
                    FirstName = "Noe",
                    LastName = "Vazquez"
                }
            };
            
            _logger.LogInformation($"Ending Users Get from {nameof(UserService)}");
            
            return users;
        } 
    }
}
