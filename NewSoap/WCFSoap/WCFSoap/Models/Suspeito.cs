using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFSoap.Models
{

    /// <summary>
    /// Isto abstrai um suspeito de estar contaminado com covid
    /// </summary>
    [DataContract]
    public class Suspeito
    {

        /// <summary>
        /// Id da pessoa supostamente infetada
        /// </summary>
        [DataMember]
        public int Idsuspeito { get; set; }

        /// <summary>
        /// Id da infetado que contaminou este suspeito
        /// </summary>
        [DataMember]
        public string Idinfectado { get; set; }

        /// <summary>
        /// Primeiro nome da pessoa suspeita
        /// </summary>
        [DataMember]
        public string Firstname { get; set; }

        /// <summary>
        /// Último nome da pessoa suspeita
        /// </summary>
        [DataMember]
        public string Laststname { get; set; }

    }
}