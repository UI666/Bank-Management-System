using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;

namespace DAL
{
    public class UserInformation
    {
        static int count = 0;
        public bool check_account(string name, string accountno)
        {
            StreamReader streamreder = new StreamReader("E: \\text.txt ");
            string str;
            int flag = 0;
            try
            {
                while ((str = streamreder.ReadLine()) != null)
                {
                    count++;
                    if (name.Equals(str))
                    {
                        str = streamreder.ReadLine();
                        if (accountno.Equals(str))
                        {
                            flag = 1;
                            break;
                        }
                    }
                }
                streamreder.Close();
                if (flag == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool set_info(User user)
        {
            try
            {
                StreamWriter write = new StreamWriter("E:\\text.txt", true);
                write.WriteLine(user.user_name);
                write.WriteLine(user.account_no);
                write.WriteLine(user.address);
                write.WriteLine(user.branch);
                write.WriteLine(user.balance);
                write.WriteLine(user.contact);
                write.WriteLine(user.email);

                write.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool set_update(User[] user)
        {
            try
            {
                StreamWriter write = new StreamWriter("E:\\text.txt");
                for (int i = 0; ; i++)
                {
                    if (user[i] == null)
                        break;
                    write.WriteLine(user[i].user_name);
                    write.WriteLine(user[i].account_no);
                    write.WriteLine(user[i].address);
                    write.WriteLine(user[i].branch);
                    write.WriteLine(user[i].balance);
                    write.WriteLine(user[i].contact);
                    write.WriteLine(user[i].email);
                }
                write.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public User find_account()
        {
            User update_user = new User();
            User[] user = get_info();
            count = count / 8;
            try
            {
                update_user.user_name = user[count].user_name;
                update_user.account_no = user[count].account_no;
                update_user.address = user[count].address;
                update_user.branch = user[count].branch;
                update_user.balance = user[count].balance;
                update_user.contact = user[count].contact;
                update_user.email = user[count].email;
                return update_user;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public User[] update_account(User up_user)
        {
            User[] user = get_info();

            user[count].user_name = up_user.user_name;
            user[count].account_no = up_user.account_no;
            user[count].address = up_user.address;
            user[count].branch = up_user.branch;
            user[count].balance = up_user.balance;
            user[count].contact = up_user.contact;
            user[count].email = up_user.email;

            count = 0;

            return user;
        }

        public User[] get_info()
        {
            try
            {
                StreamReader streamreder = new StreamReader("D: \\text.txt ");
                User[] user = new User[50];
                int i = 0;
                string str;
                while ((str = streamreder.ReadLine()) != null)
                {
                    user[i] = new User();
                    user[i].user_name = str;
                    user[i].account_no = streamreder.ReadLine();
                    user[i].address = streamreder.ReadLine();
                    user[i].branch = streamreder.ReadLine();
                    user[i].balance = Convert.ToDouble(streamreder.ReadLine());
                    user[i].contact = streamreder.ReadLine();
                    user[i].email = streamreder.ReadLine();
                    i++;
                }
                streamreder.Close();
                return user;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
