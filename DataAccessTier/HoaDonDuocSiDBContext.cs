using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class HoaDonDuocSiDBContext : DBConnection
    {
        DbSet<HoaDonDuocSi> HoaDonDuocSi { get; set; }
        public HoaDonDuocSiDBContext() { }

        /// <summary>
        /// Adding the Bill for the pharmacist to prepare for patient
        /// </summary>
        /// <param name="HD_ID"></param>
        /// <param name="BN_ID"></param>
        public static void addHoaDonDS(int HD_ID, int BN_ID)
        {
            try
            {
                using (var dbContext = new HoaDonDuocSiDBContext())
                {
                    var newhd = new HoaDonDuocSi()
                    {
                        HD_ID = HD_ID,
                        BN_ID = BN_ID,
                    };
                    dbContext.HoaDonDuocSi.Add(newhd);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
