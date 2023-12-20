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

    
    public class ThuocDBContext : DBConnection
    {
        public DbSet<Thuoc> Thuoc { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public ThuocDBContext() { }

        public static List<ThuocDOC> GetAllThuoc()
        {
            try
            {
                var dbContext = new ThuocDBContext();
                return dbContext.Thuoc.Select(p => new ThuocDOC { TH_ID = p.TH_ID, Name = p.TenThuoc, Quantity = p.SoLuong }).ToList();
            }
            catch (Exception ex)
            {
                return new List<ThuocDOC>();
            }
            
        }

        public static List<Thuoc> FindByPattern(string pattern)
        {
            try
            {
                var dbContext = new ThuocDBContext();
                return dbContext.Thuoc.Where(m => m.TenThuoc.ToLower().Contains(pattern.ToLower())).ToList();
            }
            catch { return new List<Thuoc>(); }
            
        }

        public static Thuoc? GetThuocDetail(int TH_ID)
        {
            try
            {
                var dbContext = new ThuocDBContext();
                return dbContext.Thuoc.Find(TH_ID);
            } catch { return new Thuoc(); }
        }


        public static BindingList<Thuoc>? GetThuoc()
        {
            try
            {
                var dbContext = new ThuocDBContext();
                dbContext.Thuoc.Load();
                return dbContext.Thuoc.Local.ToBindingList();
            }
            catch (Exception ex) {
                return new BindingList<Thuoc>();
            }
            
        }

        /// <summary>
        /// Searching the medicine based on the medicine's name
        /// </summary>
        /// <param name="s"></param>
        /// <returns>list of medicine </returns>
        public static BindingList<Thuoc>? SearchThuoc(string s)
        {
            try
            {
                var dbContext = new ThuocDBContext();
                dbContext.Thuoc.Where(t => t.TenThuoc.Contains(s)).Load();
                return dbContext.Thuoc.Local.ToBindingList();
            }
            catch (Exception ex) { return new BindingList<Thuoc>(); }
                
        }

        /// <summary>
        /// getting the price of the medicine
        /// </summary>
        /// <param name="TH_ID"></param>
        /// <returns>the price of the medicine (double ) </returns>
        public static double getGiaBanThuoc(int TH_ID)
        {
            try
            {
                using (var dbContext = new ThuocDBContext())
                {

                    var query = (from thuoc in dbContext.Thuoc
                                 where thuoc.TH_ID == TH_ID
                                 select thuoc.GiaBan).FirstOrDefault();

                    if (query != null)
                    {
                        return Convert.ToDouble(query);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        public static void updateSoLuongThuoc(int TH_ID, int soluong)
        {
            try
            {
                using (var dbContext = new ThuocDBContext())
                {
                    var updated = dbContext.Thuoc.Where(th => th.TH_ID == TH_ID).First();
                    updated.SoLuong = updated.SoLuong - soluong;
                    dbContext.SaveChanges();
                }
            }
            catch
            {

            }
        }

        public static System.Drawing.Image LoadImage(int thuocId)
        {
            var dbContext = new ThuocDBContext();
            try
            {
                var thuoc = dbContext.Thuoc.FirstOrDefault(t => t.TH_ID == thuocId);

                if (thuoc != null && thuoc.ImageData != null)
                {
                    using (var ms = new MemoryStream(thuoc.ImageData))
                    {
                        return System.Drawing.Image.FromStream(ms);
                    }
                }
                else
                {
                    Console.WriteLine("Image not found.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading image: " + ex.Message);
                return null;
            }
        }


        public static Dictionary<int, int> UpdateItem(int HD_ID)
        {
            try
            {
                using (var dbContext = new ThuocDBContext())
                {
                    var query = (from cthd in dbContext.ChiTietHoaDon
                                 join th in dbContext.Thuoc on cthd.TH_ID equals th.TH_ID
                                 where cthd.HD_ID == HD_ID
                                 select new { cthd.TH_ID, cthd.SoLuong })
                                 .ToDictionary(t => t.TH_ID, t => t.SoLuong);

                    return query;
                }
            }
            catch (Exception ex)
            {
                return new Dictionary<int, int>();
            }
        }

        public static void UpdateQuantity(Dictionary<int, int> updated)
        {
            try
            {
                using (var dbContext = new ThuocDBContext())
                {
                    if (updated != null)
                    {
                        foreach (var items in updated)
                        {
                            var item = dbContext.Thuoc.FirstOrDefault(t => t.TH_ID == items.Key);
                            if (item != null)
                            {
                                item.SoLuong += items.Value;
                            }
                        }
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        public static List<Thuoc> GetListThuoc()
        {
            try
            {
                var dbContext = new ThuocDBContext();
                return dbContext.Thuoc.ToList();
            }
            catch { return new List<Thuoc>(); }
        }

    }
}

