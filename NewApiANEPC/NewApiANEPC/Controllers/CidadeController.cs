using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApiANEPC.Controllers
{
    [Route("api/[controller]/cidades")]
    [ApiController]
    public class CidadeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
