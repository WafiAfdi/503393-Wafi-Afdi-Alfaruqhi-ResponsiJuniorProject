using Proyek_Responsi.Model;
using Proyek_Responsi.Service;
using Proyek_Responsi.ViewModel;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Proyek_Responsi
{
    public partial class Form1 : Form
    {
        private CRUDService _crudService;

        private Karyawan? _selected_karyawan;
        private DataGridViewRow _selectedRow;
        public Karyawan Selected_Karyawan { get; }

        public ObservableCollection<Departemen> departemens_tersedia = new ObservableCollection<Departemen>
        {
            new Departemen() { Nama_Dep = "HR", Id_Dep = 1},
            new Departemen() { Nama_Dep = "ENG", Id_Dep = 2},
            new Departemen() { Nama_Dep = "DEV", Id_Dep = 3},
            new Departemen() { Nama_Dep = "PM", Id_Dep = 4},
            new Departemen() { Nama_Dep = "FIN", Id_Dep = 5},
        };

        public Form1()
        {
            InitializeComponent();
            _crudService = new CRUDService();
            DataContext = new MainWindowViewModel();
            data_karyawan_grid.DataSource = _crudService.GetAllKaryawan();
        }

        private void insert_karyawan_baru(object sender, EventArgs e)
        {
            int dep = -1;
            string nama_dep = "";
            bool found = false;
            for (int i = 0; i < departemens_tersedia.Count; i++)
            {
                if (dep_karyawan_combobox.SelectedItem.ToString() == departemens_tersedia[i].Nama_Dep)
                {
                    dep = departemens_tersedia[i].Id_Dep;
                    nama_dep = departemens_tersedia[i].Nama_Dep;
                    found = true;
                    break;
                }
            }
            if (found && String.IsNullOrWhiteSpace(nama_karyawan_textbox.Text) == false && String.IsNullOrWhiteSpace(nama_dep) == false)
            {
                _crudService.InsertNewKaryawan(nama_karyawan_textbox.Text, dep, $"{nama_dep}-{nama_karyawan_textbox.Text}");
                data_karyawan_grid.DataSource = _crudService.GetAllKaryawan();

            }
            else
            {
                MessageBox.Show($"Data tidak valid");
            }
        }

        private void Delete_Karyawan(object sender, EventArgs e)
        {
            if (_selected_karyawan != null)
            {
                _crudService.DeleteKaryawan(_selected_karyawan);
                data_karyawan_grid.DataSource = _crudService.GetAllKaryawan();
            }
            else
            {
                MessageBox.Show($"Karyawan Belum dipilih");
            }
        }

        private void Edit_Karyawan(object sender, EventArgs e)
        {
            if (_selected_karyawan != null)
            {
                _crudService.EditKaryawan(_selected_karyawan);
                data_karyawan_grid.DataSource = _crudService.GetAllKaryawan();
            }
            else
            {
                MessageBox.Show($"Karyawan Belum dipilih");
            }
        }

        private void grid_cell_click(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 )
            {
                _selectedRow = data_karyawan_grid.Rows[e.RowIndex];
                _selected_karyawan = new Karyawan()
                {
                    Id_Dep = Int32.Parse(_selectedRow.Cells["id_dep"].Value.ToString()),
                    Nama = _selectedRow.Cells["nama"].Value.ToString(),
                    Id_Karyawan = _selectedRow.Cells["id_karyawan"].Value.ToString(),
                    Nama_Dep = _selectedRow.Cells["nama_dep"].Value.ToString(),
                };
                nama_karyawan_textbox.Text = _selected_karyawan.Nama;
                dep_karyawan_combobox.SelectedItem = _selected_karyawan.Nama_Dep;
            }
        }
    }
}
