using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Action
    {
        public Action(string date, string id, string description)
        {
            Date = date ?? throw new ArgumentNullException(nameof(date));
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        public string Date { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }

    }
}
