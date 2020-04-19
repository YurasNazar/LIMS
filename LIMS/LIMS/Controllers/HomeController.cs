using LIMS.Factories;
using LIMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace LIMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IUserFactory _userFactory;

        public HomeController(IUserService userService, IUserFactory userFactory)
        {
            _userService = userService;
            _userFactory = userFactory;
        }

        public IActionResult Index()
        {
            var userList = _userService.GetAllUsers();
            var model = _userFactory.PrepareUserListViewModel(userList);
            return View(model);
        }

        public IActionResult Details(int id = 1) 
        {
            var model = _userService.GetUserById(id);
            return View(model);
        }
    }
}