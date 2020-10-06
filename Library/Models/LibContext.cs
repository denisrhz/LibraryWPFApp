using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class LibContext
    {
        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection(@"server=WSR-09\SQLEXPRESS;Trusted_Connection=Yes;DataBase=LibraryDB;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public List<User> GetUsers()
        {
            DataTable dt_user = Select("SELECT * FROM [dbo].[Users]");
            List<User> users = new List<User>();
            for (int i = 0; i < dt_user.Rows.Count; i++)
            {
                users.Add(new User { 
                UserId = (int)dt_user.Rows[i][0],
                Login = (string)dt_user.Rows[i][1],
                Password = (string)dt_user.Rows[i][2],
                isBlocked = (bool)dt_user.Rows[i][3],
                Role = (string)dt_user.Rows[i][4]
                });
            };
            return users;
        }
    }
}
