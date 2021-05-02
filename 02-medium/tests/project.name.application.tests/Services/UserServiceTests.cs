using Microsoft.Extensions.Logging;
using Xunit;
using Moq;

using project.name.application.Services;

namespace project.name.application.Tests.Services
{
    public class UserServiceTests
    {
        private UserService _classUnderTest;
        
        [Fact]
        public void GetUsers_ShouldReturnUsers()
        {
            var logger = Mock.Of<ILogger<UserService>>();
            
            _classUnderTest = new UserService(logger);
            
            var users = _classUnderTest.GetUsers();
            
            Assert.NotNull(users);
            Assert.Equal(3, users.Count);
        }
    }
}
