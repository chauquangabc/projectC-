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
    public partial class UpdateUser : Form
    {
        private User user;
        public UpdateUser(User user)
        {
            InitializeComponent();
            this.user = user;

            txtId.Text = user.Id;
            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPass.Text=user.Password;
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Add("Admin");
            comboBoxRole.Items.Add("User");
            comboBoxRole.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            user.Id = txtId.Text.Trim();
            user.Name = txtName.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            user.Password = txtPass.Text.Trim();
            user.Role = comboBoxRole.SelectedItem.ToString().Trim();
            this.Close();
        }
    }
}
