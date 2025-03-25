using Microsoft.AspNetCore.Mvc;
using StudentInformationManagementSystem.Models;
using StudentInformationManagementSystem.Services;

namespace StudentInformationManagementSystem.Controllers
{
    public class ManageUsersController : Controller
    {
        private readonly ManageUser _manageUser;

        public ManageUsersController()
        {
            _manageUser = new ManageUser(new CSVServices("Data/users.csv"));
        }

        // Hiển thị giao diện sửa thông tin người dùng
        [HttpGet]
        public IActionResult Edit(string id)
        {
            var user = _manageUser.GetUser(id);
            if (user == null)
            {
                return NotFound(); // Nếu không tìm thấy người dùng, trả về lỗi 404
            }
            return View(user); // Truyền thông tin người dùng tới view Edit
        }

        // Xử lý logic sửa thông tin người dùng
        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            if (ModelState.IsValid)
            {
                _manageUser.UpdateUser(updatedUser);
                return RedirectToAction("Index", "Dashboard"); // Quay lại Dashboard sau khi sửa thành công
            }
            return View(updatedUser); // Nếu dữ liệu không hợp lệ, hiển thị lại form
        }

        // Hiển thị giao diện xóa người dùng
        [HttpGet]
        public IActionResult Delete(string id)
        {
            var user = _manageUser.GetUser(id);
            if (user == null)
            {
                return NotFound(); // Nếu không tìm thấy người dùng, trả về lỗi 404
            }
            return View(user); // Truyền thông tin người dùng tới view Delete
        }

        // Xử lý logic xóa người dùng
        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmDelete(string id)
        {
            var isDeleted = _manageUser.RemoveUser(id);
            if (isDeleted)
            {
                return RedirectToAction("Index", "Dashboard"); // Quay lại Dashboard sau khi xóa thành công
            }
            return NotFound(); // Nếu không thể xóa, trả về lỗi 404
        }
    }
}
