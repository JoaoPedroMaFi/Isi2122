using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientANEPC.Models
{
    public partial class cidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cidade()
        {
            this.equipas = new HashSet<equipa>();
        }

        public int idcidade { get; set; }
        public string cidade_nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<equipa> equipas { get; set; }
    }
}
