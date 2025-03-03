using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using buoi2.Models;

namespace buoi2.MyModels
{
    class WindowHangHoaVM : CBaseMVVM
    {
        public WindowHangHoaVM()
        {
            hoadonContext db = new hoadonContext();
            ListHangHoa = db.Hanghoas.ToList();
            lenhxoa = new RelayCommand(lenhxoa_Execute, lenhxoa_CanExecute);
        }
        public string Mahang { get; set; }
        public string Tenhang { get; set; }
        public string Dvt { get; set; }
        public string Dongia { get; set; }
        public Hanghoa SelectionHangHoa { get; set; }

        private List<Hanghoa> m_listHangHoa;
        public List<Hanghoa> ListHangHoa {
            get { return m_listHangHoa; }
            set { m_listHangHoa = value; NotifyPropertyChanged("ListHangHoa"); }
        }
        public RelayCommand lenhthem { get; set; }
        public void lenhthem_Execute(object parameter)
        {
            
        }
        public bool lenhthem_CanExecute(object parameter)
        {
            return true;
        }
        public RelayCommand lenhxoa { get; set; }
        public void lenhxoa_Execute(object parameter)
        {
            hoadonContext db = new hoadonContext();
            db.Hanghoas.Remove(SelectionHangHoa);
           db.SaveChanges();
            ListHangHoa = db.Hanghoas.ToList();
        }
        public  bool lenhxoa_CanExecute(object parameter)
        {
            if(SelectionHangHoa == null)
            {
                return false;
            }
            hoadonContext db = new hoadonContext();
            if(db.Chitiethoadons.Count(t=>t.Mahang == SelectionHangHoa.Mahang)>0)
            {
                return false;
            }
            return true;
        }
    }
}
