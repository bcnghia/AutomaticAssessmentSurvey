using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticAssessmentSurvey
{
    class Account
    {
        public string User { get; set; }
        public string Password { get; set; }

        public string GioiTinh { get; set; }

        //public Account() { }
        public Account(string user, string password, string gioiTinh) {  User = user; Password = password; GioiTinh = gioiTinh; }

        public string Info()
        {
            return $"{User};{Password};{GioiTinh}";
        }
    }
}
