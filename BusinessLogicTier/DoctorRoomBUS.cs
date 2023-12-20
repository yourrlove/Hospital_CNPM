using DataAccessTier;
using DTO;
using System.ComponentModel;

namespace BusinessLogicTier
{
    public class DoctorRoomBUS
    {
        public int BN_ID;
        public int BA_ID;
        public int BS_ID;
        public int PH_ID;
        public int KH_ID;
        public object sender;

        public MedicinesTemporary temp1;

        private static DoctorRoomBUS instance;

        private DoctorRoomBUS() 
        {
            temp1 = new MedicinesTemporary();
            BN_ID = 6;
            BA_ID = 0;
            BS_ID = 0;
            PH_ID = 2;
            KH_ID = 1;
            sender = new object();
        }
        
        public static DoctorRoomBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new DoctorRoomBUS();
            } 
            return instance;
        }

        public List<PatientRecord>? GetPatientRecords(int KH_ID)
        {
            return BenhAnDBContext.GetPatientRecordInKhoa(KH_ID);
        }


        public int GetNofRecordsInRoom(int PH_ID)
        {
            return BenhAnDBContext.NumberOfRecordInRoom(PH_ID);
        }

        public List<PatientRecord> FindPatientRecords(string name, int KH_ID)
        {
            return BenhAnDBContext.FindByRecordName(name, KH_ID);
        }

        public List<int> GetListWaitingPatients(int PH_ID)
        {
            return BenhNhanDBContext.GetPatientInRoom(PH_ID);
        }

        public List<ThuocDOC> GetListThuoc()
        {
            return ThuocDBContext.GetAllThuoc();
        }

        public List<Thuoc> SearchMedicines(string pattern)
        {
            return ThuocDBContext.FindByPattern(pattern);
        }

        public Thuoc? GetThuocDetail(int TH_ID)
        {
            return ThuocDBContext.GetThuocDetail(TH_ID);
        }

        public Dictionary<string, string>? GetPatientDetail(int BN_ID, int BS_ID, int PH_ID, int KH_ID)
        {
            var patientDetail = BenhNhanDBContext.FindByID(BN_ID);
            var record = BenhAnDBContext.FindRecordByBN_ID(BN_ID);
            Dictionary<string, string> dict = new Dictionary<string, string>();

         
            dict.Add("BA_ID", record.BA_ID.ToString());
            dict.Add("Name", patientDetail.HoTen);
            dict.Add("DoB", patientDetail.NgaySinh.Date.ToString("dd/MM/yyy"));
            dict.Add("Sex", patientDetail.GioiTinh);
            dict.Add("Tel", patientDetail.SoDienThoai);
            dict.Add("Weight", patientDetail.CanNang.ToString());
            dict.Add("Height", patientDetail.ChieuCao.ToString());
            dict.Add("BloodType", patientDetail.NhomMau);
            dict.Add("RecordName", record.TenBenhAn ?? "");
            dict.Add("CheckIn", record.Ngay.Date.ToString());
            dict.Add("Symtomp", record.TrieuChung ?? "");
            return dict;
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

        public bool ResolvePatientRecord(
            int KH_ID,
            int BA_ID, 
            string recordName, 
            string symtomp,
            string medicalHistory,
            DateTime createDate,
            int BS_ID,
            string prescriptionName,
            DateTime createDT,
            List<DTO.ThuocDOC> list
            )
        {
            try
            {
                BenhAnDBContext.UpdateRecord(BA_ID, recordName, symtomp, createDate);
                if(!CTBADBContext.IsCTBAExist(BA_ID))
                {
                    QuanLiBenhAnDBContext.AddQuanLiBenhAn(KH_ID, BA_ID);
                    QuanLiBenhAnBSDBContext.AddBS_BA(BS_ID, BA_ID);
                    DonThuocDBContext.AddDonThuoc(createDT, BS_ID, prescriptionName);
                    int DT_ID = DonThuocDBContext.GetDT_IDLatest();
                    IList<ChiTietDonThuoc> newList = new List<ChiTietDonThuoc>();
                    foreach (var item in list)
                    {
                        newList.Add(new ChiTietDonThuoc { DT_ID = DT_ID, TH_ID = item.TH_ID, SoLuong = item.Quantity, LieuDung = item.Buoi });
                    }
                    CTBADBContext.AddChiTietBA(BA_ID, DT_ID, medicalHistory);
                    CTDTDBContext.AddChiTietDT(newList);

                } else
                {
                    int DT_ID = CTBADBContext.GetDTID_BA(BA_ID);
                    DonThuocDBContext.UpdateDonThuoc(DT_ID, createDate, prescriptionName);
                    CTDTDBContext.DeleteCTDT(DT_ID);
                    IList<ChiTietDonThuoc> newList = new List<ChiTietDonThuoc>();
                    foreach (var item in list)
                    {
                        newList.Add(new ChiTietDonThuoc { DT_ID = DT_ID, TH_ID = item.TH_ID, SoLuong = item.Quantity, LieuDung = item.Buoi });
                    }
                    CTDTDBContext.AddChiTietDT(newList);
                    CTBADBContext.UpdateCTBA(BA_ID, medicalHistory);
                }
                return true;
            } catch
            {
                return false;
            }
        }

        public bool UpdateRerod(int BA_ID, string recordName, string symtomp, DateTime createDate)
        {
           return BenhAnDBContext.UpdateRecord(BA_ID, recordName, symtomp, createDate);
        }

        public bool MovePatient(int BN_ID, int PH_ID)
        {
            return PhanChiaBNDBContext.DeletePatientInRoom(BN_ID, PH_ID);
        }

        public PatientInfor? GetPatientInfor(int BN_ID)
        {
            return BenhNhanDBContext.GetPatientInfor(BN_ID);
        }

        public Record GetMedicalRecord(int BA_ID, int BN_ID)
        {
            BenhAn3 detail = BenhAnDBContext.FindPatientRecord(BA_ID);
            string TenKhoa = KhoaDBContext.GetKhoaName(KH_ID);
            int BS_ID = QuanLiBenhAnBSDBContext.GetBSID(BA_ID);
            string BacSi = BacSiDBContext.GetDoctorName(BS_ID);
            PatientInfor patient = BenhNhanDBContext.GetPatientInfor(BN_ID);
            DonThuocDetail donThuocDetail = DonThuocDBContext.GetDonThuocDetail(detail.DT_ID);

            Record medical = new Record
            {
                HoTen = patient.HoTen,
                GioiTinh = patient.GioiTinh,
                NgaySinh = patient.NgaySinh,
                ChieuCao = patient.ChieuCao ?? "",
                CanNang = patient.CanNang ?? "",
                NhomMau = patient.NhomMau ?? "",
                DiaChi = patient.DiaChi,
                SoDienThoai = patient.SoDienThoai ?? "",
                TenBenhAn = detail.TenBenhAn,
                TrieuChung = detail.TrieuChung ?? "",
                TSBenhLi = detail.TSBenhLi ?? "",
                Ngay = detail.Ngay,
                BacSi = BacSi,
                TenKhoa = TenKhoa,
                TenDonThuoc = donThuocDetail.TenDonThuoc,
                lists = donThuocDetail.Lists ?? null
            };
            return medical;
        }
    }
}
