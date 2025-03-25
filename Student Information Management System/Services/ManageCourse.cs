using System.Collections.Generic;
using StudentInformationManagementSystem.Models;

namespace StudentInformationManagementSystem.Services
{
    public class ManageCourse
    {
        private readonly CSVServices csvServices;

        public ManageCourse(CSVServices services)
        {
            csvServices = services;
        }

        public void AddCourse(Course course)
        {
            var courses = csvServices.ReadData();
            courses.Add(new string[] { course.CourseID, course.CourseName, course.CourseCode, course.Department, 
                                       course.CreditHours.ToString(), course.Semester });
            csvServices.WriteData(courses);
        }

        public Course GetCourse(string courseId)
        {
            var courses = csvServices.ReadData();
            foreach (var course in courses)
            {
                if (course[0] == courseId) // CourseID ở cột 0
                {
                    return new Course
                    {
                        CourseID = course[0],
                        CourseName = course[1],
                        CourseCode = course[2],
                        Department = course[3],
                        CreditHours = int.Parse(course[4]),
                        Semester = course[5]
                    };
                }
            }
            return null;
        }

        public bool RemoveCourse(string courseId)
        {
            var courses = csvServices.ReadData();
            var updatedCourses = new List<string[]>();

            foreach (var course in courses)
            {
                if (course[0] != courseId) // Loại bỏ CourseID khớp với yêu cầu
                {
                    updatedCourses.Add(course);
                }
            }

            if (courses.Count != updatedCourses.Count)
            {
                csvServices.WriteData(updatedCourses);
                return true;
            }

            return false;
        }
    }
}
