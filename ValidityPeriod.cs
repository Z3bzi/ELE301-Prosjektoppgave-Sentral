using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.AccessControl;
namespace Sentral
{
    public class ValidityPeriod
    {
        private DateTimeOffset start;
        private DateTimeOffset end;
        private bool alwaysValid;
        
        //1970.1.1 som standardtid hvis ikke annet spesifiseres
        private static DateTime StandardDate = new DateTime(1970, 1, 1);

        public DateTimeOffset Start{  
            get { return start; } 
            set { start = value; }
        }
        public DateTimeOffset End
        {
            get { return end; }
            set { end = value; }
        }
        public bool AlwaysValid
        {
            get { return alwaysValid; }
            set { alwaysValid = value; }
        }

        public ValidityPeriod()
        {
            Start = StandardDate;
            End = StandardDate;
            alwaysValid = true;
        }

        public ValidityPeriod(DateTimeOffset start, DateTimeOffset end,bool alwaysValid)
        {
            this.start = start;
            this.end = end;
            this.alwaysValid = alwaysValid;
        }

        public string Info()
        {
            if (alwaysValid)
            {
                return "Always valid? Ja";
            }
            else
            {
                string msg;
                string s = alwaysValid ? "Ja" : "Nei";
                msg = "start: " + start.ToString() + "\nend: " + end.ToString() + "\nAlways Valid? " + s;
                return msg;
            }
        }
    }
}
