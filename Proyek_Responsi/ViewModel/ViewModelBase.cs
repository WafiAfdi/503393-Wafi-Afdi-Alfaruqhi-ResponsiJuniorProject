using Proyek_Responsi.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyek_Responsi.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        

        public void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(propertyName, null);
        }

    }
}
