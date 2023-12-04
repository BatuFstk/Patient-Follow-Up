using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Follow_Up.Class
{

    [FirestoreData]
    public  class UserData
    {
        [FirestoreProperty]
        public string Username { get; set; }
        [FirestoreProperty]
        public string Password { get; set; }
        [FirestoreProperty]
        public string DoktorName { get; set; }
        [FirestoreProperty]
        public string DoktorSurname { get; set; }

        


    }
}
