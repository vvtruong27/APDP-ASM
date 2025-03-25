using System.Collections.Generic;
using StudentInformationManagementSystem.Models;

namespace StudentInformationManagementSystem.Services
{
    public class ManageUser
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
    }
}
