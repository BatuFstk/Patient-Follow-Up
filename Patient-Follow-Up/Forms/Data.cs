using Google.Cloud.Firestore;
using System;


namespace Patient_Follow_Up.Forms
{
    [FirestoreData]
    internal class PatientData
    {
        [FirestoreProperty]
        public string Tc { get; set; }
        [FirestoreProperty]

        public string Name { get; set; }
        [FirestoreProperty]

        public string Surname { get; set; }
        [FirestoreProperty]

        public DateTime Birth { get; set; }
        [FirestoreProperty]

        public int Gender { get; set; }
        [FirestoreProperty]

        public string Barcode { get; set; }
        [FirestoreProperty]

        public DateTime EntryDate { get; set; }
        [FirestoreProperty]

        public DateTime AcceptDate { get; set; }
        [FirestoreProperty]

        public DateTime ResultDate { get; set; }
    }
}