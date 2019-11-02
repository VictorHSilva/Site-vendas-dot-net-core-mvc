using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiteVendas.Models;

namespace SiteVendas.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {

            List<Departamento> list = new List<Departamento>();

            list.Add(new Departamento { Id = 1, Nome = "Eletronicos" });
            return View(list);
        }
    }
}