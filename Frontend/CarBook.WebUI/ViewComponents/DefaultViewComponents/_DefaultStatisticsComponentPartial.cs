using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace CarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();


            #region GetCarCount
            var carResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetCarCount");
            if (carResponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await carResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCount = values.carCount;
            }
            #endregion

            #region GetLocationCount
            var locationResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetLocationCount");
            if (locationResponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await locationResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.locationCount = values.locationCount;
            }
            #endregion

            #region GetBrandCount
            var brandResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetBrandCount");
            if (brandResponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await brandResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.brandCount = values.brandCount;
            }
            #endregion

            #region GetCarCountByFuelElectric
            var carCountByFuelElectricResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetCarCountByFuelElectric");
            if (carCountByFuelElectricResponseMessage.IsSuccessStatusCode)
            {
                var jsonData = await carCountByFuelElectricResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCountByFuelElectric = values.carCountByFuelElectric;
            }
            #endregion

            return View();
        }
    }
}
