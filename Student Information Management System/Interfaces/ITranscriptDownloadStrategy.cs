using StudentInformationManagementSystem.Models;

public interface ITranscriptDownloadStrategy
{
    string DownloadTranscript(string studentId, string format, List<(Course course, double? grade)> courseData);
}
