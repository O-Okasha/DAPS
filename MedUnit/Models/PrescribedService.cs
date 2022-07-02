using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedUnit.Models
{
    public class PrescribedService : Service
    {
        public PrescribedService(int quantity, Service service) : base(service)
        {
            Quantity = quantity;
            Total = quantity * price;
        }

        public int Quantity { get; set; }
        public int Total { get; }
    }
}
