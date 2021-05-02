using System.Collections.Generic;
using project.name.domain.Models;

namespace project.name.application.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}