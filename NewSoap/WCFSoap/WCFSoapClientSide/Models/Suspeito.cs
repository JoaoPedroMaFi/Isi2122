using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFSoapClientSide.Models
{
    class Suspeito
    {

        /// <summary>
        /// Id da pessoa supostamente infetada
        /// </summary>
        public int Idsuspeito { get; set; }

        /// <summary>
        /// Id da infetado que contaminou este suspeito
        /// </summary>
        public string Idinfectado { get; set; }

        /// <summary>
        /// Primeiro nome da pessoa suspeita
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Último nome da pessoa suspeita
        /// </summary>
        public string Laststname { get; set; }
    }
}
