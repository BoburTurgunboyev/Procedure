using Dapper;
using Procedure2.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Procedure2.Services
{
    public class StudentkaService
    {

        private readonly string connectionstring = WebApplication.CreateBuilder().Configuration.GetConnectionString("string");


        public IEnumerable<Studentka> GetStudentkabyYear(int a,int b)
        {
            using(SqlConnection connection = new SqlConnection(connectionstring)) 
            {
                DynamicParameters parameters = new DynamicParameters(); 
;               parameters.Add("from", a);
                parameters.Add("till", b);

                var student = connection.Query<Studentka>("GetStudentsbyYear", parameters, commandType: CommandType.StoredProcedure);

                return student;
            }



        }
      
    }
}
