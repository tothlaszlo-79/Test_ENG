using Microsoft.AspNetCore.Mvc;
using Test_ENG.Data;

namespace Test_ENG.Controllers
{
    public class ReportController : Controller
    {
        private readonly TestDbContext _context;

        public ReportController(TestDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var reportData = from p in _context.Products
                             join c in _context.Categories on p.CategoryId equals c.CategoryId
                             select new Models.ReportProduct
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 Price = p.Price,
                                 Description = p.Description,
                                 CategoryName = c.CategoryName
                             };


            return View(reportData.ToList());
        }
    }
}
