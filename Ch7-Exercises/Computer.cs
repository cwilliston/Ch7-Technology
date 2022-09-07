using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_Exercises
{
    public class Computer : AbstractEntity
    {
        public readonly bool HasWebBrowser = true;

        public double RAM { get; set; }
        public int NumberOfFans { get; set; }

        public Computer(bool browserStatus, double ram, int fans)
        {
            HasWebBrowser = browserStatus;
            RAM = ram;
            NumberOfFans = fans;
        }

        public void AddFans(int newFans)
        {
            NumberOfFans += newFans;
        }

        public void FanBroke()
        {
            NumberOfFans--;
        }

    }
}
