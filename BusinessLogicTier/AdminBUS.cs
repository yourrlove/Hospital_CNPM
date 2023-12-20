using DTO;
using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{    
    public class AdminBUS
    {
        public string User_ID = "adm001";

        private static AdminBUS instance;

        private AdminBUS()
        {
        }

        public static AdminBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new AdminBUS();
            }
            return instance;
        }

        public TotalEmployees GetTotalEmployees()
        {
            TotalEmployees totalEmployees = new TotalEmployees();
            totalEmployees.totalCashiers = ThuNganDBContext.CountThuNgan();
            totalEmployees.totalPharmacists = DuocSiDBContext.CountDuocSi();
            totalEmployees.totalDoctors = BacSiDBContext.CountDoctors();
            totalEmployees.totalReceptionists = TiepTanDBContext.CountTiepTan();

            return totalEmployees;
        }

        public Account GetAccount(string User_ID)
        {
            return AccountDBContext.GetAccount(User_ID);
        }

        public bool UpdateAccount(string User_ID, string userName, string password)
        {
            return AccountDBContext.UpdateAccount(User_ID, userName, password); 
        }

        public List<BacSi> GetListBacSi()
        {
            return BacSiDBContext.GetListBacSi();
        }

        public List<DuocSi> GetListDuocSi()
        {
            return DuocSiDBContext.GetListDuocSi();
        }

        public List<TiepTan> GetListTiepTan()
        {
            return TiepTanDBContext.GetListTiepTan();
        }

        public List<ThuNgan> GetListThuNgan()
        {
            return ThuNganDBContext.GetListThuNgan();
        }

        public List<Thuoc> GetListMedicines()
        {
            return ThuocDBContext.GetListThuoc();
        }

        public System.Drawing.Image LoadImage(Byte[] image)
        {
            if (image != null)
            {
                using (var medicineImage = new MemoryStream(image))
                {
                    return System.Drawing.Image.FromStream(medicineImage);
                }
            }
            else
            {
                Console.WriteLine("Image not found.");
                return null;
            }
        }

        public bool DeletedDOCAccount(string User_ID, int BS_ID)
        {
            PhanCongBSDBContext.DeletePCBS(BS_ID);
            BacSiDBContext.DeleteBacSi(BS_ID);
            return AccountDBContext.DeleteAccount(User_ID);
        }

        public bool DeletedDSAccount(string User_ID, int DS_ID)
        {
            DuocSiDBContext.DeleteDuocSi(DS_ID);
            return AccountDBContext.DeleteAccount(User_ID);
        }

        public bool DeletedTNAccount(string User_ID, int TN_ID)
        {
            ThuNganDBContext.DeleteThuNgan(TN_ID);
            return AccountDBContext.DeleteAccount(User_ID);
        }

        public bool DeletedTTAccount(string User_ID, int TT_ID)
        {
            TiepTanDBContext.DeleteTiepTan(TT_ID);
            return AccountDBContext.DeleteAccount(User_ID);
        }
    }
}
