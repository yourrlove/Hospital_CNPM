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
    public class DonKhamDBContext : DBConnection
    {
        public DbSet<DonKham> DonKham { get; set; }
        public DbSet<BenhNhan> BenhNhan { get; set; }
        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<PhongBenh> PhongBenh { get; set; }
        public DonKhamDBContext() { }


        public static void AddDonKham(int TT_ID, int PH_ID, int KH_ID, BenhAn? record)
        {
            try
            {
                var dbContext = new DonKhamDBContext();
                DonKham item = new DonKham();
                item.BN_ID = record.BN_ID;
                item.TT_ID = TT_ID;
                item.PH_ID = PH_ID;
                item.KH_ID = KH_ID;
                item.TenBenhAn = record.TenBenhAn;
                item.Ngay = record.Ngay;
                item.TrieuChung = record.TrieuChung;
                dbContext.DonKham.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {

            }
        }

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
                        return new BindingList<DonKhamBenh>();
                    }
                }
            }
            catch (Exception ex)
            {

                return new BindingList<DonKhamBenh>();
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


        public static BenhAn? GetRecordInfor(int BN_ID)
        {
            try
            {
                var dbContext = new DonKhamDBContext();
                var query = (from dk in dbContext.DonKham
                             where dk.BN_ID == BN_ID
                             select new BenhAn
                             { 
                                BN_ID = dk.BN_ID,
                                TenBenhAn = dk.TenBenhAn,
                                TrieuChung = dk.TrieuChung,
                                Ngay = dk.Ngay
                             }).ToList();
                return query.FirstOrDefault();
            }
            catch
            {
                return new BenhAn();
            }
        }
    }
}
