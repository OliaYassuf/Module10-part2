using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("||||||||||||||||1||||||||||||||||");
            Alphabet alphabet = new Alphabet();

            foreach (char letter in alphabet)
            {
                Console.Write(letter + " ");
            }

            Console.WriteLine("\n\n||||||||||||||||2||||||||||||||||");

            Building building = new Building();

            building.AddApartment(new Apartment("Olia"));
            building.AddApartment(new Apartment("Olena"));
            building.AddApartment(new Apartment("Darion"));

            Console.WriteLine("Tenants in the building:");
            foreach (Apartment apartment in building)
            {
                Console.WriteLine(apartment.TenantName);
            }

            Console.WriteLine("\nTenants in each apartment:");
            foreach (Apartment apartment in building)
            {
                Console.WriteLine($"Tenant in the apartment: {apartment.TenantName}");
            }
            Console.WriteLine("\n||||||||||||||||3||||||||||||||||");

            Garage garage = new Garage();

            garage.AddCar(new Car("Civic", "Honda"));
            garage.AddCar(new Car("Corolla", "Toyota"));
            garage.AddCar(new Car("Accord", "Honda"));

            Console.WriteLine("Cars in the garage:");
            foreach (Car car in garage)
            {
                Console.WriteLine($"Manufacturer: {car.Manufacturer}, Model: {car.Model}");
            }

        }
    }
}
