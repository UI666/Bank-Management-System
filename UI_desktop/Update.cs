using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using Entity;

namespace UI_desktop
{
    public partial class Update : Form
    {
        double Balence;
        double Check_Balence;
        string Account_no;
        public Update()
        {
            InitializeComponent();

            try
            {
                DalAccess dalaccess = new DalAccess();
                User update_user = dalaccess.find_account_from_dal();

                user_name_update.Text = update_user.user_name;
                Adress_update.Text = update_user.address;
                Branch_update.Text = update_user.branch;
                Deposit_update.Text = "0";
                Withdraw.Text = "0";
                contact_no_update.Text = update_user.contact;
                email_update.Text = update_user.email;

                Account_no = update_user.account_no;
                Balence = update_user.balance;

                set_image(update_user.account_no);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void set_image(string account_no)
        {
            if (account_no.Equals("130209"))
                pictureBox.Image = Resource.sohel;
            else if (account_no.Equals("130239"))
                pictureBox.Image = Resource.rilus;
            else if (account_no.Equals("130228"))
                pictureBox.Image = Resource.RAIHAN;
            else if (account_no.Equals("130210"))
                pictureBox.Image = Resource.TASMIA;
            else if (account_no.Equals("130211"))
                pictureBox.Image = Resource.SABUJ;
            else if (account_no.Equals("130233"))
                pictureBox.Image = Resource.rafa;
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                Check_Balence = (Balence + Convert.ToDouble(Deposit_update.Text)) - Convert.ToDouble(Withdraw.Text);
                if(Check_Balence < 0)
                {
                    MessageBox.Show("Your Balence is Low!");
                }
                else if(Check_Balence>=0)
                {
                    DalAccess dalaccess = new DalAccess();
                    User user = new User();

                    user.user_name = user_name_update.Text;
                    user.account_no = Account_no;
                    user.address = Adress_update.Text;
                    user.branch = Branch_update.Text;
                    user.balance = (Balence + Convert.ToDouble(Deposit_update.Text)) - Convert.ToDouble(Withdraw.Text);
                    user.contact = contact_no_update.Text; ;
                    user.email = email_update.Text;

                    NULL();
                    pictureBox.Image = null;

                    User[] up_user = dalaccess.update_account_from_dal(user);
                    bool result = dalaccess.set_update_from_dal(up_user);
                    if (result)
                        MessageBox.Show("Your Bank Account is Updated Successfully!");
                    else
                        MessageBox.Show("Your Bank Account is not Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NULL()
        {
            user_name_update.Text = null;
            Adress_update.Text = null;
            Branch_update.Text = null;
            Deposit_update.Text = null;
            Withdraw.Text = null;
            contact_no_update.Text = null;
            email_update.Text = null;
        }

        private void show_Click(object sender, EventArgs e)
        {
            Store stor = new Store();
            stor.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Wellcome welcome = new Wellcome();
            welcome.Show();
            this.Hide();
        }
    }
}
