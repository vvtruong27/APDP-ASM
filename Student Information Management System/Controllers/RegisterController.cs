using Microsoft.AspNetCore.Mvc;
using StudentInformationManagementSystem.Models;
using StudentInformationManagementSystem.Services;

namespace StudentInformationManagementSystem.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ManageUser _manageUser;

        public RegisterController()
        {
            // Khởi tạo ManageUser với đường dẫn tới file CSV chứa thông tin người dùng
            _manageUser = new ManageUser(new CSVServices("Data/users.csv"));
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Hiển thị trang đăng ký
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (user.Role.ToLower() != "administrator")
            {
                ViewBag.ErrorMessage = "Only administrators are allowed to register new accounts.";
                return View("Index");
            }

            _manageUser.AddUser(user);
            ViewBag.SuccessMessage = "Account successfully created!";
            return View("Index");
        }
    }
}
