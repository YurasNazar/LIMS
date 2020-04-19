using System.Collections.Generic;

namespace LIMS.ViewModels
{
    public class UserListViewModel
    {
        public List<UserViewModel> Users { get; set; }
    }

    public class UserViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }
    }
}
