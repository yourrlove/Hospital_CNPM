using DataAccessTier;
using DTO;
using System.ComponentModel;

namespace BusinessLogicTier
{
    public class ReceptionBUS
    {
        public int TT_ID;
        public int BN_ID;
        public int BA_ID;
        public int BS_ID;
        public int PH_ID;
        public int KH_ID;
        public bool edit;


        // Singleton Design Pattern
        public static ReceptionBUS instance;

        private ReceptionBUS()
        {
            TT_ID = 0;
            BN_ID = 0;
            BA_ID = 0;
            BS_ID = 0;
            PH_ID = 0;
            KH_ID = 0;
            edit = false;
        }

        public static ReceptionBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new ReceptionBUS();
            }
            return instance;
        }
        //

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patient"></param>
        /// <param name="record"></param>
        public bool PatientRegistration(
            BenhNhan patient,
            string recordName,
            string symtomp,
            DateTime checkIn,
            int PH_ID,
            int KH_ID,
            int BN_ID,
            int TT_ID
            )
        {
            try
            {
                if (BN_ID <= 0)
                {
                    if(BenhNhanDBContext.CheckPatientExist(patient.HoTen, patient.NgaySinh.Date.ToString("dd/MM/yyyy"), patient.SoDienThoai))
                    {
                        return false;
                    }
                    BenhNhanDBContext.AddPatient(patient);
                    BN_ID = BenhNhanDBContext.GetLastestBN_ID();
                }
                BenhAn record = new BenhAn();
                record.TenBenhAn = recordName;
                record.BN_ID = BN_ID;
                record.Ngay = checkIn;
                record.TrieuChung = symtomp;
                DonKhamDBContext.AddDonKham(TT_ID, PH_ID, KH_ID, record);
                return true;
            } catch 
            {
                return false;
            }
        }

        public List<BenhNhanCheckup>? SearchRecord(string name, string tel)
        {
            name = name.ToLower();
            if(name == "")
            {
                name = "-1";
            }
            if (tel == "")
            {
                tel = "-1";
            }
            return BenhNhanDBContext.FindBenhNhanInfor(name, tel);
        }

        public List<BenhNhanCheckup>? GetListPatients()
        {
            return BenhNhanDBContext.GetListBenhNhan();
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
