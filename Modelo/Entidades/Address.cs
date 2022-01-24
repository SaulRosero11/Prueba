using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Address
    {
        public int addressId { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string distric { get; set; }
        public int city_id { get; set; }
        public string postal_code { get; set; }
        public string phone { get; set; }
        public DateTime last_update { get; set; }

        //relaicon con Staff
        public ICollection<staff> Staffs { get; set; }
    }
}
