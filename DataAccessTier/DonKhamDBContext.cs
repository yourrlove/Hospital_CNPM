using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class DonKhamDBContext : DBConnection
    {
        DbSet<DonKham> DonKham { get; set; }
        DbSet<BenhNhan> BenhNhan { get; set; }
        DbSet<Khoa> Khoa {  get; set; }
        DbSet<PhongBenh> PhongBenh { get; set; }
        public DonKhamDBContext() { }

        public static BindingList<DonKhamBenh> LoadDonKham(int BN_ID)
        {
            try
            {
                using (var dbContext = new DonKhamDBContext())
                {
                    var query = dbContext.DonKham
                        .Where(t => t.BN_ID == BN_ID)
                        .FirstOrDefault();

                    if (query != null)
                    {
                        var tenphong = dbContext.PhongBenh
                            .Where(t => t.PH_ID == query.PH_ID)
                            .Select(t => t.TenPhong)
                            .FirstOrDefault();

                        var tenkhoa = dbContext.Khoa
                            .Where(t => t.KH_ID == query.KH_ID)
                            .Select(t => t.TenKhoa)
                            .FirstOrDefault();

                        var giakham = dbContext.Khoa
                            .Where(t => t.KH_ID == query.KH_ID)
                            .Select(t => t.GiaKham)
                            .FirstOrDefault();

                        var result = new BindingList<DonKhamBenh>
                                        {
                                            new DonKhamBenh
                                            {
                                                BN_ID = BN_ID,
                                                tenKhoa = tenkhoa,
                                                tenPhong = tenphong,
                                                giakham = giakham, 
                                                PH_ID = query.PH_ID,
                                            }
                                        };

                        return result;
                    }
                    else
                    {
                        return null; 
                    }
                }
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static void DeleteDonKham(int BN_ID)
        {
            try
            {
                using (var dbContext = new DonKhamDBContext())
                {
             
                    var deleted = dbContext.DonKham.FirstOrDefault(t => t.BN_ID == BN_ID);

                    if (deleted != null)
                    {
                        dbContext.DonKham.Remove(deleted);
                        dbContext.SaveChanges();
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }



    }
}
