using DTO;
using DataAccessTier;
using System.ComponentModel;

namespace BusinessLogicTier
{
    public class CashierBUS
    {
        private static CashierBUS instance;

        public static CashierBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new CashierBUS();
            }
            return instance;
        }


        //--------------- BENH NHAN Function ---------------------
        public BindingList<BenhNhan>? GetListBenhNhan()
        {
            return BenhNhanDBContext.GetListBenhNhan();
        }

        public BindingList<BenhNhan>? SearchBenhNhan(string s)
        {
            return BenhNhanDBContext.SearchBenhNhan(s);
        }
        public BindingList<BenhNhan>? SearchPatient(string s)
        {
            return BenhNhanDBContext.SearchPatient(s);
        }
        public List<BenhNhan> getPatientName(int BN_ID)
        {
            return BenhNhanDBContext.getPatientName(BN_ID);
        }



        // ------------------------ CHI TIET DON THUOC Function --------------------
        public string TenDon(int DT_ID)
        {
            return ChiTietDonThuocDBContext.TenDon(DT_ID);
        }
        public BindingList<donthuocLoaded> Kiemtradonthuoc(int DT_ID)
        {
            return ChiTietDonThuocDBContext.Kiemtradonthuoc(DT_ID);
        }
        public BindingList<donthuocHT> LoadDonThuoc(int DT_ID)
        {
            return ChiTietDonThuocDBContext.LoadDonThuoc(DT_ID);
        }
        public BindingList<Thuoc>? GetThuoc1()
        {
            return ChiTietDonThuocDBContext.GetThuoc1();
        }


        // ----------------- CHI TIET HOA DON Function -------------------------------------
        public void addChiTietHoaDon(int HD_ID, int TH_ID, int SoLuong, double DonGia)
        {
            ChiTietHoaDonDBContext.addChiTietHoaDon(HD_ID, TH_ID, SoLuong, DonGia);
        }

        public BindingList<ThuocHoaDon> loadHoaDon(int HD_ID)
        {
            return ChiTietHoaDonDBContext.loadHoaDon(HD_ID);
        }

        //------------------------ DON THUOC Function ------------------------------

        public BindingList<DonThuoc>? GetDonThuocBenhNhan(int BN_ID)
        {
            return DonThuocDBContext.GetDonThuocBenhNhan(BN_ID);
        }

        // ------------------------ HOA DON Function -------------------------------------
        public void addHoaDon(DateTime NgayLap, double TongTien, int TN_ID, int BN_ID, string thanhtoan)
        {
            HoaDonDBContext.addHoaDon(NgayLap, TongTien, TN_ID , BN_ID , thanhtoan);
        }
        public int getLastHD_ID()
        {
            return HoaDonDBContext.getLastHD_ID();
        }

        public BindingList<HoaDonBenhNhan> GetHoaDonBenhNhan(int BN_ID)
        {
            return HoaDonDBContext.GetHoaDonBenhNhan(BN_ID);
        }


        // ----------------------- HAO DON DUOC SI Function --------------------------------
        public void addHoaDonDS(int HD_ID, int BN_ID)
        {
            HoaDonDuocSiDBContext.addHoaDonDS(HD_ID, BN_ID);
        }


        //--------------------------THUOC Function --------------------------------------
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

        public void updateSoLuongThuoc(int TH_ID, int soluong)
        {
            ThuocDBContext.updateSoLuongThuoc(TH_ID, soluong);
        }

        public System.Drawing.Image LoadImage(int thuocId)
        {
            return ThuocDBContext.LoadImage(thuocId);
        }

        // ------------------ PHAN CHIA BENH NHAN Fuction -------------------
        public void AssignPatient(int BN_ID, int PH_ID)
        {
            PhanChiaBenhNhanDBContext.AssignPatient(BN_ID, PH_ID);
        }

        public void deleteRecord(int BN_ID, int PH_ID)
        {
            PhanChiaBenhNhanDBContext.deleteRecord(BN_ID, PH_ID);
        }

        //---------------------- DON KHAM Function ---------------------------------
        public BindingList<DonKhamBenh> LoadDonKham(int BN_ID)
        {
            return DonKhamDBContext.LoadDonKham(BN_ID);
        }

        public void DeleteDonKham(int BN_ID)
        {
            DonKhamDBContext.DeleteDonKham(BN_ID);
        }
    }
}