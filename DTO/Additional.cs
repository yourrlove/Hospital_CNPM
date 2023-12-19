using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
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
        public double tongtien {  get; set; }
        [Required, StringLength(50)]
        public string thanhtoan { get; set; }
    }


    public class ThuocHoaDon
    {
        [Required, Key]
        public int th_id { get; set; }
        [StringLength(50)]
        public string tenthuoc {  get; set; }
        public int soluong {  get; set; }
        public double giaban {  get; set; }
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
        public int BN_ID {  set; get; }
        public string tenKhoa { set; get; }
        public string tenPhong {  set; get; }
        public double giakham { set; get; }
        public int PH_ID {  set; get; }
    }
}
