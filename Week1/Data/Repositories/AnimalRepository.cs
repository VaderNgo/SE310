using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Data.Database;
using Week1.Data.Interfaces;

namespace Week1.Data.Repositories
{
    public class AnimalRepository
    {
        private static AnimalRepository _instance = null;
        public DataTable _dataTable {  get; set; }

        public static AnimalRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AnimalRepository();
                    _instance._dataTable = new DataTable();
                }
                return _instance;
            }
        }

        public void UpdateMilk(string id, double milkProduced)
        {
            string query = "UPDATE ANIMALS SET milkProduced = milkProduced + @MILK WHERE id = @ID";
            SqlCommand cmd = new SqlCommand(query, SQLConnectionManager.Instance.GetConnection());
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@MILK", milkProduced);
            cmd.ExecuteNonQuery();
        }

        public void AddAnimals(int quantity, AnimalType type) {
            try
            {
                for (int i = 0; i < quantity; i++)
                {
                    string query = "INSERT INTO ANIMALS (id, type, milkProduced) VALUES (@ID, @TYPE, @MILK)";
                    SqlCommand cmd = new SqlCommand(query, SQLConnectionManager.Instance.GetConnection());
                    cmd.Parameters.AddWithValue("@ID", Guid.NewGuid().ToString());
                    cmd.Parameters.AddWithValue("@TYPE", type.ToString());
                    cmd.Parameters.AddWithValue("@MILK", 0.0);
                    cmd.ExecuteNonQuery();
                }
                GetAllAnimals();
                    MessageBox.Show("Add animals is successfully", "ADD ANIMALS",
MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Add animals is not successfully", "ADD ANIMALS",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetAllAnimals()
        {
            string query = "SELECT * FROM Animals";
            SqlDataAdapter adapter = new SqlDataAdapter(query, SQLConnectionManager.Instance._connectionString);
            _dataTable.Clear();
            adapter.Fill(_dataTable);

        }

        ~AnimalRepository() { 
        }
    }
}
