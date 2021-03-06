using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImporter.Models
{
    //https://developercommunity.visualstudio.com/t/vs-2019-rc-cant-create-winforms-net-framework-or-n/716953


    public class Isolado
    {
        /// <summary>
        /// Date of the inspection
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// id of the inspectioned, infected person
        /// </summary>
        public int UtentNumber { get; set; }

        /// <summary>
        /// id of the team inspecting that person
        /// </summary>
        public int Idequipa { get; set; }

        /// <summary>
        /// first name of the inspectioned person
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// last name of the inspectioned person
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// boolean dictating if the person was isolating or not
        /// true for yes, false for no
        /// </summary>
        public bool Respeitou { get; set; }
    }
}
