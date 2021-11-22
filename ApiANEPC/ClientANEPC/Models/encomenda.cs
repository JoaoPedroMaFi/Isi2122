using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientANEPC.Models
{
    public partial class encomenda
    {
        public int idencomenda { get; set; }
        public int idequipa { get; set; }
        public sbyte entregue { get; set; }

        public virtual equipa equipa { get; set; }
    }
}
