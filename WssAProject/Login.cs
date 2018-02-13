using ReadFromExcel01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFromExce01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbUser.Text == "wssa1" && tbPwd.Text == "wssa1")
            {
                Form1 frm = new Form1();
                if (!MngFormOps.check_open_forms(frm.Name))
                {
                    this.Hide();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Please Type Correct Username and Password");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



    }
}
