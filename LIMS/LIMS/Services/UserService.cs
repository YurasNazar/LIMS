using LIMS.Models;
using System.Collections.Generic;
using System.Linq;

namespace LIMS.Services
{
    public class UserService : IUserService
    {
        private IList<User> _userRepository = new List<User>();

        public UserService()
        {
            _userRepository = GetAllUsersList();
        }

        public User GetUserById(int Id)
        {
            return _userRepository.FirstOrDefault(user => user.Id == Id);
        }

        public IList<User> GetAllUsers()
        {
            return _userRepository;
        }

        private IList<User> GetAllUsersList()
        {
            return new List<User>()
            {
                new User() { Id = 1, Email="koko@gmail.com", FirstName = "Nazar", LastName="Yuras", Group="KN-41"},
                new User() { Id = 2, Email="gugu@gmail.com", FirstName = "Oleksii", LastName="Stetsuk", Group="KN-41"},
                new User() { Id = 3, Email="cici@gmail.com", FirstName = "Volodymyr", LastName="Revura", Group="KN-41"}
            };
        }
    }
}
