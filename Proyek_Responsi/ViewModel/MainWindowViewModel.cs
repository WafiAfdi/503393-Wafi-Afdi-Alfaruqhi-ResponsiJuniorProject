using Proyek_Responsi.Model;
using Proyek_Responsi.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyek_Responsi.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {

        public CRUDService _crudService;

        public CRUDService CrudService { get { return _crudService; } }



        private Karyawan? _selected_karyawan;
        public Karyawan Selected_Karyawan { get; }

        public ObservableCollection<Departemen> departemens_tersedia = new ObservableCollection<Departemen>
        {
            new Departemen() { Nama_Dep = "HR", Id_Dep = 1},
            new Departemen() { Nama_Dep = "ENG", Id_Dep = 2},
            new Departemen() { Nama_Dep = "DEV", Id_Dep = 3},
            new Departemen() { Nama_Dep = "PM", Id_Dep = 4},
            new Departemen() { Nama_Dep = "FIN", Id_Dep = 5},
        };

        public Collection<Departemen> departemen_tersedia = new ObservableCollection<Departemen>
        {
            new Departemen() { Nama_Dep = "HR", Id_Dep = 1},
            new Departemen() { Nama_Dep = "ENG", Id_Dep = 2},
            new Departemen() { Nama_Dep = "DEV", Id_Dep = 3},
            new Departemen() { Nama_Dep = "PM", Id_Dep = 4},
            new Departemen() { Nama_Dep = "FIN", Id_Dep = 5},
        };

        public MainWindowViewModel()
        {
            _crudService = new CRUDService();
            _crudService.GetAllKaryawan();

        }

        public void SelectKaryawan(Karyawan karyawan)
        {
            _selected_karyawan = new Karyawan()
            {
                Id_Dep = karyawan.Id_Dep,
                Nama = karyawan.Nama,
                Id_Karyawan = karyawan.Id_Karyawan,
                Nama_Dep = karyawan.Nama_Dep,
            };
        }
    }
}
