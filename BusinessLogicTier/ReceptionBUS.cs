using DataAccessTier;
using DTO;
using System.ComponentModel;

namespace BusinessLogicTier
{
    public class ReceptionBUS
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patient"></param>
        /// <param name="record"></param>
        public bool PatientRegistration(
            BenhNhan patient,
            string height,
            string weight,
            string bloodType,
            string symtomp,
            DateTime checkIn,
            int PH_ID,
            int KH_ID
            )
        {
            try
            {

                BenhNhanDBContext.AddPatient(patient);

                int BN_ID = BenhNhanDBContext.GetLastestBN_ID();


                PhanChiaBNDBContext.AddPatient(BN_ID, PH_ID);

                BenhAn record = new BenhAn();
                record.TenBenhAn = null;
                record.BN_ID = BN_ID;
                record.Ngay = checkIn;
                record.TrieuChung = symtomp;
                BenhAnDBContext.AddRecord(record);

                int BS_ID = (int)PhanCongBSDBContext.GetPCBS_ID(PH_ID);
                int BA_ID = (int)BenhAnDBContext.GetLatestBAID();

                QuanLiBenhAnDBContext.AddQuanLiBenhAn(KH_ID, BA_ID);
                QuanLiBenhAnBSDBContext.AddBS_BA(BS_ID, BA_ID);

                return true;

            } catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        //public List<(string, string, DateTime)> SearchRecord(string name, string phone)
        //{
        //    var patient = BenhNhanDBContext.FindByNameAndPhone(name, phone).First();
        //    var records = BenhAnDBContext.FindRecordByBN_ID(patient.BN_ID);
        //    List<(string, string, DateTime)> list = new List<(string, string, DateTime)>();

        //    foreach (var record in records)
        //    {
        //        list.Add((patient.HoTen, record.TenBenhAnh, record.Ngay));
        //    }
        //    return list;
        //}

        public List<PatientRecord>? SearchRecord(string name, DateTime DoB, string sex)
        {
            name = name.ToLower();
            return BenhAnDBContext.FindPatientRecord(name, DoB, sex);
        }

        public BindingList<BenhNhan>? GetListPatients()
        {
            return BenhNhanDBContext.GetListPatient();
        }


        public List<PatientRecord>? GetOldPatientRecords()
        {
            return BenhAnDBContext.GetAllPatientRecord();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="BN_ID"></param>
        /// <returns></returns>
        public BenhNhan CopyOldRegistrationForm(int BN_ID)
        {
            return BenhNhanDBContext.FindByID(BN_ID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public (int, int) NofPatientsHaveWorked()
        {
            return (BenhAnDBContext.NumberOfRecordInADay(), BenhAnDBContext.NumberOfRecordInAMonth());
        }


        public Dictionary<int, string> GetALLRoomID()
        { 
            return PhongBenhDBContext.GetALLRoomID();
        }

        public int? GetNofPatients()
        {
            return BenhNhanDBContext.GetNofPatients();
        }


        public bool UpdatePatient(
            int BN_ID,
            string Name,
            string sex,
            DateTime BoD,
            string address,
            string SDT
            )
        {
            try
            {
                BenhNhanDBContext.UpdatePatient(BN_ID, Name, sex, BoD, address, SDT);
                return true;

            } catch
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BN_ID"></param>
        /// <returns></returns>
        public BenhNhan? GetBenhNhan(int BN_ID)
        {
            try
            {
                return BenhNhanDBContext.FindByID(BN_ID);
            }
            catch { return null; }
        }

        public List<PhongBenh> GetRoomInfor(int KH_ID)
        {
            return PhongBenhDBContext.GetRooms(KH_ID);
        }

        public Dictionary<int, string> GetSpecialistInfor()
        {
            return KhoaDBContext.GetKhoa();
        }
        public bool DeletePatient(int BN_ID)
        {
            return BenhNhanDBContext.DeleteByBN_ID(BN_ID);
        }

        public List<Tuple<string, string, int>>? GetRoomState(int KH_ID)
        {
            try
            {
                List<Tuple<string, string, int>> list = new List<Tuple<string, string, int>>();
                var roomsInfor = PhongBenhDBContext.GetRooms(KH_ID);
                foreach (var rooms in roomsInfor)
                {
                    int BS_ID = (int)PhanCongBSDBContext.GetPCBS_ID(rooms.PH_ID);
                    string doctorName = BacSiDBContext.GetDoctorName(BS_ID);
                    var nOfWaiting = PhanChiaBNDBContext.NofWaitingPatients(rooms.PH_ID);
                    if (PhongBenhDBContext.IsRoomFull(nOfWaiting, rooms.PH_ID))
                    {
                        list.Add(new Tuple<string, string, int>(rooms.TenPhong, doctorName, -1));
                    }
                    else
                    {
                        list.Add(new Tuple<string, string, int>(rooms.TenPhong, doctorName, nOfWaiting));
                    }
                }
                return list;
            } catch (Exception ex)
            {
                return null;
            }

        }
    }
}
