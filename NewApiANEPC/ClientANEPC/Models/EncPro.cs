using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientANEPC.Models
{
    public class EncPro
    {
        public int IdEncPro { get; set; }

        public int IdProduto { get; set; }

        public int IdEncomenda { get; set; }

        public int QuantidadeProduto { get; set; }
    }
}
