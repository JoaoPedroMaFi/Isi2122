using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDashboardOauth.Models
{
    /// <summary>
    /// Define um objeto user
    /// </summary>
    public class User
    {
        /// <summary>
        /// Nome de utilizador
        /// </summary>
        [Required(ErrorMessage = "UserName is required")]
        public string Username { get; set; }

        /// <summary>
        /// Palavra chave do utilizador
        /// </summary>
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }


        /// <summary>
        /// papel desempenhado pelo utilizador
        /// </summary>
        public bool AdminFlag { get; set; }
    }
}
