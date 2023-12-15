using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class PatientRecord
    {
        public int BA_ID {  get; set; }
        public int BN_ID { get; set; }
        public string? RecordName {  get; set; }
        public string PatientName {  get; set; }

        public string PatientSex {  get; set; }
        public string PatientDoB {  get; set; }
        public string Tel {  get; set; }
        public string CheckIn {  get; set; }

    }

    /// <summary>
    /// 
    /// </summary>
    public class BenhAnDBContext : DBConnection
    {
        public DbSet<BenhAn> BenhAn { get; set; }
        public DbSet<BenhNhan> BenhNhan { get; set; }

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
                return dbContext.BenhAn.FirstOrDefault(record => record.BN_ID == BN_ID);
            }
            catch (Exception ex)
            {

            }
            return null;
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

            }
            return -1;
        }

        public static int NumberOfRecordInRoom(int PH_ID)
        {
            try
            {
                return GetPatientRecord(PH_ID).Count();
            }
            catch (Exception ex)
            {

            }
            return -1;
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
                return null;
            }

        }

        public static List<PatientRecord>? FindPatientRecord(string name, DateTime DoB, string sex)
        {
            try
            {
                var dbContext = new BenhAnDBContext();

                var item = (
                     from record in dbContext.BenhAn
                     join patient in dbContext.BenhNhan on record.BN_ID equals patient.BN_ID
                     where patient.HoTen.Contains(name) && patient.GioiTinh == sex && patient.NgaySinh <= DoB
                     select new PatientRecord
                     {
                         BA_ID = record.BA_ID,
                         BN_ID = patient.BN_ID,
                         PatientName = patient.HoTen,
                         PatientSex = patient.GioiTinh,
                         PatientDoB = patient.NgaySinh.Date.ToString("dd/MM/yyyy"),
                         RecordName = record.TenBenhAn ?? "",
                         CheckIn = record.Ngay.Date.ToString("dd/MM/yyyy")
                     }).ToList();
                return item;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static List<PatientRecord> GetPatientRecord(int PH_ID)
        {
            try
            {
                var dbContext = new BenhAnDBContext();
                var listBNID = PhanChiaBNDBContext.GetListBNID(PH_ID);
                var item = (
                     from record in dbContext.BenhAn
                     join patient in dbContext.BenhNhan on record.BN_ID equals patient.BN_ID
                     where listBNID.Contains(record.BN_ID)
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
                return null;
            }

        }

        public static List<PatientRecord> FindByRecordName(string name, int PH_ID)
        {
            try
            {
                var data = GetPatientRecord(PH_ID);
                return data.Where(d => d.RecordName.ToLower().Contains(name)).ToList();
            }
            catch (Exception e)
            {

            }
            return null;
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


    }
}
