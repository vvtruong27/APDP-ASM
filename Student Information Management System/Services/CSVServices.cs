public class CSVServices {
    private String filePath;
    private static CSVServices instance;

    private CSVServices() {}

    public static CSVServices getInstance() {
        if (instance == null) {
            instance = new CSVServices();
        }
        return instance;
    }

    public void readData() {}
    public void writeData() {}
    public void readCourse() {}
    public void writeCourse() {}
    public void readUser() {}
    public void writeUser() {}
    public void readStudent() {}
    public void writeStudent() {}
    public void readFaculty() {}
    public void writeFaculty() {}
}