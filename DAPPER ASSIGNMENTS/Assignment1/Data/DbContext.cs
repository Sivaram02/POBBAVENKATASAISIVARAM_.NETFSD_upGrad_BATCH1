using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Assignment1.Data
{
    public class DbContext
    {
        private readonly string _connection = "Data Source=LAPTOP-D08GSENH\\SQLEXPRESS01;Initial Catalog=NewPractisedb;Integrated Security=True;Trust Server Certificate=True;";
        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connection);
        }
    }
}
