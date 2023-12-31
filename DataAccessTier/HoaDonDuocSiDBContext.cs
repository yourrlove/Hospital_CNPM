﻿using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class HoaDonDuocSiDBContext : DBConnection
    {
        DbSet<HoaDonDuocSi> HoaDonDuocSi { get; set; }
        DbSet<BenhNhan> BenhNhan { get; set; }

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

        /// <summary>
        /// Join table Benh Nhan and HoaDonDuocSi for giving the details of prescription
        /// </summary>
        /// <returns>list of prescription </returns>

        public static BindingList<listHTcho> ListHoaDon1()
        {
            try
            {
                using (var dbContext = new HoaDonDuocSiDBContext())
                {
                    var query = (from hdds in dbContext.HoaDonDuocSi
                                 join bn in dbContext.BenhNhan on hdds.BN_ID equals bn.BN_ID
                                 select new listHTcho
                                 {
                                     HD_ID = hdds.HD_ID,
                                     BN_ID = bn.BN_ID,
                                     sodienthoai = bn.SoDienThoai,
                                     tenbenhnhan = bn.HoTen
                                 }).ToList();
                    return new BindingList<listHTcho>(query);
                }
            }
            catch (Exception ex)
            {
                return new BindingList<listHTcho>();
            }
        }

        /// <summary>
        /// Delete the record the table if the pharmacist have done the prescription
        /// </summary>
        /// <param name="BN_ID"></param>
        /// <param name="HD_ID"></param>
        public static void deleteRecord1(int BN_ID, int HD_ID)
        {
            try
            {
                using (var dbContext = new HoaDonDuocSiDBContext())
                {
                    var deleted = dbContext.HoaDonDuocSi.Where(t => t.HD_ID == HD_ID && t.BN_ID == BN_ID).First();
                    dbContext.HoaDonDuocSi.Remove(deleted);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
