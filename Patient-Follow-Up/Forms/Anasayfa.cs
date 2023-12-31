﻿using FireSharp.Response;
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

            
            this.loggedInUser = loggedInUser;

           

           
            HastalariGoruntule.Columns.Add("Tc", "TC");
            HastalariGoruntule.Columns.Add("Name", "İsim");
            HastalariGoruntule.Columns.Add("Surname", "Soyisim");
            HastalariGoruntule.Columns.Add("Birth", "Doğum Tarihi");
            HastalariGoruntule.Columns.Add("Gender", "Cinsiyet");
            HastalariGoruntule.Columns.Add("Barcode", "Barkod");
            HastalariGoruntule.Columns.Add("EntryDate", "Giriş Tarihi");
            HastalariGoruntule.Columns.Add("AcceptDate", "Onay Tarihi");
            HastalariGoruntule.Columns.Add("ResultDate", "Sonuç Tarihi");

            
            HastalariGoruntule.AutoGenerateColumns = false;

            
            UpdateDataGridView();

            WelcomeLabel.Text = "Hoşgeldiniz , Sayın Dr. " + loggedInUser.DoktorName +" "+ loggedInUser.DoktorSurname;
        }

        private async void EkleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Hastatc.Text) || string.IsNullOrEmpty(Hastaisim.Text) || string.IsNullOrEmpty(Hastasoyisim.Text) || CinsiyetCombobox.SelectedIndex == -1 || string.IsNullOrEmpty(Hastabarkodno.Text))
            {
                MessageBox.Show("TC Kimlik No, İsim, Soyisim, Cinsiyet ve Barkod alanları eksiksiz doldurulmalıdır!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (Hastatc.Text.Length != 11)
            {
                MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır.", "Geçersiz TC Kimlik No!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            
            var patientData = new PatientData
            {
                Tc = Hastatc.Text,
                Name = Hastaisim.Text,
                Surname = Hastasoyisim.Text,
                
                Birth = DateTime.SpecifyKind(Hastadogumdatetime.Value, DateTimeKind.Utc),
                Gender = CinsiyetCombobox.SelectedIndex,
                Barcode = Hastabarkodno.Text,
                
                EntryDate = DateTime.SpecifyKind(hastagiristarihDatetime.Value, DateTimeKind.Utc),
                
                AcceptDate = DateTime.SpecifyKind(HastaOnayDateTime.Value, DateTimeKind.Utc),
                
                ResultDate = DateTime.SpecifyKind(hastasonuctarihidate.Value, DateTimeKind.Utc),
            };

            
            DocumentReference patientRef = FirestoreHelper.Database
                .Collection("UserData").Document(loggedInUser.Username)
                .Collection("Patients").Document(patientData.Tc);

            try
            {
               
                await patientRef.SetAsync(patientData);

                MessageBox.Show("Hasta verisi eklendi.");

               
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        
        public async void UpdateDataGridView()
        {
            
            var patientsQuery = await FirestoreHelper.Database
                .Collection("UserData").Document(loggedInUser.Username)
                .Collection("Patients").GetSnapshotAsync();

            
            HastalariGoruntule.DataSource = null;
            HastalariGoruntule.Rows.Clear();

            
            foreach (var patientDocument in patientsQuery.Documents)
            {
                var patientData = patientDocument.ConvertTo<PatientData>();
                HastalariGoruntule.Rows.Add(patientData.Tc, patientData.Name, patientData.Surname, patientData.Birth, patientData.Gender, patientData.Barcode, patientData.EntryDate, patientData.AcceptDate, patientData.ResultDate);
            }
        }

        private async void SilButton_Click(object sender, EventArgs e)
        {
            
            if (HastalariGoruntule.SelectedRows.Count > 0)
            {
                
                int selectedRowIndex = HastalariGoruntule.SelectedRows[0].Index;

                
                string tcToDelete = Convert.ToString(HastalariGoruntule.Rows[selectedRowIndex].Cells["Tc"].Value);

                
                DocumentReference docRefToDelete = FirestoreHelper.Database
                    .Collection("UserData").Document(loggedInUser.Username)
                    .Collection("Patients").Document(tcToDelete);

                try
                {
                   
                    await docRefToDelete.DeleteAsync();

                    
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

        private async void AllDeleteButton_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Tüm hasta verilerini silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                
                CollectionReference patientsCollection = FirestoreHelper.Database
                    .Collection("UserData").Document(loggedInUser.Username)
                    .Collection("Patients");

                try
                {
                    
                    var patientsQuery = await patientsCollection.GetSnapshotAsync();

                    
                    if (patientsQuery.Count > 0)
                    {
                        
                        foreach (var patientDocument in patientsQuery.Documents)
                        {
                            await patientDocument.Reference.DeleteAsync();
                        }

                       
                        UpdateDataGridView();

                        MessageBox.Show("Tüm hasta verileri silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Silinecek hasta verisi bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
