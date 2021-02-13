using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ITMO.WFCS.TASK1_DBConnection
{
    class WorkWithDataBase
    {

        public static int ExecuteScalarMetod(string cs, string qv)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = qv;
                int number = (int)command.ExecuteScalar();
                
            return number;
            }
        }
    }
}
