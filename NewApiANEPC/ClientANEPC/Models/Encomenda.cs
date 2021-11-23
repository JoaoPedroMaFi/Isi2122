using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientANEPC.Models
{
    public class Encomenda
    {
        public int IdEncomenda { get; set; }

        public int IdEquipa { get; set; }

        public bool Entregue { get; set; }
    }
}
