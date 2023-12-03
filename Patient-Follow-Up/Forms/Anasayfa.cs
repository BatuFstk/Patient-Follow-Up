using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Patient_Follow_Up.Forms
{
    public partial class Anasayfa : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {

            AuthSecret = "HseqrY2zHaVDFR1qajbo0p9vHf9x197mMO42jRel",
            BasePath= "https://patient-followup-5a2b9-default-rtdb.firebaseio.com/"


        };

        IFirebaseClient client;


        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Hastatc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Veritabanına Bağlantı Gerçekleştiriliyor..");
                MessageBox.Show("Veritabanına Bağlanıldı.Kullanıma Hazır!");

            }
        }
    }
}
