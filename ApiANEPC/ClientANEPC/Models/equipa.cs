using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientANEPC.Models
{
    public partial class equipa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public equipa()
        {
            this.encomendas = new HashSet<encomenda>();
        }

        public int idequipa { get; set; }
        public int idcidade { get; set; }
        public string equipa_nome { get; set; }

        public virtual cidade cidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<encomenda> encomendas { get; set; }
    }
}
