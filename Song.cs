using ProiectPAW.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    [Serializable]
    public class Song
    {
        public Guid Id{ get; set; }
        public String Title{get; set; }
        public String Artist{ get; set; }
        public CategoryNames Category { get; set; }
    }
}
