//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFSoap.DatabaseEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class infetado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public infetado()
        {
            this.suspeitoes = new HashSet<suspeito>();
        }
    
        public int idinfetado { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int idequipa { get; set; }
    
        public virtual equipa equipa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<suspeito> suspeitoes { get; set; }
    }
}