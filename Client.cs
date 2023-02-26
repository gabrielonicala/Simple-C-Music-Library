using ProiectPAW.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Client
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public CategoryNames Preference{ get; set;}
    }
}
