using MyMVC.Models;

namespace MyMVC.Новая_папка1
{
    public interface IStudent
    {
        IEnumerable<Student> getStudentsAll();
        Student GetStudentById(int id);
        Result StudentAdd(Student model);
    }
}
