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
    public class CTDTDBContext : DBConnection
    {
        public DbSet<ChiTietDonThuoc> ChiTietDonThuoc { get; set; }
        public DbSet<Thuoc> Thuoc { get; set; }
        public DbSet<DonThuoc> DonThuoc { get; set; }
        public CTDTDBContext() { }

        public static bool AddChiTietDT(IList<ChiTietDonThuoc> newList)
        {
            try
            {
                var dbContext = new CTDTDBContext();
                dbContext.ChiTietDonThuoc.AddRange(newList);
                dbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        
        public static bool DeleteCTDT(int DT_ID)
        {
            try
            {
                var dbContext = new CTDTDBContext();
                var list = dbContext.ChiTietDonThuoc.Where(p => p.DT_ID == DT_ID);
                foreach(var item in list)
                {
                    dbContext.ChiTietDonThuoc.Remove(item);
                }
                dbContext.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public static List<ThuocDOC> GetMedicines(int DT_ID)
        {
            try
            {
                var dbContext = new CTDTDBContext();
                var item =
                    (
                        from detail in dbContext.ChiTietDonThuoc
                        join medicine in dbContext.Thuoc on detail.TH_ID equals medicine.TH_ID
                        where detail.DT_ID == DT_ID
                        select new ThuocDOC
                        {
                            TH_ID = medicine.TH_ID,
                            Name = medicine.TenThuoc,
                            Quantity = detail.SoLuong,
                            Buoi = detail.LieuDung
                        });

                return item.ToList();
            
            }
            catch { return new List<ThuocDOC>(); }
        }


        /// <summary>
        /// Return the prescription's name 
        /// </summary>
        /// <param name="DT_ID"></param>
        /// <returns>prescription's name </returns>
        public static string TenDon(int DT_ID)
        {
            try
            {
                using (var dbContext = new CTDTDBContext())
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
                return "";
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
                using (var dbContext = new CTDTDBContext())
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
                using (var dbContext = new CTDTDBContext())
                {
                    var query = (
                        from ctdt in dbContext.ChiTietDonThuoc
                        join thuoc in dbContext.Thuoc on ctdt.TH_ID equals thuoc.TH_ID
                        where ctdt.DT_ID == DT_ID
                        select new donthuocHT
                        {
                            DT_ID = DT_ID,
                            TH_ID = ctdt.TH_ID,
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
            return new BindingList<Thuoc>();
        }



    }
}
