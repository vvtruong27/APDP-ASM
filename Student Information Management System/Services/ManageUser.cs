using System.Collections.Generic;
using Student_Information_Management_System.Interfaces;
using StudentInformationManagementSystem.Models;

namespace StudentInformationManagementSystem.Services
{
    public class ManageUser : IManageUser
    {
        private readonly CSVServices csvServices;

        public ManageUser(CSVServices services)
        {
            csvServices = services;
        }

        public void AddUser(User user)
        {
            var users = csvServices.ReadData();
            users.Add(new string[] { user.UserID, user.Username, user.Password, user.Name, user.Email, user.Phone, user.Role });
            csvServices.WriteData(users);
        }

        public User GetUser(string userId)
        {
            var users = csvServices.ReadData();
            foreach (var user in users)
            {
                if (user[0] == userId) // UserID ở cột 0
                {
                    return new User
                    {
                        UserID = user[0],
                        Username = user[1],
                        Password = user[2],
                        Name = user[3],
                        Email = user[4],
                        Phone = user[5],
                        Role = user[6]
                    };
                }
            }
            return null;
        }

        public bool RemoveUser(string userId)
        {
            var users = csvServices.ReadData();
            var updatedUsers = new List<string[]>();

            foreach (var user in users)
            {
                if (user[0] != userId) // Loại bỏ UserID khớp với yêu cầu
                {
                    updatedUsers.Add(user);
                }
            }

            if (users.Count != updatedUsers.Count)
            {
                csvServices.WriteData(updatedUsers);
                return true;
            }

            return false;
        }

        public List<User> GetNonAdminUsers()
        {
            var users = csvServices.ReadData();
            var nonAdminUsers = new List<User>();

            foreach (var user in users)
            {
                if (user[6].ToLower() != "administrator") // Loại bỏ Administrator (Role ở cột 6)
                {
                    nonAdminUsers.Add(new User
                    {
                        UserID = user[0],
                        Username = user[1],
                        Password = user[2],
                        Name = user[3],
                        Email = user[4],
                        Phone = user[5],
                        Role = user[6]
                    });
                }
            }

            return nonAdminUsers;
        }

        // Phương thức UpdateUser để cập nhật thông tin người dùng
        public void UpdateUser(User updatedUser)
        {
            var users = csvServices.ReadData();

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i][0] == updatedUser.UserID) // Tìm phần tử có UserID khớp
                {
                    // Cập nhật thông tin người dùng trong danh sách
                    users[i] = new string[]
                    {
                        updatedUser.UserID,
                        updatedUser.Username,
                        updatedUser.Password,
                        updatedUser.Name,
                        updatedUser.Email,
                        updatedUser.Phone,
                        updatedUser.Role
                    };
                    break;
                }
            }

            // Ghi lại danh sách đã cập nhật vào file CSV
            csvServices.WriteData(users);
        }
        public List<User> GetAllUsers()
        {
            return csvServices.GetAllUsers();
        }


    }
}
