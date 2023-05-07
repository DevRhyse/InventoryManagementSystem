using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using inventoryMS.Models;
using inventoryMS.Data;

namespace inventoryMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController>? _logger;

        private readonly ApplicationDbContext? _dbContext;

        public HomeController(ApplicationDbContext dbContext, ILogger<HomeController> logger)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        public IActionResult Index()
        {
            List<InventoryItem> items = new List<InventoryItem>();
            if (_dbContext != null && _dbContext.InventoryItems != null)
            {
                items = _dbContext.InventoryItems.ToList();
            }
            return View(items);
        }

    
        [HttpPost]
public IActionResult Insert(InventoryItem item)
{
    if (_dbContext == null)
    {
        throw new InvalidOperationException("dbContext is null.");
    }

    if (_dbContext?.InventoryItems != null)
    {
        _dbContext.InventoryItems.Add(item);
    }

    _dbContext.SaveChanges();

    if (ModelState?.IsValid == true)
    {
        return RedirectToAction("Index");
    }

    return View(item);
}




    }
}


// using System.Diagnostics;
// using Microsoft.AspNetCore.Mvc;
// using inventoryMS.Models;
// using inventoryMS.Data;

// namespace inventoryMS.Controllers;

// public class HomeController : Controller
// {
//     private readonly ILogger<HomeController>? _logger;

//     private readonly ApplicationDbContext? _dbContext;

//     public HomeController(ApplicationDbContext dbContext, ILogger<HomeController> logger)
//     {
//         _dbContext = dbContext;
//         _logger = logger;
//     }


//     public IActionResult Index()
//     {
//         List<InventoryItem> items = _dbContext.InventoryItems?.ToList() ?? new List<InventoryItem>();
//         return View();
//     }
    
//     [HttpPost]
// public IActionResult Insert(InventoryItem item)
// {
//     if (_dbContext != null)
//     {
//         _dbContext.InventoryItems.Add(item);
//         _dbContext.SaveChanges();
//     }
//     if (ModelState.IsValid)
//     {
//         _dbContext.InventoryItems.Add(item);
//         _dbContext.SaveChanges();
//         return RedirectToAction("Index");
//     }
//     return View(item);
// }

// }