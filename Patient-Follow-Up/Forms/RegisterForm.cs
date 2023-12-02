using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Follow_Up.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BacktoregisterButton_Click(object sender, EventArgs e)
        {

        }

        private void backtologinbutton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
            Close();
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {

        }

        private void GetWriteData()
        {

            string username = Kayıttckimliktext.Text.Trim();
            string password = Kayıtsifretext.Text.Trim();


        }
    }
}
