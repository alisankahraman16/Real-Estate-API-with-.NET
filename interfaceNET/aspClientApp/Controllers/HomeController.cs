using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aspClientApp.Models;
using System.Text.Json;

namespace aspClientApp.Controllers;

public class HomeController : Controller
{
    

    public async Task<IActionResult> Index()
    {
        var states = new List<StateDTO>();

        using(var httpClient = new HttpClient())
        {
            using(var response = await httpClient.GetAsync("http://localhost:5160/api/states"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                states = JsonSerializer.Deserialize<List<StateDTO>>(apiResponse);
            }
        }

        return View(states);
    }

   
}
