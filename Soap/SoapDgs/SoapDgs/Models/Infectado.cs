using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SoapDgs.Models
{
    [DataContract]
    /// <summary>
    /// Isto abstrai uma pessoa infectada
    /// </summary>
    public class Infectado
    {

        /// <summary>
        /// Id da pessoa infectada
        /// </summary>
        [DataMember]
        public int Idpessoa { get; set; }

        /// <summary>
        /// Primeiro nome da pessoa
        /// </summary>
        [DataMember]
        public string Firstname { get; set; }

        /// <summary>
        /// Último nome da pessoa
        /// </summary>
        [DataMember]
        public string Laststname { get; set; }

        /// <summary>
        /// Id da equipa que detetou o infetado
        /// </summary>
        [DataMember]
        public string Idequipa { get; set; }
    }
}