using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository;

public class StudentRepository : IStudent
{
    public List<StudentModel> getAllStudents()
    {
        return DataSource();
    }
        
    public StudentModel getStudentById(int id)
    {   
        return DataSource().Where(x => x.Rollno == id).FirstOrDefault();
    }

    private List<StudentModel> DataSource()
    {
        return new List<StudentModel>
        {
            new StudentModel { Rollno = 1, Name = "Kumar", Gender = "Male"},
            new StudentModel { Rollno = 2, Name = "Grishma", Gender = "FeMale"},
            new StudentModel { Rollno = 3, Name = "Ziya", Gender = "Female"},
            new StudentModel { Rollno = 4, Name = "Kumar", Gender = "Male"},
            new StudentModel { Rollno = 5, Name = "Grishma", Gender = "FeMale"},
        };
    }
}
