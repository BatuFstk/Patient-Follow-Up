﻿using Google.Cloud.Firestore;
using Patient_Follow_Up.Class;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Patient_Follow_Up.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
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

            // Kullanıcı adı ve şifre boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(Kayıttckimliktext.Text) || string.IsNullOrEmpty(Kayıtsifretext.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanlarını doldurun!");
                return;
            }
            if (Kayıttckimliktext.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
                return;
            }

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
            string password = Security.Encrypt(Kayıtsifretext.Text);

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

            try
            {
                UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

                if (data != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda uyarı ver ve false döndür
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
                return false;
            }
        }

        private void Kayıttckimliktext_TextChanged(object sender, EventArgs e)
        {
            // Eğer metin kutusu boşsa, işlemi sonlandır
            if (string.IsNullOrEmpty(Kayıttckimliktext.Text))
            {
                return;
            }

            // Metin kutusundan sadece sayısal karakterleri al
            string numericText = new string(Kayıttckimliktext.Text.Where(char.IsDigit).ToArray());

            // Eğer sayısal karakterler içermeyen bir karakter varsa, metni güncelle
            if (Kayıttckimliktext.Text != numericText)
            {
                Kayıttckimliktext.Text = numericText;
                Kayıttckimliktext.SelectionStart = numericText.Length;
            }
        }
    }
}
