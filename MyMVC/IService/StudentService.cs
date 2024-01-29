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

        public Result StudentAdd(Student model) 
        {
            
            using (SqlConnection db = new SqlConnection(constr))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@firstname", $"{model.firstName}");
                parameters.Add("@lastname", $"{model.lastName}");
                parameters.Add("@dob", $"{model.birthDate}");
                var res = db.Query<Student>("pStudentAdd", parameters, commandType: System.Data.CommandType.StoredProcedure);
                Result result = new Result();
                if (res != null) 
                { 
                    result.status = StatusEnum.OK;
                }
                else
                {
                    result.status = StatusEnum.ERROR;
                }
                return result;
            }
        
        }
    }
}
