using StudentInformationManagementSystem.Interfaces;
using StudentInformationManagementSystem.Models;
using System.Collections.Generic;

namespace StudentInformationManagementSystem.Services
{
    public class TranscriptDownloader
    {
        private ITranscriptDownloadStrategy _strategy;

        public TranscriptDownloader(ITranscriptDownloadStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ITranscriptDownloadStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Download(string studentId, string format, List<(Course course, double? grade)> courseData)
        {
            _strategy.DownloadTranscript(studentId, format, courseData);
        }
    }
}
