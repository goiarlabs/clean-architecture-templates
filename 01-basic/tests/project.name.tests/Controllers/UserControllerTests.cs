using System.Linq;
using Xunit;
using Moq;
using Microsoft.Extensions.Logging;

using project.name.Controllers;

namespace project.name.Tests.Controllers
{
    public class UserControllerTests
    {
        private UserController _classUnderTest;
        
        [Fact]
        public void Get_ShouldReturnUsers()
        {
            var logger = Mock.Of<ILogger<UserController>>();
            
            _classUnderTest = new UserController(logger);
            
            var users = _classUnderTest.Get();
            
            Assert.NotNull(users);
            Assert.Equal(3, users.Count());
        }
    }
}
