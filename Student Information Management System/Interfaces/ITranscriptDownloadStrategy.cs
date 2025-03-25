namespace StudentInformationManagementSystem.Interfaces
{
    public interface ITranscriptDownloadStrategy
    {
        void DownloadTranscript(string studentId, string format);
    }
}
