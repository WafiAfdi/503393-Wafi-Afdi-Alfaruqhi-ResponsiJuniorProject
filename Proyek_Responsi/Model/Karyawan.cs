using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyek_Responsi.Model
{
    public class Karyawan : ModelBase
    {
        public string? Id_Karyawan {  get; set; }
        public string? Nama { get; set; }
        public int Id_Dep {  get; set; }
        public string? Nama_Dep { get; set; }
    }
}
