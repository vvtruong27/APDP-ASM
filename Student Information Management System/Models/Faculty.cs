class Faculty: User, ITranscriptDownloadStrategy
{
    private ITranscriptDownloadStrategy transcriptStrategy;
    public bool DownloadTranscript(User user)
    {
        throw new System.NotImplementedException();
    }
}