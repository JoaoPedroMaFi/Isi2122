using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApiANEPC.Controllers
{
    [Route("api/[controller]/equipas")]
    [ApiController]
    public class EquipaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
