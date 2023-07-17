using Microsoft.AspNetCore.Mvc;
using Student_Admission.Data;
using Student_Admission.Data.ViewModel;
using Student_Admission.Models;
using System.Diagnostics;

namespace Student_Admission.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var StudentList = new VMStudent
            {
                MyList= _db.AdmissionForms.ToList()
            };
           return View(StudentList);
         
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}