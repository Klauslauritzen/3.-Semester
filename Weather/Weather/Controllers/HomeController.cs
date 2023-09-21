using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Weather.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using static Weather.Models.WeatherForecast;

namespace Weather.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();

            // Hent data fra API'en
            HttpResponseMessage response = await client.GetAsync("https://api.openweathermap.org/data/2.5/weather?q=Copenhagen,DK&APPID=8c0a0d78c00b2b172f75a2f2b685a950");

            
                // Læs JSON-responsen som tekst
                string responseBody = await response.Content.ReadAsStringAsync();

                // Deserialisér JSON-data til din modelklasse
                WeatherForecast.Root weatherForecast = JsonSerializer.Deserialize<WeatherForecast.Root>(responseBody);

                // Nu har du adgang til dataene i weatherForecast-objektet
                Console.WriteLine(weatherForecast.ToString());

                // Send modeldata til visningen
                return View(weatherForecast);
          
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