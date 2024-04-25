using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Car
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }

        public Car(string model, string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;
        }
    }

    public class Garage : IEnumerable<Car>
    {
        private List<Car> cars;

        public Garage()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
