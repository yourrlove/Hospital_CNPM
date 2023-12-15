using BusinessLogicTier;
using DataAccessTier;
using DTO;
using System;

namespace asdsa
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<BenhNhan> list = new List<BenhNhan>();
            //list = BenhNhanDBContext.FindByNameAndPhone("Anh", "123");
            //foreach (var x in list)
            //{
            //    Console.WriteLine(x.GioiTinh);
            //}

            //BenhNhanDBContext.AddPatientRecord("Nhat Nam", "Nam", DateTime.Now, "147/2", "0867578");
            //List<Account> list = new List<Account>();
            //list = AccountDBContext.GetListAccount();
            //foreach (var patient in list)
            //{
            //    Console.WriteLine($"{patient.User_ID}");
            //}
            var dbContext = new PhanChiaBNDBContext();
            var listBNID = new List<int>();
            listBNID = dbContext.PhanChiaBenhNhan.Where(p => p.PH_ID == 4).Select(p => p.BN_ID).ToList();

            var data = BenhAnDBContext.GetPatientRecord(4);

            //var data = BenhAnDBContext.FindPatientRecord("Van C" , DateTime.Now, "Nam");
            foreach (var record in data)
            {
                Console.WriteLine(record);
            }
        }
    }
}
