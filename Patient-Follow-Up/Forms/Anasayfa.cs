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
                .Collection("Patients").Document();



            // Firestore'a hasta verilerini ekle
            

            try
            {
                // Firestore'a hasta verilerini ekle
                await patientRef.SetAsync(patientData);

                MessageBox.Show("Hasta verisi eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
