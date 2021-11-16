using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFSoapClientSide.Models
{
    class Infectado
    {
        /// <summary>
        /// Id da pessoa infectada
        /// </summary>
        public int Idpessoa { get; set; }

        /// <summary>
        /// Primeiro nome da pessoa
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Último nome da pessoa
        /// </summary>
        public string Laststname { get; set; }

        /// <summary>
        /// Id da equipa que detetou o infetado
        /// </summary>
        public int Idequipa { get; set; }
    }
}
