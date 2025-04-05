using StudentInformationManagementSystem.Models;
using StudentInformationManagementSystem.Interfaces;

namespace StudentInformationManagementSystem.Services
{
    public class ProfileService : IGetProfile
    {
        private readonly CSVServices csvServices;

        public ProfileService(string path)
        {
            csvServices = new CSVServices(path);
        }

        public User GetProfileDetails(string userId)
        {
            var data = csvServices.ReadData();

            foreach (var row in data)
            {
                if (row[0] == userId)
                {
                    return new User
                    {
                        UserID = row[0],
                        Username = row[1],
                        Password = row[2],
                        Name = row[3],
                        Email = row[4],
                        Phone = row[5],
                        Role = row[6]
                    };
                }
            }

            return null;
        }
    }
}
