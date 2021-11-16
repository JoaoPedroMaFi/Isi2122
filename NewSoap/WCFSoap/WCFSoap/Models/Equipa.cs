using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFSoap.Models
{
    [DataContract]
    /// <summary>
    /// Isto abstrai uma equipa
    /// </summary>
    public class Equipa
    {
        /// <summary>
        /// Id de uma equipa
        /// </summary>
        [DataMember]
        public int Idequipa { get; set; }

        /// <summary>
        /// Nome da equipa
        /// </summary>
        [DataMember]
        public string Nome { get; set; }
    }

}