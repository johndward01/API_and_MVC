using API_and_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_and_MVC.Controllers;
public class KanyeController : Controller
{
    public IActionResult Index()
    {
        var client = new HttpClient();
        var url = "https://api.kanye.rest/";
        var response = client.GetStringAsync(url).Result;
        var root = JsonConvert.DeserializeObject<Root>(response);
        return View(root);
    }
}
