using Microsoft.AspNetCore.Mvc;

namespace HealthApplication.Controllers
{
public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}