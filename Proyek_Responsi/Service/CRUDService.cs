using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyek_Responsi.Service
{
    public class CRUDService
    {
        private NpgsqlConnection _conn;
        public string ConnectionString_ = "Host=localhost;Username=postgres;Password=password;Port=5432;Database=responsi";

        public CRUDService()
        {
            _conn = new NpgsqlConnection(ConnectionString_);
            try
            {
                _conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured : {ex.Message}");
            }
        }

    }
}
