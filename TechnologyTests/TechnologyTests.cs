using Ch7_Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyTests
{
    [TestClass]
    public class TechnologyTests
    {
        [TestMethod]
        public void LaptopConstructorWorks()
        {
            Laptop myLaptop = new Laptop(17, true, 16, 2);

            Assert.AreEqual(myLaptop.ScreenSize, 17, .001);
            Assert.IsTrue(myLaptop.HasWebBrowser);
            Assert.AreEqual(myLaptop.RAM, 16, .001);
            Assert.AreEqual(myLaptop.NumberOfFans, 2, .001);

        }

        [TestMethod]
        public void SmartPhoneAppUpdaterWorks()
        {
            SmartPhone myPhone = new SmartPhone(true, 8, 0);
            myPhone.SetMostUsedApp("Facebook");
            myPhone.UpdateAppHrs(11);

            Assert.IsTrue(myPhone.MostUsedApp == "Facebook");
            Assert.AreEqual(myPhone.MostUsedAppHrs, 11, .001);

        }

        [TestMethod]
        public void AddFansMethodWorks()
        {
            Computer testComputer = new Computer(true, 32, 4);
            testComputer.AddFans(2);

            Assert.AreEqual(testComputer.NumberOfFans, 6, .001);
        }

        [TestMethod]
        public void ComputerInheritsId()
        {
            Computer testComputer = new Computer(true, 32, 4);
            Assert.AreEqual(testComputer.Id, 1, .001);

            Computer testComputer2 = new Computer(true, 16, 5);
            Assert.AreEqual(testComputer2.Id, 2, .001);
        }

        [TestMethod]
        public void SmartPhoneInheritsId()
        {
            SmartPhone testPhone = new SmartPhone(true, 8, 0);
            Assert.AreEqual(testPhone.Id, 1, .001);

            SmartPhone testPhone2 = new SmartPhone(true, 16, 1);
            Assert.AreEqual(testPhone2.Id, 2, .001);
        }

    }
}
