using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class PhanChiaBNDBContext : DBConnection
    {
        public DbSet<PhanChiaBenhNhan> PhanChiaBenhNhan { get; set; }
        public PhanChiaBNDBContext() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PH_ID"></param>
        /// <returns></returns>
        public static List<int>? GetListWaitingPatients(int PH_ID)
        {
            try
            {
                var dbContext = new PhanChiaBNDBContext();

                return dbContext.PhanChiaBenhNhan.Where(p => p.PH_ID == PH_ID).Select(p => p.BN_ID).ToList();
            } catch(Exception ex)
            {
              
            }
            return null;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="BN_ID"></param>
        /// <param name="PH_ID"></param>
        public static void AddPatient(int BN_ID, int PH_ID)
        {
            try
            {
                var dbContext = new PhanChiaBNDBContext();
                dbContext.PhanChiaBenhNhan.Add(new PhanChiaBenhNhan { PH_ID = PH_ID, BN_ID = BN_ID });
                dbContext.SaveChanges();
            }
            catch (Exception ex) { }
        }


        public static int NofWaitingPatients(int PH_ID)
        {
            try
            {
                var dbContext = new PhanChiaBNDBContext();
                return dbContext.PhanChiaBenhNhan.Where(p => p.PH_ID == PH_ID).Count();
            }
            catch (Exception ex) { }
            return -1;
        }

        public static List<int> GetListBNID(int PH_ID)
        {
            try
            {
                var dbContext = new PhanChiaBNDBContext();
                return dbContext.PhanChiaBenhNhan.Where(p => p.PH_ID == PH_ID).Select(p => p.BN_ID).ToList();
            } catch (Exception ex)
            {
                return null;
            }
        }

        public static bool DeletePatientInRoom(int BN_ID, int PH_ID)
        {
            try
            {
                var dbContext = new PhanChiaBNDBContext();
                dbContext.Remove(dbContext.PhanChiaBenhNhan.Single(a => a.BN_ID == BN_ID && a.PH_ID == PH_ID));
                dbContext.SaveChanges();
                return true;

            } catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
