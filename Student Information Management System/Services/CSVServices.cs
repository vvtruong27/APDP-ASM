class CSVServices 
{
    private string filePath;
    private CSVServices instances;
    private CSVServices() {}
    public CSVServices GetInstance()
    {
        if (instances == null)
        {
            instances = new CSVServices();
        }
        return instances;
    }
    private void ReadData()
    {
        throw new System.NotImplementedException();
    }
    private void WriteData()
    {
        throw new System.NotImplementedException();
    }
    public void AuthenticateUser()
    {
        throw new System.NotImplementedException();
    }
    public void ReadCourses()
    {
        throw new System.NotImplementedException();
    }
    public void ReadStudents()
    {
        throw new System.NotImplementedException();
    }
    public void ReadFaculties()
    {
        throw new System.NotImplementedException();
    }
    public void ReadUsers()
    {
        throw new System.NotImplementedException();
    }
    public void WriteCourses()
    {
        throw new System.NotImplementedException();
    }
    public void WriteStudents()
    {
        throw new System.NotImplementedException();
    }
    public void WriteFaculties()
    {
        throw new System.NotImplementedException();
    }
    public void WriteUsers()
    {
        throw new System.NotImplementedException();
    }
}