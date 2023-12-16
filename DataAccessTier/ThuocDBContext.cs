using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessTier.DonThuocDBContext;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace DataAccessTier
{
    public class ThuocDBContext : DBConnection
    {
        public DbSet<Thuoc> Thuoc { get; set; }
        public ThuocDBContext() { }

        /// <summary>
        /// Get the medicine list based on the binding list
        /// </summary>
        /// <returns></returns>
        public static BindingList<Thuoc>? GetThuoc()
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

        /// <summary>
        /// Searching the medicine based on the medicine's name
        /// </summary>
        /// <param name="s"></param>
        /// <returns>list of medicine </returns>
        public static BindingList<Thuoc>? SearchThuoc(string s)
        {
            if (s != "")
            {
                var dbContext = new ThuocDBContext();
                dbContext.Thuoc.Where(t => t.TenThuoc.Contains(s)).Load();
                return dbContext.Thuoc.Local.ToBindingList();
            }
            return null;

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

    }
}
