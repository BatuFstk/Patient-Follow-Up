using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Follow_Up.Class
{
    internal static class SessionManager
    {
        private static string loggedInDoctorUsername;

        public static void SetLoggedInDoctor(string username)
        {
            loggedInDoctorUsername = username;
        }

        public static string GetLoggedInDoctor()
        {
            return loggedInDoctorUsername;
        }
    }
}
