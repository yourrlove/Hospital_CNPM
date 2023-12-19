using BusinessLogicTier;
using DataAccessTier;
using DTO;
using System;
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
//var dbContext = new PhanChiaBNDBContext();
//var listBNID = new List<int>();
//listBNID = dbContext.PhanChiaBenhNhan.Where(p => p.PH_ID == 4).Select(p => p.BN_ID).ToList();

//var _data = BenhAnDBContext.FindRecordByBN_ID(29);
//Console.WriteLine(_data.BA_ID);

var data = BenhAnDBContext.FindPatientRecord(42);
Console.WriteLine(data.TenBenhAn);
//DonThuocDetail donThuocDetail = DonThuocDBContext.GetDonThuocDetail(6);
//var data = CTDTDBContext.GetMedicines(6);
//Console.WriteLine(donThuocDetail.TenDonThuoc);
//var data = BenhAnDBContext.FindPatientRecord("Van C" , DateTime.Now, "Nam");

