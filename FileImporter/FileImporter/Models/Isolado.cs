using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImporter.Models
{
    public class Isolado
    {
        /// <summary>
        /// id of the inspectioned, infected person
        /// </summary>
        public int idisolado { get; set; }

        /// <summary>
        /// id of the team inspecting that person
        /// </summary>
        public int idequipa { get; set; }

        /// <summary>
        /// first name of the inspectioned person
        /// </summary>
        public string firstname { get; set; }

        /// <summary>
        /// last name of the inspectioned person
        /// </summary>
        public string lastname { get; set; }

        /// <summary>
        /// Date of the inspection
        /// </summary>
        public string data { get; set; }

        /// <summary>
        /// boolean dictating if the person was isolating or not
        /// true for yes, false for no
        /// </summary>
        public bool respeitou { get; set; }


    }
}
