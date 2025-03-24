public class ManageGrades {
    private CSVServices services;
    public ManageGrades() {
        services = CSVServices.getInstance();
    }
    public bool addGrades(Grade grades, Course course) {
        // Implementation here
        return true;
    }

    public boolean removeGrades(Grades grades, Course course) {
        // Implementation here
        return true;
    }

    public boolean updateGrades(Grades grades, Course course) {
        // Implementation here
        return true;
    }

    public Grades getGrades(Course course) {
        // Implementation here
        return null;
    }
}
