using LIMS.Models;
using LIMS.ViewModels;
using System.Collections.Generic;

namespace LIMS.Factories
{
    public interface IUserFactory
    {
        UserListViewModel PrepareUserListViewModel(IList<User> users);
    }
}
