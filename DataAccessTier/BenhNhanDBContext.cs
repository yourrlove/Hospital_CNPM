using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DataAccessTier
{
    public class BenhNhanDBContext : DBConnection
    {
        public DbSet<BenhNhan> BenhNhan { get; set; }
        public DbSet<BenhAn> BenhAn { get; set; }
        public DbSet<HoaDon> HoaDon {  get; set; }
        public BenhNhanDBContext() { }


        /// <summary>
        /// Using binding list to display the list in the datagrid view
        /// </summary>
        /// <returns>The list of patients </returns>
        public static BindingList<BenhNhan>? GetListBenhNhan()
        {
            try
            {
                using (var dbContext = new BenhNhanDBContext())
                {
                    var query = dbContext.BenhNhan
                        .Select(t => new BenhNhan
                        {
                            BN_ID = t.BN_ID,
                            HoTen = t.HoTen,
                            NgaySinh = t.NgaySinh,
                            GioiTinh = t.GioiTinh,
                            SoDienThoai = t.SoDienThoai,
                            CanNang = t.CanNang,
                            ChieuCao = t.ChieuCao,
                            NhomMau = t.NhomMau
                        })
                        .ToList();

                    return new BindingList<BenhNhan>(query);
                }
            }catch (Exception ex) 
            { 
                return null;
            }
        }
        /// <summary>
        /// Search the patients based on patient's name and patient's phone number
        /// </summary>
        /// <param name="s"></param>
        /// <returns>The list of patients </returns>
        public static BindingList<BenhNhan>? SearchBenhNhan(string s)
        {
            if (s != "")
            {
                var dbContext = new BenhNhanDBContext();
                dbContext.BenhNhan.Where(t => t.HoTen.Contains(s) || t.SoDienThoai.Contains(s)).Load();
                return dbContext.BenhNhan.Local.ToBindingList();
            }
            return null;
        }
        /// <summary>
        /// Adding the patient in database based on patient's information
        /// </summary>
        /// <param name="BN_ID"></param>
        /// <param name="HoTen"></param>
        /// <param name="GioiTinh"></param>
        /// <param name="NgaySinh"></param>
        /// <param name="DiaChi"></param>
        /// <param name="SoDienThoai"></param>
        public static void AddBenhNhan(int BN_ID, string HoTen, string GioiTinh, string NgaySinh, string DiaChi, string SoDienThoai)
        {
            var dbContext = new BenhNhanDBContext();
            try
            {
                DateTime ngaySinh = DateTime.ParseExact(NgaySinh, "d/M/yyyy", CultureInfo.InvariantCulture);

                dbContext.BenhNhan.Add(new BenhNhan
                {
                    BN_ID = BN_ID,
                    HoTen = HoTen,
                    GioiTinh = GioiTinh,
                    NgaySinh = ngaySinh,
                    DiaChi = DiaChi,
                    SoDienThoai = SoDienThoai

                });
                dbContext.SaveChanges();
            }
            catch (Exception ex) { }
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
            return null;
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
    }
}
