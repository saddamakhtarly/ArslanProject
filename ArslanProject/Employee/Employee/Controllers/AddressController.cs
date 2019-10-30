using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Employee.Models.Address;

namespace Employee.Controllers
{
    public class AddressController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            AddressHandler addressHandler = new AddressHandler();
          List<Neighborhood> neighborhoods=   addressHandler.GetAllNeighborhood().ToList();

            return View(neighborhoods);
        }
    }
}