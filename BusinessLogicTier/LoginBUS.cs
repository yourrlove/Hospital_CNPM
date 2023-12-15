using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class LoginBUS
    {
        public string? Validate(string username, string password)
        {
            if(AccountDBContext.Authenticate(username, password))
            {
                return AccountDBContext.GetUserID(username);
            }
            return null;
        }
    }
}
