using LIMS.Models;
using System.Collections.Generic;

namespace LIMS.Services
{
    public interface IUserService
    {
       User GetUserById(int Id);

       IList<User> GetAllUsers();
    }
}
