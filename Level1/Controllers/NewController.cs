using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level1.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            //Add XML as Input and Output Formatter.

         //   Enable logging through one of these methods –
         //Adding through pipeline and through providers.


            return View();
        }
    }
}