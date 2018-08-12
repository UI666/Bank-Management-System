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

namespace UI_desktop
{
    public partial class Logein : Form
    {
        public Logein()
        {
            InitializeComponent();
        }

        private void back_login_Click(object sender, EventArgs e)
        {
            Wellcome wellcome = new Wellcome();
            wellcome.Show();
            this.Hide();
        }

        private void exit_login_Click(object sender, EventArgs e)
        {
            string user_name = username_login.Text;
            string account_no = accountno_logein.Text;
            DalAccess dalaccess = new DalAccess();

            bool result = dalaccess.check_account_from_dal(user_name, account_no);
            if (result)
            {
                Update update = new Update();
                update.Show();
                this.Hide();
            }
            else
            {
                username_login.Text = null;
                accountno_logein.Text = null;
                MessageBox.Show("Incorect User Name OR Account no!");
            }
        }

        private void Logein_Load(object sender, EventArgs e)
        {

        }
    }
}
