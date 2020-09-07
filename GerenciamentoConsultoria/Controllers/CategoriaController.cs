using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoConsultoria.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Listar()
        {
            return View();
        }
    }
}