using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarBook.Dto.StatisticsDtos;

namespace UCarBook.WebUI.ViewComponents.DashboardComponents
{
    public class _AdminDashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();

            #region GetCarCount
            var carResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetCarCount");
            if (carResponseMessage.IsSuccessStatusCode)
            {
                int carCountRandom = random.Next(0, 101);
                var jsonData = await carResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCount = values.carCount;
                ViewBag.carCountRandom = carCountRandom;
            }
            #endregion

            #region GetLocationCount
            var locationResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetLocationCount");
            if (locationResponseMessage.IsSuccessStatusCode)
            {
                int locationCountRandom = random.Next(0, 101);
                var jsonData = await locationResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.locationCount = values.locationCount;
                ViewBag.locationCountRandom = locationCountRandom;
            }
            #endregion

            #region GetBrandCount
            var brandResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetBrandCount");
            if (brandResponseMessage.IsSuccessStatusCode)
            {
                int brandCountRandom = random.Next(0, 101);
                var jsonData = await brandResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.brandCount = values.brandCount;
                ViewBag.brandCountRandom = brandCountRandom;
            }
            #endregion

            #region GetAvgRentPriceForDaily
            var avgRentPriceForDailyResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetAvgRentPriceForDaily");
            if (avgRentPriceForDailyResponseMessage.IsSuccessStatusCode)
            {
                int avgRentPriceForDailyRandom = random.Next(0, 101);
                var jsonData = await avgRentPriceForDailyResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.avgRentPriceForDaily = values.avgPriceForDaily.ToString("0.00"); ;
                ViewBag.avgRentPriceForDailyRandom = avgRentPriceForDailyRandom;
            }
            #endregion

            return View();
        }
    }
}
