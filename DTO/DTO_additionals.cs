using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThuocDOC : INotifyPropertyChanged
    {
        // These fields hold the values for the public properties.
        private int tH_ID;
        private string name = string.Empty;
        private int quantity = 0;
        private string buoi = String.Empty;

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public int TH_ID 
        {
            get
            {
                return this.tH_ID;
            }
            set { this.tH_ID = value; }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                if (value != this.quantity)
                {
                    this.quantity = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Buoi
        {
            get
            {
                return this.buoi;
            }

            set
            {
                if (value != this.buoi)
                {
                    this.buoi = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }

    public class PatientRecord : INotifyPropertyChanged
    {
        // These fields hold the values for the public properties.
        private int bA_ID = 0;
        private int bN_ID = 0;
        private string? recordName = String.Empty;
        private string  patientName = String.Empty;
        private string patientSex = String.Empty;
        private string patientDoB = string.Empty;
        private string tel = string.Empty;
        private string checkIn = String.Empty;


        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public int BA_ID
        {
            get
            {
                return this.bA_ID;
            }

            set
            {
                if (value != this.bA_ID)
                {
                    this.bA_ID = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public int BN_ID
        {
            get
            {
                return this.bN_ID;
            }

            set
            {
                if (value != this.bN_ID)
                {
                    this.bN_ID = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string? RecordName
        {
            get
            {
                return this.recordName;
            }

            set
            {
                if (value != this.recordName)
                {
                    this.recordName = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string PatientName
        {
            get
            {
                return this.patientName;
            }

            set
            {
                if (value != this.patientName)
                {
                    this.patientName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string PatientSex
        {
            get
            {
                return this.patientSex;
            }

            set
            {
                if (value != this.patientSex)
                {
                    this.patientSex = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string PatientDoB
        {
            get
            {
                return this.patientDoB;
            }

            set
            {
                if (value != this.patientDoB)
                {
                    this.patientDoB = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Tel
        {
            get
            {
                return this.tel;
            }

            set
            {
                if (value != this.tel)
                {
                    this.tel = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string CheckIn
        {
            get
            {
                return this.checkIn;
            }

            set
            {
                if (value != this.checkIn)
                {
                    this.checkIn = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }

    public class MedicinesTemporary
    {
        public string prescriptionName;
        public DateTime createDate;
        public List<ThuocDOC> list;

        public MedicinesTemporary()
        {
            prescriptionName = string.Empty;
            createDate = DateTime.Now;
            list = new List<ThuocDOC>();
        }
    }

    public class BenhAn2
    {
        [Required(ErrorMessage = "Record name is required!")]
        [StringLength(50)]
        public string TenBenhAn { get; set; }
        [Required(ErrorMessage = "Date created is required!")]
        public DateTime Ngay { get; set; }
    }

    public class BenhAn3
    {
        public int DT_ID { get; set; }
        public string? TenBenhAn { get; set; }
        public string? TrieuChung { get; set; }
        public string Ngay { get; set; }
        public string? TSBenhLi { get; set; }
    }

    public class PatientInfor
    {
        public string HoTen { set; get; }
        public string GioiTinh { get; set; }
        public string NgaySinh { set; get; }
        public string ChieuCao { get; set; }
        public string CanNang {  get; set; }
        public string NhomMau { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string TenBenhAn { set; get; }
        public string TrieuChung { set; get; }
        public string CheckIn { set; get; }
    }

    public class PatientInfor2
    {
        public string HoTen { set; get; }
        public string GioiTinh { get; set; }
        public string NgaySinh { set; get; }
        public string ChieuCao { get; set; }
        public string CanNang { get; set; }
        public string TenBenhAn { set; get; }
        public string TrieuChung { set; get; }
    }

    public class Record
    {
        public string TenBenhAn { get; set; }
        public string? TrieuChung { get; set; }
        public string Ngay { get; set; }
        public string? TSBenhLi { get; set; }
        public string HoTen { set; get; }
        public string GioiTinh { get; set; }
        public string NgaySinh { set; get; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string? NhomMau { get; set; }
        public string? CanNang { get; set; }
        public string? ChieuCao { get; set; }
        public string TenKhoa {  get; set; }
        public string BacSi {  get; set; }

        public string TenDonThuoc {  get; set; }
        public List<ThuocDOC> lists { get; set; }
    }


    public class DonThuocDetail
    {
        public string NgayKeDon { get; set; }
        public string TenDonThuoc { get; set; }
        public List<ThuocDOC>? Lists {  get; set; }
    }

    //* Cashier *//
    public class Current
    {
        public int patient { get; set; }
        public int DT_ID { get; set; }
        public int TH_ID { get; set; }
    }

    public class HoaDonBenhNhan
    {
        [Required, Key]
        public int hd_id { get; set; }
        public string tenhoadon { get; set; }
        public DateTime ngayxuat { get; set; }
        public double tongtien { get; set; }
        [Required, StringLength(50)]
        public string thanhtoan { get; set; }
    }


    public class ThuocHoaDon
    {
        [Required, Key]
        public int th_id { get; set; }
        [StringLength(50)]
        public string tenthuoc { get; set; }
        public int soluong { get; set; }
        public double giaban { get; set; }
        public double dongia { get; set; }
    }

    /// <summary>
    /// class to load the Prescription as a bill
    /// </summary>
    public class donthuocLoaded
    {
        public int DT_ID { get; set; }
        public int TH_ID { get; set; }
        public string TenThuoc { set; get; }
        public string LieuDung { set; get; }
        public int SoLuong { set; get; }
        public double DonGia { set; get; }
    }
    /// <summary>
    /// Load medicines information the the number of these medicine in storage
    /// </summary>
    public class donthuocHT
    {
        public int DT_ID { set; get; }
        public int TH_ID { set; get; }
        public string TenThuoc { set; get; }
        public string LieuDung { get; set; }
        public int SoLuong { get; set; }
        public int TonKho { get; set; }

    }

    public class DonKhamBenh
    {
        public int BN_ID { set; get; }
        public string tenKhoa { set; get; }
        public string tenPhong { set; get; }
        public double giakham { set; get; }
        public int PH_ID { set; get; }
    }
    public class Current1
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


    public class HoaDonTonKho : hoadonHT, INotifyPropertyChanged
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
    ///

}




