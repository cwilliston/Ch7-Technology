using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_Exercises
{
    public class SmartPhone : Computer
    {
        public string MostUsedApp { get; set; }
        public double MostUsedAppHrs { get; set; }

        public SmartPhone(bool browser, double ram, int fans) : base(browser, ram, fans) { }

        public void UpdateAppHrs (double hours)
        {
            MostUsedAppHrs += hours;
        }

        public void SetMostUsedApp (string app)
        {
            MostUsedApp = app;
            MostUsedAppHrs = 0;
        }

    }
}
