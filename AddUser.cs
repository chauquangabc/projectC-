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
    public partial class AddUser : Form
    {
        private List<User> _users;

        public AddUser(List<User> users)
        {
            InitializeComponent();
            _users = users;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Add("Admin");
            comboBoxRole.Items.Add("User");
            comboBoxRole.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String id = txtId.Text.Trim();
            String name = txtName.Text.Trim();
            String email = txtEmail.Text.Trim();    
            String password = txtPassword.Text.Trim();
            String role = comboBoxRole.SelectedItem.ToString().Trim();

            _users.Add(new User(id, name, email, password, role));

            this.Close();


        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
