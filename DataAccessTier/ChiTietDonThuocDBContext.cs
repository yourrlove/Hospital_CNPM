using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class ChiTietDonThuocDBContext: DBConnection
    {
        public DbSet<ChiTietDonThuoc> ChiTietDonThuoc { get; set; }
        public DbSet<Thuoc> Thuoc { get; set; }
        public DbSet<DonThuoc> DonThuoc { get; set; }

        public ChiTietDonThuocDBContext() { }
        

        /// <summary>
        /// Return the prescription's name 
        /// </summary>
        /// <param name="DT_ID"></param>
        /// <returns>prescription's name </returns>
        public static string TenDon(int DT_ID)
        {
            try
            {
                using (var dbContext = new ChiTietDonThuocDBContext())
                {
                    var query = (from donthuoc in dbContext.DonThuoc
                                    where donthuoc.DT_ID == DT_ID
                                    select donthuoc.TenDonThuoc).FirstOrDefault();

                    if (query != null)
                    {
                        return query;
                    }
                    else
                    {
                        return "Prescription not found";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return "Not a Prescription";
            }
        }
        /// <summary>
        /// To check the medicine is available in the storage or not
        /// </summary>
        /// <param name="DT_ID"></param>
        /// <returns>list of medicine that is available in the storage </returns>
        public static BindingList<donthuocLoaded> Kiemtradonthuoc(int DT_ID)
        {
            try
            {
                using (var dbContext = new ChiTietDonThuocDBContext())
                {
                    var query = (
                        from ctdt in dbContext.ChiTietDonThuoc
                        join thuoc in dbContext.Thuoc on ctdt.TH_ID equals thuoc.TH_ID
                        where ctdt.DT_ID == DT_ID
                        where ctdt.SoLuong <= thuoc.SoLuong

                        select new donthuocLoaded
                        {
                            DT_ID = ctdt.DT_ID,
                            TH_ID = ctdt.TH_ID,
                            TenThuoc = thuoc.TenThuoc,
                            LieuDung = ctdt.LieuDung,
                            SoLuong = ctdt.SoLuong,
                            DonGia = thuoc.GiaBan,
                        }
                    ).ToList();
                    return new BindingList<donthuocLoaded>(query);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new BindingList<donthuocLoaded>();
            }
        }


        /// <summary>
        /// Using binding list to display the list of prescription in the datagridview including available or not available
        /// </summary>
        /// <param name="DT_ID"></param>
        /// <returns>binding list off prescription </returns>
        public static BindingList<donthuocHT> LoadDonThuoc(int DT_ID)
        {
            try
            {
                using (var dbContext = new ChiTietDonThuocDBContext())
                {
                    var query = (
                        from ctdt in dbContext.ChiTietDonThuoc
                        join thuoc in dbContext.Thuoc on ctdt.TH_ID equals thuoc.TH_ID
                        where ctdt.DT_ID == DT_ID
                        select new donthuocHT
                        {
                            DT_ID = DT_ID,
                            TH_ID= ctdt.TH_ID,
                            TenThuoc = thuoc.TenThuoc,
                            LieuDung = ctdt.LieuDung,
                            SoLuong = ctdt.SoLuong,
                            TonKho = thuoc.SoLuong

                        }
                    ).ToList();
                    return new BindingList<donthuocHT>(query);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new BindingList<donthuocHT>();
            }
        }


        public static BindingList<Thuoc>? GetThuoc1()
        {
            try
            {
                var dbContext = new ThuocDBContext();
                dbContext.Thuoc.Load();
                return dbContext.Thuoc.Local.ToBindingList();
            }
            catch (Exception ex) { }
            return null;
        }
    }
}

