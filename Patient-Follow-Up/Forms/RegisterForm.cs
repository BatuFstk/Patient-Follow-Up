using Google.Cloud.Firestore;
using Patient_Follow_Up.Class;
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
            var db = FirestoreHelper.Database;
            if (CheckIfUserAlreadyExist())
            {

                MessageBox.Show("Bu Kimlik Numarasına Sahip Bir Kullanıcı Bulunmaktadır!");
                return;
            }
            var data = GetWriteData();
            DocumentReference docRef = db.Collection("UserData").Document(data.Username);
            docRef.SetAsync(data);
            MessageBox.Show("Hesap oluşturuldu!");
        }

        private UserData GetWriteData()
        {
            
            string username = Kayıttckimliktext.Text.Trim();
            string password =  Security.Encrypt(Kayıtsifretext.Text);

            return new UserData()
            {
                Username = username,
                Password = password

            };

        }
        private bool CheckIfUserAlreadyExist()
        {
            string username = Kayıttckimliktext.Text.Trim();
           

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(username);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if(data != null)
            {
                return true; 

            }
            else
            {
                
                return false;
            }

        }
    }
}
