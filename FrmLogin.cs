using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuizz
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            cbSelect.Items.Add("User");
            cbSelect.Items.Add("Admin");
            cbSelect.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();

            frmRegister.FormClosed += (s, args) => this.Close();
            frmRegister.Show();
            this.Hide();
        }
      
        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
