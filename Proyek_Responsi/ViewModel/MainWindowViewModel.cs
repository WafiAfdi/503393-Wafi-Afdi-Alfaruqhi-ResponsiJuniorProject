using Proyek_Responsi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyek_Responsi.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {

        private CRUDService _crudService;

        public MainWindowViewModel()
        {
            _crudService = new CRUDService();
        }
    }
}
