using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace DataAccessTier
{
    public class BenhNhanDBContext : DBConnection
    {
        public DbSet<BenhNhan> BenhNhan { get; set; }
        public DbSet<PhanChiaBenhNhan> PhanChiaBenhNhan { get; set; }
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

            }
            return null;
        }

        public static List<BenhNhan>? GetListBenhNhan()
        {
            try
            {
                var dbContext = new BenhNhanDBContext();
                return dbContext.BenhNhan.ToList();

            }
            catch (Exception e)
            {

            }
            return null;
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
        /// Find Patient Record by their name and phone
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        //public static List<BenhNhan>? FindByNameAndPhone(string name, string phone)
        //{
        //    try
        //    {
        //        var dbContext = new BenhNhanDBContext();
        //        return dbContext.BenhNhan.Where(record => record.HoTen.ToLower().Contains(name)).ToList();

        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    return null;
        //}

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
            return null;
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

            }
            return 0;
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
                return null;
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
    }
}
