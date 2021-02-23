using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagement_Countries.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public string Greeting { get; set; }
        public string Description { get; set; }
        public string[] Colors { get; set; }

    }
}
