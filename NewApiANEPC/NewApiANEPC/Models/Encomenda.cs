using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApiANEPC.Models
{
    public class Encomenda
    {
        public int IdEncomenda { get; set; }

        public int IdEquipa { get; set; }

        public bool Entregue { get; set; }
    }
}
