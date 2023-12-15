using DataAccessTier;
using DTO;
using System.ComponentModel;

namespace BusinessLogicTier
{
    public class DoctorRoomBUS
    {
        public List<PatientRecord> GetPatientRecords(int PH_ID)
        {
            return BenhAnDBContext.GetPatientRecord(PH_ID);
        }


        public int GetNofRecordsInRoom(int PH_ID)
        {
            return BenhAnDBContext.NumberOfRecordInRoom(PH_ID);
        }

        public List<PatientRecord> FindPatientRecords(string name, int PH_ID)
        {
            return BenhAnDBContext.FindByRecordName(name, PH_ID);
        }

        public List<int> GetListWaitingPatients(int PH_ID)
        {
            return BenhNhanDBContext.GetPatientInRoom(PH_ID);
        }

        public List<Thuoc> GetListThuoc()
        {
            return ThuocDBContext.GetAllThuoc();
        }

        public List<Thuoc> SearchMedicines(string pattern)
        {
            return ThuocDBContext.FindByPattern(pattern);
        }

        public Dictionary<string, string>? GetPatientDetail(int BN_ID, int BS_ID, int PH_ID, int KH_ID)
        {
            var patientDetail = BenhNhanDBContext.FindByID(BN_ID);
            var doctorName = BacSiDBContext.GetDoctorName(BS_ID);
            var roomName = PhongBenhDBContext.GetRoomName(PH_ID);
            var specialistName = KhoaDBContext.GetKhoaName(KH_ID);
            var record = BenhAnDBContext.FindRecordByBN_ID(BN_ID);
            Dictionary<string, string> dict = new Dictionary<string, string>();

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
            dict.Add("Doctor", doctorName);
            dict.Add("Room", roomName);
            dict.Add("Specialist", specialistName);

            return dict;
        }
    }
}
