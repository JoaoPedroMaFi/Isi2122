//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapDgs.DatabaseEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class suspeito
    {
        public int idsuspeito { get; set; }
        public int idinfetado { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    
        public virtual infetado infetado { get; set; }
    }
}