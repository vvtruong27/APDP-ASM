using StudentInformationManagementSystem.Interfaces;
using StudentInformationManagementSystem.Models;

namespace StudentInformationManagementSystem.Services
{
    public class AuthManage : IAuthenticate
    {
        private readonly CSVServices csvServices;

        public AuthManage(CSVServices services)
        {
            csvServices = services;
        }

        public bool Authenticate(string username, string password)
        {
            var users = csvServices.ReadData();
            foreach (var user in users)
            {
                if (user[1] == username && user[2] == password) // username và password ở cột 1 và 2
                {
                    return true;
                }
            }
            return false;
        }
    }
}
