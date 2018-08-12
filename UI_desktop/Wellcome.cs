using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_desktop
{
    public partial class Wellcome : Form
    {
        public Wellcome()
        {
            InitializeComponent();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            Create creat = new Create();
            creat.Show();
            this.Hide();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            Logein login = new Logein();
            login.Show();
            this.Hide();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Wellcome_Load(object sender, EventArgs e)
        {

        }
    }
}
