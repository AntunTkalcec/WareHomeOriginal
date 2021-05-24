using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHome_Logic
{
    public class MailDanCombine
    {
        public string Email { get; set; }
        public string DanOdlaska { get; set; }
        public string SatOdlaska { get; set; }
        public string MinutaOdlaska { get; set; }
        public MailDanCombine(string email, string danOdlaska, string satOdlaska, string minutaOdlaska)
        {
            Email = email;
            DanOdlaska = danOdlaska;
            SatOdlaska = satOdlaska;
            MinutaOdlaska = minutaOdlaska;
        }
    }
}
