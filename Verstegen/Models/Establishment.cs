using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Verstegen.Models
{
    public class Establishment
    {
        public int EstablishmentId { get; set; }

        public string Name { get; set; }

        public string Adres { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string VATNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Longitude { get; set; }

        public string Latitude { get; set; }
    }
}
