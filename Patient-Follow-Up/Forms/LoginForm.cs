using Google.Cloud.Firestore;
using Google.Type;
using Patient_Follow_Up.Class;
using Patient_Follow_Up.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Follow_Up
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BacktoregisterButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
            Close();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = Tckimliktextbox.Text.Trim();
            string password = Sifretextbox.Text;

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(username);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if(data != null)
            {
                if(password == data.Password)
                {

                    MessageBox.Show("Giriş Başarılı!");

                }
                else
                {
                    MessageBox.Show("Yanlış Şifre Girdiniz!");

                }

            }
            else
            {
                MessageBox.Show("Kullanıcı Adını Yanlış Girdiniz!");

            }

        }
    }
}
