using FireSharp.Response;
using Google.Cloud.Firestore;
using Patient_Follow_Up.Class;
using Patient_Follow_Up.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Patient_Follow_Up.Forms
{
    public partial class Anasayfa : Form
    {
        private UserData loggedInUser;

        public Anasayfa(UserData loggedInUser)
        {
            InitializeComponent();

            // Giriş yapan doktorun verilerini al
            this.loggedInUser = loggedInUser;

            // loggedInDoctorData'dan doktor bilgilerini kullanarak Firestore'a erişebilirsiniz

            // DataGridView'e sütunları ekle
            HastalariGoruntule.Columns.Add("Tc", "TC");
            HastalariGoruntule.Columns.Add("Name", "İsim");
            HastalariGoruntule.Columns.Add("Surname", "Soyisim");
            HastalariGoruntule.Columns.Add("Birth", "Doğum Tarihi");
            HastalariGoruntule.Columns.Add("Gender", "Cinsiyet");
            HastalariGoruntule.Columns.Add("Barcode", "Barkod");
            HastalariGoruntule.Columns.Add("EntryDate", "Giriş Tarihi");
            HastalariGoruntule.Columns.Add("AcceptDate", "Onay Tarihi");
            HastalariGoruntule.Columns.Add("ResultDate", "Sonuç Tarihi");

            // Sütunların otomatik olarak oluşturulmasını önle
            HastalariGoruntule.AutoGenerateColumns = false;

            // DataGridView'in verileri güncelle
            UpdateDataGridView();

            WelcomeLabel.Text = "Hoşgeldiniz , " + loggedInUser.Username;
        }

        private async void EkleButton_Click(object sender, EventArgs e)
        {
            // Hasta bilgilerini oluştur
            var patientData = new PatientData
            {
                Tc = Hastatc.Text,
                Name = Hastaisim.Text,
                Surname = Hastasoyisim.Text,
                // DateTime türündeki Birth'i UTC olarak ayarla
                Birth = DateTime.SpecifyKind(Hastadogumdatetime.Value, DateTimeKind.Utc),
                Gender = CinsiyetCombobox.SelectedIndex,
                Barcode = Hastabarkodno.Text,
                // DateTime türündeki EntryDate'i UTC olarak ayarla
                EntryDate = DateTime.SpecifyKind(hastagiristarihDatetime.Value, DateTimeKind.Utc),
                // DateTime türündeki AcceptDate'i UTC olarak ayarla
                AcceptDate = DateTime.SpecifyKind(HastaOnayDateTime.Value, DateTimeKind.Utc),
                // DateTime türündeki ResultDate'i UTC olarak ayarla
                ResultDate = DateTime.SpecifyKind(hastasonuctarihidate.Value, DateTimeKind.Utc),
            };

            // Firestore'da doktorun altında "Patients" koleksiyonuna hasta eklemek için referans oluştur
            DocumentReference patientRef = FirestoreHelper.Database
                .Collection("UserData").Document(loggedInUser.Username)
                .Collection("Patients").Document(patientData.Tc);

            try
            {
                // Firestore'a hasta verilerini ekle
                await patientRef.SetAsync(patientData);

                MessageBox.Show("Hasta verisi eklendi.");

                // Hasta eklendikten sonra DataGridView'i güncelle
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        // Erişim belirleyicisi olarak public kullanın
        public async void UpdateDataGridView()
        {
            // Firestore'dan hasta verilerini çek
            var patientsQuery = await FirestoreHelper.Database
                .Collection("UserData").Document(loggedInUser.Username)
                .Collection("Patients").GetSnapshotAsync();

            // DataGridView'i temizle
            HastalariGoruntule.DataSource = null;
            HastalariGoruntule.Rows.Clear();

            // DataGridView'e yeni verileri ekle
            foreach (var patientDocument in patientsQuery.Documents)
            {
                var patientData = patientDocument.ConvertTo<PatientData>();
                HastalariGoruntule.Rows.Add(patientData.Tc, patientData.Name, patientData.Surname, patientData.Birth, patientData.Gender, patientData.Barcode, patientData.EntryDate, patientData.AcceptDate, patientData.ResultDate);
            }
        }

        private async void SilButton_Click(object sender, EventArgs e)
        {
            // DataGridView'de herhangi bir satır seçili mi kontrol et
            if (HastalariGoruntule.SelectedRows.Count > 0)
            {
                // Seçilen satırın indeksini al
                int selectedRowIndex = HastalariGoruntule.SelectedRows[0].Index;

                // Seçilen satırın TC'sini al
                string tcToDelete = Convert.ToString(HastalariGoruntule.Rows[selectedRowIndex].Cells["Tc"].Value);

                // Firestore'dan silinecek belgeyi belirle
                DocumentReference docRefToDelete = FirestoreHelper.Database
                    .Collection("UserData").Document(loggedInUser.Username)
                    .Collection("Patients").Document(tcToDelete);

                try
                {
                    // Firestore'dan belgeyi sil
                    await docRefToDelete.DeleteAsync();

                    // Hasta silindikten sonra DataGridView'i güncelle
                    UpdateDataGridView();

                    MessageBox.Show("Hasta verisi silindi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz hastayı seçin.");
            }
        }
    }
}
