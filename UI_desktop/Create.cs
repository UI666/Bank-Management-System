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
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();

        }

        private void backbuttoncreat_Click(object sender, EventArgs e)
        {
            Wellcome wellcome = new Wellcome();
            wellcome.Show();
            this.Hide();
        }

        private void showbuttoncreat_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Show();
            this.Hide();
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void confermbuttoncreat_Click(object sender, EventArgs e)
        {
            try
            {
                DalAccess dalaccess = new DalAccess();
                User user = new User();

                user.user_name = username_creat.Text;
                user.account_no = accountno_creat.Text;
                user.address = address_creat.Text;
                user.branch = branch_creat.Text;
                user.balance = Convert.ToDouble(banckbalence_creat.Text);
                user.contact = contactno_creat.Text;
                user.email = email_creat.Text;

                NULL();

                bool result = dalaccess.set_info_from_dal(user);
                if (result)
                    MessageBox.Show("Your Bank Account is created Successfully!");
                else
                    MessageBox.Show("Your Bank Account is not created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NULL()
        {
            username_creat.Text = null;
            accountno_creat.Text = null;
            address_creat.Text = null;
            branch_creat.Text = null;
            banckbalence_creat.Text = null;
            contactno_creat.Text = null;
            email_creat.Text = null;
        }

    }
}
