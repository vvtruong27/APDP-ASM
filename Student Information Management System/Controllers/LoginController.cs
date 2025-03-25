using Microsoft.AspNetCore.Mvc;
using StudentInformationManagementSystem.Models;
using StudentInformationManagementSystem.Services;

namespace StudentInformationManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        private readonly AuthManage _authManage;

        public LoginController()
        {
            // Khởi tạo AuthManage với đường dẫn tới file CSV chứa thông tin người dùng
            _authManage = new AuthManage(new CSVServices("Data/users.csv"));
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Hiển thị trang đăng nhập
        }

        [HttpPost]
        public IActionResult Authenticate(string username, string password)
        {
            if (_authManage.Authenticate(username, password))
            {
                // Nếu đăng nhập thành công, chuyển hướng tới trang chính
                return RedirectToAction("Dashboard", "Home");
            }
            
            // Nếu thất bại, hiển thị thông báo lỗi
            ViewBag.ErrorMessage = "Invalid username or password.";
            return View("Index");
        }
    }
}
