using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Apartment
    {
        public string TenantName { get; set; }

        public Apartment(string tenantName)
        {
            TenantName = tenantName;
        }
    }

    public class Building : IEnumerable<Apartment>
    {
        private List<Apartment> apartments;

        public Building()
        {
            apartments = new List<Apartment>();
        }

        public void AddApartment(Apartment apartment)
        {
            apartments.Add(apartment);
        }

        public IEnumerator<Apartment> GetEnumerator()
        {
            return apartments.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
