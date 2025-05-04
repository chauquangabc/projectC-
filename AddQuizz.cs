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
    public partial class AddQuizz : Form
    {
        private List<Quizz> _listQizz;
        public AddQuizz(List<Quizz> listQizz)
        {
            InitializeComponent();
        _listQizz = listQizz;
        }
        private void AddQuizz_Load(object sender, EventArgs e)
        {

        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string name = txtName.Text.Trim();
            string des = txtDes.Text.Trim();

            _listQizz.Add(new Quizz(id, name, des));

            this.Close();

        }
    }
}
