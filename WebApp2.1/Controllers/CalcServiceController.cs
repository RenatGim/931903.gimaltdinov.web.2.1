using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp2._1.Models;


namespace WebApp2._1.Controllers
{
    public class CalcServiceController : Controller
    {
        
        private Random _random { get; set; } = new Random();
        public int x { get; set; }
        public int y { get; set; }
        public string add { get; set; }
        public string sub { get; set; }
        public string mult { get; set; }
        public string div { get; set; }
        private ILogger<CalcServiceController> _logger { get; set; }

        public CalcServiceController(ILogger<CalcServiceController> logger)
        {
            _logger = logger;

            x = _random.Next() % 11;
            y = _random.Next() % 11;
            add = $"{x} + {y} = {x + y}";
            sub = $"{x} - {y} = {x - y}";
            mult = $"{x} * {y} = {x * y}";
            div = y == 0 ? "Error: division by zero" : $"{x} /  {y} = {x / y}";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PassUsingModel()
        {
            var viewModel = new CalculatorViewModel(x, y, add, sub, mult, div);
            return View(viewModel);
        }

        public IActionResult PassUsingViewData()
        {
            ViewData["X"] = x;
            ViewData["Y"] = y;
            ViewData["Add"] = add;
            ViewData["Sub"] = sub;
            ViewData["Mult"] = mult;
            ViewData["Div"] = div;
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            ViewBag.X = x;
            ViewBag.Y = y;
            ViewBag.Add = add;
            ViewBag.Sub = sub;
            ViewBag.Mult = mult;
            ViewBag.Div = div;
            return View();
        }
        public IActionResult AccessServiceDirectly()
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
