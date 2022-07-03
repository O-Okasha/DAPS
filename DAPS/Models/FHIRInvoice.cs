using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAPS.Models
{
    public class FHIRInvoice
    {
        public string resourceType = "Invoice";
        public string statue = "issued";
        public string id { get; set; }
        public string date { get; set; }
        public Dictionary<string, string> TotalNet { get; set; }
    }
}
