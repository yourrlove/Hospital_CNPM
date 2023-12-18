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
    public class DonThuocDBContext : DBConnection
    {
        public DbSet<DonThuoc> DonThuoc { get; set; }
        public DbSet<ChiTietBenhAn> ChiTietBenhAn { get; set; }
        public DbSet<BenhAn> BenhAn { get; set; }



        public DonThuocDBContext() { }

        /// <summary>
        /// Get the prescription of specific patient
        /// </summary>
        /// <param name="BN_ID"></param>
        /// <returns></returns>
        public static BindingList<DonThuoc>? GetDonThuocBenhNhan(int BN_ID)
        {
            try
            {
                using (var dbContext = new DonThuocDBContext())
                {
                    var query = (
                        from donthuoc in dbContext.DonThuoc
                        join chitietBA in dbContext.ChiTietBenhAn on donthuoc.DT_ID equals chitietBA.DT_ID
                        join benhan in dbContext.BenhAn on chitietBA.BA_ID equals benhan.BA_ID
                        where benhan.BN_ID == BN_ID
                        select new DonThuoc
                        {
                            DT_ID = donthuoc.DT_ID,
                            NgayKeDon = donthuoc.NgayKeDon,
                            BS_ID = donthuoc.BS_ID,
                            TenDonThuoc = donthuoc.TenDonThuoc
                        }).ToList();

                    return new BindingList<DonThuoc>(query);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

                return new BindingList<DonThuoc>();
            }
        }
    }
}
