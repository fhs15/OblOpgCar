using Cars;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarTestModel()
        {
            Car car = new Car();

            car.Model = "Mustang";
            Assert.AreEqual("Mustang", car.Model);

            Assert.ThrowsException<ArgumentNullException>((() => car.Model = null));
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => car.Model = "Ab"));
        }

        [TestMethod()]
        public void CarTestPrice()
        {
            Car car = new Car();

            car.Price = 100;
            Assert.AreEqual(100, car.Price);

            car.Price = 1;
            Assert.AreEqual(1, car.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => car.Price = 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => car.Price = -1));
        }

        [TestMethod()]
        public void CarTestLicensePlate()
        {
            Car car = new Car();

            car.LicensePlate = "AB9432";
            Assert.AreEqual("AB9432", car.LicensePlate);


            car.LicensePlate = "12";
            Assert.AreEqual("12", car.LicensePlate);
            car.LicensePlate = "1234567";
            Assert.AreEqual("1234567", car.LicensePlate);
            Assert.ThrowsException<ArgumentNullException>((() => car.LicensePlate = null));
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => car.LicensePlate = "A"));
            Assert.ThrowsException<ArgumentOutOfRangeException>((() => car.LicensePlate = "12345678"));
        }

        [TestMethod()]
        public void CarTestConstructor()
        {
            Car car = new Car(1, "Mustang", 100, "AB94");

            Assert.AreEqual(1, car.Id);
            Assert.AreEqual("Mustang", car.Model);
            Assert.AreEqual(100, car.Price);
            Assert.AreEqual("AB94", car.LicensePlate);

            Assert.ThrowsException<ArgumentNullException>(() => new Car(1, null, 100, "AB94"));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Car(1, "123", 100, "AB94"));

            Assert.ThrowsException<ArgumentNullException>(() => new Car(1, "Mustang", 100, null));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Car(1, "Mustang", 100, "1"));

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Car(1, "Mustang", 0, "123"));
        }
    }
}