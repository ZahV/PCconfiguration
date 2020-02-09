using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PCconfiguration.Models;
using PCconfiguration.View_Models;

namespace PCconfiguration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new PartsViewModel
            {
                CpuCoolings = _context.CpuCoolings.ToList(),
                Cases = _context.Cases.ToList(),
                GraphicsCards = _context.GraphicsCards.ToList(),
                Processors = _context.Processors.ToList(),
                CdDvds = _context.CdDvds.ToList(),
                Coolings = _context.Coolings.ToList(),
                HardDrives = _context.HardDrives.ToList(),
                Motherboards = _context.Motherboards.ToList(),
                OperatingSystems = _context.OperatingSystems.ToList(),
                PowerSupplies = _context.PowerSupplies.ToList(),
                Rams = _context.Rams.ToList(),
                SoundCards = _context.SoundCards.ToList()
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Calculate(BuildPostViewModel viewModel)
        {
            double totalPrice = 0;
            totalPrice += _context.Cases.FirstOrDefault(x => x.Id == viewModel.Cases)?.Price ?? 0;
            totalPrice += _context.CpuCoolings.FirstOrDefault(x => x.Id == viewModel.CpuCoolings)?.Price ?? 0;
            totalPrice += _context.GraphicsCards.FirstOrDefault(x => x.Id == viewModel.GraphicsCards)?.Price ?? 0;
            totalPrice += _context.Processors.FirstOrDefault(x => x.Id == viewModel.Processors)?.Price ?? 0;
            totalPrice += _context.CdDvds.FirstOrDefault(x => x.Id == viewModel.CdDvds)?.Price ?? 0;
            totalPrice += _context.Coolings.FirstOrDefault(x => x.Id == viewModel.Coolings)?.Price ?? 0;
            totalPrice += _context.HardDrives.FirstOrDefault(x => x.Id == viewModel.HardDrives)?.Price ?? 0;
            totalPrice += _context.Motherboards.FirstOrDefault(x => x.Id == viewModel.Motherboards)?.Price ?? 0;
            totalPrice += _context.OperatingSystems.FirstOrDefault(x => x.Id == viewModel.OperatingSystems)?.Price ?? 0;
            totalPrice += _context.PowerSupplies.FirstOrDefault(x => x.Id == viewModel.PowerSupplies)?.Price ?? 0;
            totalPrice += _context.Rams.FirstOrDefault(x => x.Id == viewModel.Rams)?.Price ?? 0;
            totalPrice += _context.SoundCards.FirstOrDefault(x => x.Id == viewModel.SoundCards)?.Price ?? 0;



            return Json(totalPrice);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
