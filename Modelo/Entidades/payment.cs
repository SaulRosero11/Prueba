using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class payment
    {
        public int paymentId { get; set; }
        public float amount { get; set; }
        public DateTime payment_date { get; set; }
        public int customer_Id { get; set; }
        public int rental_Id { get; set; }

        //Relacion con staff
        public staff Staff { get; set; }
        public int staffId { get; set; }
    }
}
