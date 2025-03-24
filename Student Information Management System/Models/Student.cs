public class Student: User, ITranscriptDownloadStrategy, IViewAcademicRecords
{
    private ITranscriptDownloadStrategy transcriptStrategy;
    public bool DownloadTranscript(User user)
    {
        throw new System.NotImplementedException();
    }
    public void ViewAcademicRecords(User user)
    {
        throw new System.NotImplementedException();
    }
    public void SetTranscriptDownloadStrategy(ITranscriptDownloadStrategy strategy)
    {
        this.transcriptStrategy = strategy;
    }
}