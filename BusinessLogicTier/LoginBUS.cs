using DataAccessTier;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class LoginBUS
    {
        private static LoginBUS instance;

        private LoginBUS()
        {
        }

        public static LoginBUS GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginBUS();
            }
            return instance;
        }



        public string? Validate(string username, string password)
        {
            if(AccountDBContext.Authenticate(username, password))
            {
                return AccountDBContext.GetUserID(username, password);
            }
            return null;
        }

        public int? GetID(string UserID, string role)
        {
            if(role == "rec")
            {
                return TiepTanDBContext.GetID(UserID);
            }
            if (role == "cas")
            {
                return ThuNganDBContext.GetID(UserID);
            }
            if (role == "pha")
            {
                return DuocSiDBContext.GetID(UserID);
            }
            if (role == "doc")
            {
                return BacSiDBContext.GetID(UserID);
            }
            return 0;

        }
    }
}
