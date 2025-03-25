using System;
using StudentInformationManagementSystem.Interfaces;

namespace StudentInformationManagementSystem.Services
{
    public class PNGDownloadStrategy : ITranscriptDownloadStrategy
    {
        public void DownloadTranscript(string studentId, string format)
        {
            if (format.ToLower() != "png")
            {
                throw new ArgumentException("Invalid format for PNG download strategy.");
            }

            // Logic tải bảng điểm dưới dạng PNG
            Console.WriteLine($"Transcript for Student {studentId} has been downloaded as a PNG.");
        }
    }
}
