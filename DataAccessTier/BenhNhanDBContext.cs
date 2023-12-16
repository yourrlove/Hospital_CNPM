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
        public BenhNhanDBContext() { }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>patient list </returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BN_ID"></param>
        /// <returns> patient name </returns>
        public static string getName(int BN_ID)
        {
            try
            {
                using (var dbContext  = new BenhNhanDBContext())
                {
                    var query = (from bn in dbContext.BenhNhan
                                where bn.BN_ID == BN_ID
                                select bn.HoTen).FirstOrDefault();

                    return query != null ? query.ToString() : "No matching record found";
                }
            }
            catch(Exception e) 
            {
                return "Error";
            }
        }
            


    }
}
