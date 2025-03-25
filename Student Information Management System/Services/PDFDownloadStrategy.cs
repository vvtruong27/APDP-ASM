using System;
using StudentInformationManagementSystem.Interfaces;

namespace StudentInformationManagementSystem.Services
{
    public class PDFDownloadStrategy : ITranscriptDownloadStrategy
    {
        public void DownloadTranscript(string studentId, string format)
        {
            if (format.ToLower() != "pdf")
            {
                throw new ArgumentException("Invalid format for PDF download strategy.");
            }

            // Logic tải bảng điểm dưới dạng PDF
            Console.WriteLine($"Transcript for Student {studentId} has been downloaded as a PDF.");
        }
    }
}
