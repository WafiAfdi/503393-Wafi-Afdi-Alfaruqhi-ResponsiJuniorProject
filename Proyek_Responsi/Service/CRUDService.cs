using Npgsql;
using Proyek_Responsi.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

        public Karyawan? InsertNewKaryawan(string name, int id_dep, string new_id_karyawan)
        {
            string query = @"
                INSERT INTO karyawan (id_karyawan, nama, id_dep) VALUES (@id_karyawan_, @nama_, @id_dep);
            
            ";
            var command = new NpgsqlCommand(query, _conn);
            command.Parameters.AddWithValue("id_karyawan_", new_id_karyawan);
            command.Parameters.AddWithValue("nama_", name);
            command.Parameters.AddWithValue("id_dep", id_dep);

            try
            {
                var reader = command.ExecuteNonQuery();
                MessageBox.Show($"Karyawan telah ditambah");
                return new Karyawan()
                {
                    Id_Dep = id_dep,
                    Id_Karyawan = new_id_karyawan,
                    Nama = name
                };
            }
            catch (Exception ex) {
                MessageBox.Show($"Error Occured : {ex.Message}");
                return null;
            }

        }

        public void EditKaryawan(Karyawan karyawan, string nama, int id_Dep)
        {
            string query = @"
                UPDATE karyawan SET nama = @nama_, id_dep = @id_dep_ WHERE id_karyawan = @id_karyawan_;
            
            ";
            var command = new NpgsqlCommand(query, _conn);
            command.Parameters.AddWithValue("id_karyawan_", karyawan.Id_Karyawan);
            command.Parameters.AddWithValue("nama_", nama);
            command.Parameters.AddWithValue("id_dep_", id_Dep);

            try
            {
                var reader = command.ExecuteNonQuery();
                MessageBox.Show($"Karyawan telah diubah");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured : {ex.Message}");
            }

        }

        public bool DeleteKaryawan(Karyawan karyawan)
        {
            string query = @"
                DELETE FROM karyawan WHERE id_karyawan = @id_karyawan_;
            
            ";
            var command = new NpgsqlCommand(query, _conn);
            command.Parameters.AddWithValue("id_karyawan_", karyawan.Id_Karyawan.Trim());

            try
            {
                var reader = command.ExecuteNonQuery();
                if(reader > -1)
                {
                    MessageBox.Show($"Karyawan telah dihapus");
                } else
                {
                    MessageBox.Show($"Karyawan tidak ditemukan dan tidak ada yang dihapus");

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured : {ex.Message}");
                return false;
            }

        }

        public DataTable? GetAllKaryawan()
        {
            string query = @"
                SELECT karyawan.*, departemen.nama_dep FROM karyawan JOIN departemen ON karyawan.id_dep = departemen.id_dep;            
            ";
            var command = new NpgsqlCommand(query, _conn);
            try
            {
                var reader = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load( reader );
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Occured : {ex.Message}");
                return null;
            }
        }

        //public ObservableCollection<Departemen> GetDepartemen()
        //{

        //}

    }
}
