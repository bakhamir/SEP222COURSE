using MyMVC.Новая_папка1;
using MyMVC.Models;
using System.Data.SqlClient;
using Dapper;

namespace MyMVC.IService

{
    public class StudentService : IStudent
    {
        readonly string constr = @"Server=206-4\\SQLEXPRESS;Database=testdb;Trusted_Connection=True;";
        public IEnumerable<Student> getStudentsAll()
        {
            using (SqlConnection db = new SqlConnection(constr))
            {
                return db.Query<Student>("pStudent",commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public Student GetStudentById(int id)
        {
            using (SqlConnection db = new SqlConnection(constr))
            {
                var student = db.ExecuteScalar<Student>("pStudent", new { id = id }, commandType: System.Data.CommandType.StoredProcedure);

                return student;
            }
        }

        public Result StudentAdd(Student model) { throw new NotImplementedException(); }
    }
}
