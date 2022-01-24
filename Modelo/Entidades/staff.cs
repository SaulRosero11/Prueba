using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class staff
    {
        public int staffId { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int store_id { get; set; }
        public Boolean active { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime last_update { get; set; }
        public string picture { get; set; }

        //Relacion entre staff y Address
        public Address address { get; set; }
        public int addressId { get; set; }

        //relaicon con payment
        public ICollection<payment> Payments { get; set; }
    }
}
