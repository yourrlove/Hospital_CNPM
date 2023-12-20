using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DataAccessTier
{
    public class BenhNhanCheckup
    {
        public int BN_ID { set; get; }
        public string HoTen { set; get; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { set; get; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public int CheckupTimes { set; get; }
    }

    public class BenhNhanDBContext : DBConnection
    {
        public DbSet<BenhAn> BenhAn { get; set; }
        public DbSet<BenhNhan> BenhNhan { get; set; }
        public DbSet<PhanChiaBenhNhan> PhanChiaBenhNhan { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }

        public BenhNhanDBContext() { }

        /// <summary>
        /// Get List of all patient records
        /// </summary>
        /// <returns></returns>
        public static BindingList<BenhNhan>? GetListPatient()
        {
            try
            {
                var dbContext = new BenhNhanDBContext();
                dbContext.BenhNhan.Load();
                return  dbContext.BenhNhan.Local.ToBindingList();

            } catch (Exception e)
            {
                return new BindingList<BenhNhan> ();
            }
        }

        public static List<BenhNhanCheckup>? GetListBenhNhan()
        {
            try
            {
                var dbContext = new BenhNhanDBContext();
                var result = from patient in dbContext.BenhNhan
                             join record in dbContext.BenhAn on patient.BN_ID equals record.BN_ID
                             group record.BA_ID by new { patient.BN_ID, patient.HoTen, patient.GioiTinh, patient.NgaySinh, patient.DiaChi, patient.SoDienThoai} into groupResult
                             select new BenhNhanCheckup
                             {
                                 BN_ID = groupResult.Key.BN_ID,
                                 HoTen = groupResult.Key.HoTen,
                                 GioiTinh = groupResult.Key.GioiTinh,
                                 NgaySinh = groupResult.Key.NgaySinh,
                                 DiaChi = groupResult.Key.DiaChi,
                                 SoDienThoai = groupResult.Key.SoDienThoai,
                                 CheckupTimes = groupResult.Count()
                             };

                return result.ToList();

            }
            catch (Exception e)
            {

            }
            return new List<BenhNhanCheckup>();
        }

        public static List<BenhNhanCheckup>? FindBenhNhanInfor(string name, string tel)
        {
            try
            {
                
                var dbContext = new BenhNhanDBContext();
                var result = from patient in dbContext.BenhNhan
                             join record in dbContext.BenhAn on patient.BN_ID equals record.BN_ID
                             where patient.HoTen.Contains(name) || patient.SoDienThoai.Contains(tel)
                             group record.BA_ID by new { patient.BN_ID, patient.HoTen, patient.GioiTinh, patient.NgaySinh, patient.DiaChi, patient.SoDienThoai } into groupResult
                             select new BenhNhanCheckup
                             {
                                 BN_ID = groupResult.Key.BN_ID,
                                 HoTen = groupResult.Key.HoTen,
                                 GioiTinh = groupResult.Key.GioiTinh,
                                 NgaySinh = groupResult.Key.NgaySinh,
                                 DiaChi = groupResult.Key.DiaChi,
                                 SoDienThoai = groupResult.Key.SoDienThoai,
                                 CheckupTimes = groupResult.Count()
                             };

                return result.ToList();

            }
            catch (Exception e)
            {

            }
            return new List<BenhNhanCheckup>();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="BN_ID"></param>
        /// <param name="HoTen"></param>
        /// <param name="GioiTinh"></param>
        /// <param name="Tuoi"></param>
        /// <param name="DiaChi"></param>
        /// <param name="NgheNghiep"></param>
        public static void AddPatient(BenhNhan newPatient)
        {
            try
            {
                
                var dbContext = new BenhNhanDBContext();
                dbContext.BenhNhan.Add(newPatient);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BenhNhan? FindByID(int ID)
        {
            try
            {
                var dbContext = new BenhNhanDBContext();
                return dbContext.BenhNhan.Find(ID);
            } catch (Exception e)
            {

            }
            return new BenhNhan();
        }

        public static int? GetNofPatients() 
        {
            try
            {
                var dbContext = new BenhNhanDBContext();
                return dbContext.BenhNhan.Count();
            }
            catch (Exception e)
            {
                return 0;
            }
            
        }

        public static void UpdatePatient(int BN_ID, string HoTen, string GioiTinh, DateTime NgaySinh, string DiaChi, string SDT)
        {
            try
            {

                var dbContext = new BenhNhanDBContext();
                var patient = dbContext.BenhNhan.Find(BN_ID);
                patient.HoTen = HoTen ?? patient.HoTen;
                patient.GioiTinh = GioiTinh ?? patient.GioiTinh;
                patient.NgaySinh = NgaySinh;
                patient.DiaChi = DiaChi ?? patient.DiaChi;
                patient.SoDienThoai = SDT ?? patient.SoDienThoai;
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {

            }
        }

        public static List<int> GetPatientInRoom(int PH_ID)
        {
            try
            {

                var dbContext = new BenhNhanDBContext();
                var listBN_ID = PhanChiaBNDBContext.GetListWaitingPatients(PH_ID);
                return dbContext.BenhNhan.Where(record => listBN_ID.Contains(record.BN_ID)).OrderBy(p => p.BN_ID).Select(p=>p.BN_ID).ToList();
            }
            catch (Exception e)
            {
                return new List<int>();
            }
        }

        public static int GetLastestBN_ID()
        {
            try
            {
                var dbContext = new BenhNhanDBContext();
                return dbContext.BenhNhan.OrderByDescending(p => p.BN_ID).Select(p => p.BN_ID).FirstOrDefault();
            }
            catch(Exception e)
            {
                return 0;
            }
        }

        public static bool DeleteByBN_ID(int BN_ID)
        {
            try
            {
                var dbContext = new BenhNhanDBContext();
                var patient = new BenhNhan { BN_ID = BN_ID };
                dbContext.Remove(patient);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool CheckPatientExist(string name, string DoB, string tel)
        {
            try
            {
                DateTime targetDate = DateTime.ParseExact(DoB, "dd/MM/yyyy", CultureInfo.InvariantCulture).Date;
                var dbContext = new BenhNhanDBContext();
                return dbContext.BenhNhan.Any(p => p.HoTen == name && p.NgaySinh.Date == targetDate && p.SoDienThoai == tel);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static PatientInfor? GetPatientInfor(int BN_ID)
        {
            try
            { 
                var dbContext = new BenhNhanDBContext();
                var result = from patient in dbContext.BenhNhan
                             join record in dbContext.BenhAn on patient.BN_ID equals record.BN_ID
                             where patient.BN_ID == BN_ID
                             orderby record.BA_ID descending
                             select new PatientInfor
                             {
                                 HoTen = patient.HoTen,
                                 GioiTinh = patient.GioiTinh,
                                 NgaySinh = patient.NgaySinh.ToString("dd/MM/yyyy"),
                                 ChieuCao = patient.ChieuCao.ToString(),
                                 CanNang = patient.CanNang.ToString(),
                                 DiaChi = patient.DiaChi,
                                 SoDienThoai = patient.SoDienThoai,
                                 NhomMau = patient.NhomMau,
                                 TenBenhAn = record.TenBenhAn,
                                 TrieuChung = record.TrieuChung,
                                 CheckIn = record.Ngay.ToString("dd/MM/yyyy")
                             };
                return result.FirstOrDefault();
            }
            catch (Exception e)
            {
                return new PatientInfor();
            }
        }




        /// <summary>
        /// Search the patients based on patient's name and patient's phone number
        /// </summary>
        /// <param name="s"></param>
        /// <returns>List of patient</returns>
        public static BindingList<BenhNhan>? SearchPatient(string s)
        {
            if (s != "")
            {
                var dbContext = new BenhNhanDBContext();
                dbContext.BenhNhan.Where(t => t.HoTen.Contains(s) || t.SoDienThoai.Contains(s)).Load();
                return dbContext.BenhNhan.Local.ToBindingList();
            }
            return new BindingList<BenhNhan>();
        }

        public static List<BenhNhan> getPatientName(int BN_ID)
        {
            try
            {
                using (var dbContext = new BenhNhanDBContext())
                {
                    var query = (from bn in dbContext.BenhNhan
                                 where bn.BN_ID == BN_ID
                                 select new BenhNhan
                                 {
                                     BN_ID = bn.BN_ID,
                                     HoTen = bn.HoTen,
                                     GioiTinh = bn.GioiTinh,
                                     NgaySinh = bn.NgaySinh,
                                     DiaChi = bn.DiaChi,
                                     SoDienThoai = bn.SoDienThoai,
                                     CanNang = bn.CanNang,
                                     ChieuCao = bn.ChieuCao,
                                     NhomMau = bn.NhomMau
                                 }).ToList();

                    return new List<BenhNhan>(query);
                }
            }
            catch
            {
                return new List<BenhNhan>();
            }
        }

        public static BindingList<HoaDonBenhNhan> GetHoaDonBenhNhan(int BN_ID)
        {
            try
            {
                using (var dbContext = new BenhNhanDBContext())
                {
                    var query = (from hd in dbContext.HoaDon
                                 join ba in dbContext.BenhAn on hd.HD_ID equals ba.BA_ID
                                 where hd.BN_ID == BN_ID
                                 select new HoaDonBenhNhan
                                 {
                                     hd_id = hd.HD_ID,
                                     tenhoadon = ba.TenBenhAn,
                                     ngayxuat = hd.NgayLap,
                                     tongtien = hd.TongTien,
                                     thanhtoan = hd.ThanhToan
                                 }).ToList();
                    var distinctResults = query.Distinct().ToList();
                    return new BindingList<HoaDonBenhNhan>(distinctResults);
                }
            }
            catch (Exception ex)
            {
                return new BindingList<HoaDonBenhNhan>();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BN_ID"></param>
        /// <returns> patient name </returns>
        public static string getName(int BN_ID)
        {
            try
            {
                using (var dbContext = new BenhNhanDBContext())
                {
                    var query = (from bn in dbContext.BenhNhan
                                 where bn.BN_ID == BN_ID
                                 select bn.HoTen).FirstOrDefault();

                    return query != null ? query.ToString() : "No matching record found";
                }
            }
            catch (Exception e)
            {
                return "";
            }
        }
    }
}
