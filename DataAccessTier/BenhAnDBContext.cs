using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    /// <summary>
    /// 
    /// </summary>
    public class BenhAnDBContext : DBConnection
    {
        public DbSet<BenhAn> BenhAn { get; set; }
        public DbSet<BenhNhan> BenhNhan { get; set; }
        public DbSet<ChiTietBenhAn> ChiTietBenhAn {  get; set; }
        public DbSet<PhanChiaBenhNhan> PhanChiaBenhNhan { get; set; }
        public BenhAnDBContext() { }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="BA_ID"></param>
        /// <returns></returns>
        public static BenhAn? FindRecordByBN_ID(int BN_ID)
        {
            try
            {
                var dbContext = new BenhAnDBContext();
                return dbContext.BenhAn.OrderByDescending(p=>p.BA_ID).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new BenhAn();
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BA_ID"></param>
        /// <returns></returns>
        public static List<BenhAn>? FindRecordInADay(int BA_ID)
        {
            try
            {
                var dbContext = new BenhAnDBContext();
                return dbContext.BenhAn.Where(record => record.BA_ID == BA_ID && record.Ngay.Date == DateTime.Now.Date).ToList();
            }
            catch (Exception ex)
            {
                return new List<BenhAn>();
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newRecord"></param>
        public static void AddRecord(BenhAn newRecord)
        {
            try
            {
                var dbContext = new BenhAnDBContext();
                dbContext.BenhAn.Add(newRecord);
                dbContext.SaveChanges();
            }
            catch(Exception ex) { 
                
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int NumberOfRecordInADay()
        {
            try
            {
                var dbContext = new BenhAnDBContext();

                return dbContext.BenhAn.Where(record => record.Ngay.Date == DateTime.Now.Date).GroupBy(record => record.BN_ID).Count();
            } catch (Exception ex)
            {

            }
            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int NumberOfRecordInAMonth()
        {

            try
            {
                var dbContext = new BenhAnDBContext();

                return dbContext.BenhAn.Where(record => record.Ngay.Year == DateTime.Now.Year && record.Ngay.Month == DateTime.Now.Month).GroupBy(record => record.BN_ID).Count();

            } catch ( Exception ex)
            {
                return -1;
            }
            
        }

        public static int NumberOfRecordInRoom(int PH_ID)
        {
            try
            {
                return GetPatientRecord(PH_ID).Count();
            }
            catch (Exception ex)
            {
                return -1;
            }
            
        }

        public static List<PatientRecord>? GetAllPatientRecord()
        {
            try
            {
                var dbContext = new BenhAnDBContext();

                var item = (
                     from record in dbContext.BenhAn
                     join patient in dbContext.BenhNhan on record.BN_ID equals patient.BN_ID
                     select new PatientRecord
                     {
                         BA_ID = record.BA_ID,
                         BN_ID = patient.BN_ID,
                         PatientName = patient.HoTen,
                         PatientSex = patient.GioiTinh,
                         PatientDoB = patient.NgaySinh.Date.ToString("dd/MM/yyyy"),
                         RecordName = record.TenBenhAn??"",
                         CheckIn = record.Ngay.Date.ToString("dd/MM/yyyy")
                     }).ToList();
                return item;
            }
            catch (Exception ex)
            {
                return new List<PatientRecord>();
            }

        }

        public static BenhAn3? FindPatientRecord(int BA_ID)
        {
            try
            {
                var dbContext = new BenhAnDBContext();

                var item = (
                     from record in dbContext.BenhAn
                     join detail in dbContext.ChiTietBenhAn on record.BA_ID equals detail.BA_ID
                     where record.BA_ID == BA_ID
                     select new BenhAn3
                     {
                         DT_ID = detail.DT_ID,
                         TenBenhAn = record.TenBenhAn ?? "",
                         TrieuChung = record.TrieuChung ?? "",
                         TSBenhLi = detail.TSBenhLi ?? "",
                         Ngay = record.Ngay.Date.ToString("dd/MM/yyyy")
                     });
                return item.FirstOrDefault();
            }
            catch (Exception ex)
            {
                return new BenhAn3();
            }

        }

        public static List<PatientRecord> GetPatientRecord(int KH_ID)
        {
            try
            {
                var dbContext = new BenhAnDBContext();
                var listBAID = QuanLiBenhAnDBContext.GetListRecords(KH_ID);
                var item = (
                     from record in dbContext.BenhAn
                     join patient in dbContext.BenhNhan on record.BN_ID equals patient.BN_ID
                     where listBAID.Contains(record.BA_ID)
                     select new PatientRecord
                     {
                         BA_ID = record.BA_ID,
                         BN_ID = patient.BN_ID,
                         PatientName = patient.HoTen,
                         PatientSex = patient.GioiTinh,
                         PatientDoB = patient.NgaySinh.Date.ToString("dd/MM/yyyy"),
                         Tel = patient.SoDienThoai,
                         RecordName = record.TenBenhAn ?? "",
                         CheckIn = record.Ngay.Date.ToString("dd/MM/yyyy")
                     }).ToList();
                return item;
            }
            catch (Exception ex)
            {
                return new List<PatientRecord>();
            }

        }

        public static List<PatientRecord> FindByRecordName(string pattern, int KH_ID)
        {
            try
            {
                var data = GetPatientRecord(KH_ID);
                return data.Where(d => d.RecordName.ToLower().Contains(pattern) || d.PatientName.ToLower().Contains(pattern)).ToList();
            }
            catch (Exception e)
            {

            }
            return new List<PatientRecord>();
        }

        public static int? GetLatestBAID()
        {
            try
            {
                var dbContext = new BenhAnDBContext();
                return dbContext.BenhAn.OrderByDescending(p => p.BA_ID).Select(p => p.BA_ID).FirstOrDefault();
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static bool UpdateRecord(int BA_ID, string recordName, string symtomp, DateTime createDate)
        {
            try
            {
                var dbContext = new BenhAnDBContext();
                var record = dbContext.BenhAn.Find(BA_ID);
                if (record != null)
                {
                    record.TenBenhAn = recordName ?? record.TenBenhAn;
                    record.TrieuChung = symtomp ?? record.TrieuChung;
                    record.Ngay = createDate;
                }
                dbContext.SaveChanges();
                return true;
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public static List<PatientRecord>? GetPatientRecordInKhoa(int KH_ID)
        {
            try
            {
                var dbContext = new BenhAnDBContext();
                var listBAID = QuanLiBenhAnDBContext.GetListRecords(KH_ID); 
                var item = (
                     from record in dbContext.BenhAn
                     join patient in dbContext.BenhNhan on record.BN_ID equals patient.BN_ID
                     where listBAID.Contains(record.BA_ID)
                     select new PatientRecord
                     {
                         BA_ID = record.BA_ID,
                         BN_ID = patient.BN_ID,
                         PatientName = patient.HoTen,
                         PatientSex = patient.GioiTinh,
                         PatientDoB = patient.NgaySinh.Date.ToString("dd/MM/yyyy"),
                         Tel = patient.SoDienThoai,
                         RecordName = record.TenBenhAn ?? "",
                         CheckIn = record.Ngay.Date.ToString("dd/MM/yyyy")
                     }).ToList();
                return item;
            }
            catch (Exception ex)
            {
                return new List<PatientRecord>();
            }

        }
    }
}
