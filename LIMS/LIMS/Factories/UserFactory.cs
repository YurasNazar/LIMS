using LIMS.Models;
using LIMS.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace LIMS.Factories
{
    public class UserFactory : IUserFactory
    {
        public UserListViewModel PrepareUserListViewModel(IList<User> users)
        {
            return new UserListViewModel
            {
                Users = users.Select(PrepareUserModel).ToList()
            };
        }

        private UserViewModel PrepareUserModel(User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                FullName = user.FirstName + " " + user.LastName,
                Email = user.Email
            };
        }
    }
}
