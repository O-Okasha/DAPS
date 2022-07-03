using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHX.models
{
    public class Shelf
    {
        public Shelf (string Name, string NumericNo, string total)
        {
            name = Name ?? throw new ArgumentNullException(nameof(Name));
            numericno = NumericNo ?? throw new ArgumentNullException(nameof(NumericNo));
            Total = total ?? throw new ArgumentNullException(nameof(total));
        }
        public string name { get; set; }
        public string numericno { get; set; }
        public string Total { get; set; }
    }
}
