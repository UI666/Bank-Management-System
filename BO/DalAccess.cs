using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BO
{
    public class DalAccess
    {
        UserInformation userinfo = new UserInformation();

        public bool check_account_from_dal(string name, string accountno)
        {
            return (userinfo.check_account(name,accountno));
        }

        public bool set_info_from_dal(User user)
        {
            if((user.user_name == "") || (user.account_no == "") || (user.address == "") || (user.branch == "") || (user.balance == 0) || (user.contact == "") || (user.email == ""))
            {
                return false;
            }
            else
            {
                return (userinfo.set_info(user));
            }
            
        }

        public bool set_update_from_dal(User[] user)
        {
            return userinfo.set_update(user);
        }

        public User find_account_from_dal()
        {
            return userinfo.find_account();
        }

        public User[] update_account_from_dal(User up_user)
        {
            return userinfo.update_account(up_user);
        }

        public User[] get_info_from_dal()
        {
            return userinfo.get_info();
        }
    }
}
