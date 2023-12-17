using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Current
    {
        public int BN_ID { get; set; }
        public int HD_ID { get; set; }
        public int TH_ID { get; set; }
    }
    /// <summary>
    /// class to display the Bill
    /// </summary>
    /// 
    public class hoadonHT
    {
        public int hd_id { get; set; }
        public int th_id { get; set; }
        public string th_name { get; set; }
        public int soluong { get; set; }
        public double dongia { get; set; }
    }


    public class HoaDonTonKho : hoadonHT,INotifyPropertyChanged
    {
        private int tonkho;
        public int TonKho
        {
            get
            {
                return this.tonkho;
            }
            set
            {
                if (value != this.tonkho)
                {
                    this.tonkho = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }


    /// <summary>
    /// class to display the list of prescription for pharmacist 
    /// </summary>

    public class listHTcho
    {
        [Key]
        public int HD_ID { get; set; }
        public int BN_ID { get; set; }
        public string sodienthoai { get; set; }
        public string tenbenhnhan { get; set; }
    }

}
