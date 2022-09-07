using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_Exercises
{
    public class Laptop : Computer
    {
        public int ScreenSize { get; set; }

        public Laptop(int screenSize, bool browser, double ram, int fans) : base(browser, ram, fans)
        {
            ScreenSize = screenSize;
        }

        public void NewScreen(int newScreen)
        {
            ScreenSize = newScreen;
        }
    }
}
