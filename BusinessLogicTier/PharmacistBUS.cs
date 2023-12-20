using DTO;
using DataAccessTier;
using System.ComponentModel;

namespace BussinessLogicTier
{

    public class PharmacistBUS
    {
        private static PharmacistBUS instance;
        public string displayName;

        private PharmacistBUS()
        {
            displayName = string.Empty;
        }

        public static PharmacistBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new PharmacistBUS();
            }
            return instance;
        }


        // ------------------------ BENH NHAN Function -------------------------------
        public BindingList<BenhNhan>? GetListPatient()
        {
            return BenhNhanDBContext.GetListPatient();
        }

        public string getName(int BN_ID)
        {
            return BenhNhanDBContext.getName(BN_ID);
        }

        //------------------------- CHI TIET HOA DON Function -------------------------
        public BindingList<hoadonHT> getHoaDon(int HD_ID)
        {
            return ChiTietHoaDonDBContext.getHoaDon(HD_ID);
        }

        public BindingList<HoaDonTonKho> getHoaDonTonkho(int HD_ID)
        {
            return ChiTietHoaDonDBContext.getHoaDonTonkho(HD_ID);
        }

        // -------------------- DONE PRESCRIPTION Function ------------------------------
        public void addPrescription(int BN_ID, int HD_ID)
        {
            DonePrescriptionDBContext.addPrescription(BN_ID, HD_ID);
        }

        public BindingList<listHTcho> ListHoaDon()
        {
            return DonePrescriptionDBContext.ListHoaDon();
        }
        public void deleteRecord(int BN_ID, int HD_ID)
        {
            DonePrescriptionDBContext.deleteRecord(BN_ID, HD_ID);
        }
        public BindingList<listHTcho> SearchCompletedPrescription(string s)
        {
            return DonePrescriptionDBContext.SearchCompletedPrescription(s);
        }

        //----------------------- HOA DON DUOC SI Function --------------------------------
        public BindingList<listHTcho> ListHoaDon1()
        {
            return HoaDonDuocSiDBContext.ListHoaDon1();
        }

        public void deleteRecord1(int BN_ID, int HD_ID)
        {
            HoaDonDuocSiDBContext.deleteRecord1(BN_ID, HD_ID);
        }

        //---------------------- THUOC Function -----------------------------------------------
        public BindingList<Thuoc>? GetThuoc()
        {
            return ThuocDBContext.GetThuoc();
        }

        public BindingList<Thuoc>? SearchThuoc(string s)
        {
            return ThuocDBContext.SearchThuoc(s);
        }

        public double getGiaBanThuoc(int TH_ID)
        {
            return ThuocDBContext.getGiaBanThuoc(TH_ID);
        }

        public System.Drawing.Image LoadImage(int thuocId)
        {
            return ThuocDBContext.LoadImage(thuocId);
        }
        public Dictionary<int, int> UpdateItem(int HD_ID)
        {
            return ThuocDBContext.UpdateItem(HD_ID);
        }

        public void UpdateQuantity(Dictionary<int, int> updated)
        {
            ThuocDBContext.UpdateQuantity(updated);
        }


    }

}