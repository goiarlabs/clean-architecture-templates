using System;
using Xunit;
using project.name.domain.Models;

namespace project.name.domain.Tests.Models
{
    public class UserTests
    {
        [Fact]
        public void New_ShouldSetValues()
        {
            var id = Guid.NewGuid();
            var user = new User(id, "firstName", "lastName", "email@email.com");

            Assert.Equal(id, user.Id);
            Assert.Equal("email@email.com", user.Email);
            Assert.Equal("firstName", user.FirstName);
            Assert.Equal("lastName", user.LastName);
        }
    }
}
