
using Microsoft.AspNetCore.Mvc;
using StudentInformationManagementSystem.Models;
using StudentInformationManagementSystem.Services;

namespace StudentInformationManagementSystem.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ManageUser _manageUser;

        public DashboardController()
        {
            // Khởi tạo ManageUser với đường dẫn tới file CSV chứa thông tin người dùng
            _manageUser = new ManageUser(new CSVServices("Data/users.csv"));
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Lấy danh sách người dùng không phải là Administrator
            var users = _manageUser.GetNonAdminUsers();
            return View(users); // Truyền danh sách người dùng tới view
        }
    }
}
