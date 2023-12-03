using Google.Cloud.Firestore;
using Patient_Follow_Up.Class;
using Patient_Follow_Up.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Patient_Follow_Up
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // şifremi unuttum
        private void BacktoregisterButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(Tckimliktextbox.Text) || string.IsNullOrEmpty(Sifretextbox.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanlarını doldurun!");
                return;
            }
            if (Tckimliktextbox.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır.");
                return;
            }
            
            string username = Tckimliktextbox.Text.Trim();
            string password = Sifretextbox.Text;

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(username);



            try
            {
                UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

                if (data != null)
                {
                    if (password == Security.Decrypt(data.Password))
                    {
                        MessageBox.Show("Giriş Başarılı!");
                        Hide();
                        Anasayfa form = new Anasayfa(data);
                        form.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adını veya Şifreyi Girdiniz!");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adını veya Şifreyi Yanlış Girdiniz!");
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda uyarı ver
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }


        private void Tckimliktextbox_TextChanged(object sender, EventArgs e)
        {
            // Eğer metin kutusu boşsa, işlemi sonlandır
            if (string.IsNullOrEmpty(Tckimliktextbox.Text))
            {
                return;
            }

            // Metin kutusundan sadece sayısal karakterleri al
            string numericText = new string(Tckimliktextbox.Text.Where(char.IsDigit).ToArray());

            // Eğer sayısal karakterler içermeyen bir karakter varsa, metni güncelle
            if (Tckimliktextbox.Text != numericText)
            {
                Tckimliktextbox.Text = numericText;
                Tckimliktextbox.SelectionStart = numericText.Length;
            }
        }
    }
}
