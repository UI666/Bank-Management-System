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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
            DalAccess dalaccess = new DalAccess();
            User[] user = dalaccess.get_info_from_dal();
            data_grid_view();

            for (int j = 0; ; j++)
            {
                if (user[j] == null)
                    break;
                dataGridView1.Rows.Add(user[j].user_name, user[j].address, user[j].branch, user[j].balance , user[j].contact, user[j].email );
            }
        }

        private void backstroe_Click(object sender, EventArgs e)
        {
            Wellcome wellcome = new Wellcome();
            wellcome.Show();
            this.Hide();
        }

        private void exitstore_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Store_Load(object sender, EventArgs e)
        {

        }

        public void data_grid_view()
        {
            dataGridView1.ColumnCount = 7;

            dataGridView1.Columns[0].Name = "User Name";
            dataGridView1.Columns[1].Name = "Address";
            dataGridView1.Columns[2].Name = "Branch";
            dataGridView1.Columns[3].Name = "B: Balance";
            dataGridView1.Columns[4].Name = "Contact No";
            dataGridView1.Columns[5].Name = "Email";
        }
    }
}
