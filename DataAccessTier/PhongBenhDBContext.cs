using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class PhongBenhDBContext : DBConnection
    {
        public DbSet<PhongBenh> PhongBenh { get; set; }
        public PhongBenhDBContext() { }

        public static List<PhongBenh> GetRooms(int KH_ID)
        {
            try
            {
                var dbContext = new PhongBenhDBContext();

                return dbContext.PhongBenh.Where(room => room.KH_ID == KH_ID).ToList();
            }
            catch 
            { 
                return new List<PhongBenh>();
            }
                
        }

        public static Dictionary<int , string> GetALLRoomID()
        {
            try
            {
                var dbContext = new PhongBenhDBContext();
                return dbContext.PhongBenh.ToDictionary(room => room.PH_ID, room => room.TenPhong);
            }
            catch { return new Dictionary<int , string>(); }
            
        }

        public static bool IsRoomFull(int nofCurrentWaiting, int PH_ID)
        {
            try
            {
                var dbContext = new PhongBenhDBContext();
                return (nofCurrentWaiting == dbContext.PhongBenh.Where(p => p.PH_ID == PH_ID).First().SucChua);

            }
            catch (Exception ex) { return false; }
        }

        public static string GetRoomName(int PH_ID)
        {
            try
            {
                var dbContext = new PhongBenhDBContext();
                return dbContext.PhongBenh.Single(r => r.PH_ID == PH_ID).TenPhong;
            }
            catch
            {
                return "";
            }
            
        }

        public static PhongBenh? FindById(int PH_ID)
        {
            try
            {
                var dbContext = new PhongBenhDBContext();
                return dbContext.PhongBenh.Find(PH_ID);
            }
            catch (Exception ex) 
            {
                return new PhongBenh();
            }
            
        }
    }
}
