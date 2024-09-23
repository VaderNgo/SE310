using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Week1.Data.Database

{
    public class SQLConnectionManager
    {
        private static SQLConnectionManager _instance = null;

        private SqlConnection _connection;
        public string _connectionString; 

        private SQLConnectionManager()
        {
            _connectionString = "SERVER=.\\SQLExpress;Database=WEEK1;Trusted_Connection=True;";
            _connection = new SqlConnection(_connectionString);
        }



        public static SQLConnectionManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SQLConnectionManager();
                }
                return _instance;
            }
        }

        public SqlConnection GetConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public bool IsConnectionSuccessful()
        {
            try
            {
                GetConnection();

                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Connection successful.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Connection failed.");
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Connection failed with error: {ex.Message}");
                return false;
            }
        }

        ~SQLConnectionManager()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

    }
}
