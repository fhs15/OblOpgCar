using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        private string _model;
        private int _price;
        private string _licensePlate;
        public int Id { get; set; }

        public string Model
        {
            get => _model;
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (value.Length < 4) throw new ArgumentOutOfRangeException();
                _model = value;
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }

        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (value.Length < 2 || value.Length > 7) throw new ArgumentOutOfRangeException();
                _licensePlate = value;
            }
        }

        public Car()
        {

        }

        public Car(int id, string model, int price, string licensePlate)
        {
            Id = id;
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
        }
    }
}
