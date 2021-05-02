using System;
using System.Collections.Generic;
using Xunit;
using Moq;

using project.name.presentation.Controllers;
using project.name.application.Services;
using project.name.domain.Models;

namespace project.name.presentation.Tests.Controllers
{
    public class UserControllerTests
    {
        private readonly Mock<IUserService> _userService;
        private UserController _classUnderTest;

        public UserControllerTests()
        {
            _userService = new Mock<IUserService>();
        }
        
        [Fact]
        public void Get_ShouldReturnUsersFromUserService()
        {
            _userService
                .Setup(u => u.GetUsers())
                .Returns(new List<User>
                {
                    new ()
                    {
                        Id = Guid.NewGuid(),
                        Email = "someuser1@someemail.com",
                        FirstName = "someuser1",
                        LastName = "somelastname"
                    },
                    new ()
                    {
                        Id = Guid.NewGuid(),
                        Email = "someuser2@otheremail.com",
                        FirstName = "someuser2",
                        LastName = "somelastname"
                    }
                }).Verifiable();
            
            _classUnderTest = new UserController(_userService.Object);
            
            var users = _classUnderTest.Get();
            
            _userService.Verify();
            Assert.NotNull(users);
            Assert.Equal(2, users.Count);
        }
    }
}
