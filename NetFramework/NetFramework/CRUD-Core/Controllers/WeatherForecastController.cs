using Microsoft.AspNetCore.Mvc;

namespace CRUD_Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<WeatherForecast> forecasts = new List<WeatherForecast>()
        {
            new WeatherForecast
            {   Id = 1,
                Date = DateTime.Now,
                Summary = "Cold",
                TemperatureC = 15
            },
             new WeatherForecast
            {   Id=2,
                Date = DateTime.Now,
                Summary = "Hot",
                TemperatureC = 16
            }

        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public List<WeatherForecast> Get()
        {

            return forecasts;
        }

        [HttpPost(Name = "PostWeatherForecast")]
        public HttpResponseMessage Post(WeatherForecast forecast)
        {
            forecast.Id = forecasts.Any() ? forecasts.Select(k => k.Id).Max() + 1 : 1;
            forecasts.Add(forecast);
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            return httpResponseMessage;
        }

        [HttpDelete(Name = "DeleteWeatherForecast")]
        public HttpResponseMessage Delete(long id)
        {
            WeatherForecast forecast = forecasts.FirstOrDefault(k => k.Id == id);

            HttpResponseMessage httpResponseMessage;

           if (forecast !=null)
            {
                forecasts.Remove(forecast);
                httpResponseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
            else
            {

                 httpResponseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
            }
           
            return httpResponseMessage;
        }

        [HttpPut(Name = "PutWeatherForecast")]
        public HttpResponseMessage Put(long Id, WeatherForecast forecast)
        {
            HttpResponseMessage responseMessage;
            var savedForecast = forecasts.FirstOrDefault(k => k.Id == Id);
            if (savedForecast != null) {

                savedForecast.Summary = forecast.Summary;
                savedForecast.TemperatureC = forecast.TemperatureC;
                savedForecast.Date = forecast.Date;
                responseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.OK);

            }
            else
            {
                responseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
            }

            return responseMessage;
        }
    }
}