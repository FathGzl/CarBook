using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
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

            #region GetAuthorCount
            var authorResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetAuthorCount");
            if (authorResponseMessage.IsSuccessStatusCode)
            {
                int authorCountRandom = random.Next(0, 101);
                var jsonData = await authorResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.authorCount = values.authorCount;
                ViewBag.authorCountRandom = authorCountRandom;
            }
            #endregion

            #region GetBlogCount
            var blogResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetBlogCount");
            if (blogResponseMessage.IsSuccessStatusCode)
            {
                int blogCountRandom = random.Next(0, 101);
                var jsonData = await blogResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.blogCount = values.blogCount;
                ViewBag.blogCountRandom = blogCountRandom;
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

            #region GetAvgRentPriceForWeekly
            var avgRentPriceForWeeklyResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetAvgRentPriceForWeekly");
            if (avgRentPriceForWeeklyResponseMessage.IsSuccessStatusCode)
            {
                int avgRentPriceForWeeklyRandom = random.Next(0, 101);
                var jsonData = await avgRentPriceForWeeklyResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.avgRentPriceForWeekly = values.avgRentPriceForWeekl.ToString("0.00");
                ViewBag.avgRentPriceForWeeklyRandom = avgRentPriceForWeeklyRandom;
            }
            #endregion

            #region GetAvgRentPriceForMonthly
            var avgRentPriceForMonthlyResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetAvgRentPriceForMonthly");
            if (avgRentPriceForMonthlyResponseMessage.IsSuccessStatusCode)
            {
                int avgRentPriceForMonthlyRandom = random.Next(0, 101);
                var jsonData = await avgRentPriceForMonthlyResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.avgRentPriceForMonthly = values.avgRentPriceForMonthly.ToString("0.00");
                ViewBag.avgRentPriceForMonthlyRandom = avgRentPriceForMonthlyRandom;
            }
            #endregion


            #region GetCarCountByTranmissionIsAuto
            var carCountByTranmissionIsAutoResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetCarCountByTranmissionIsAuto");
            if (carCountByTranmissionIsAutoResponseMessage.IsSuccessStatusCode)
            {
                int carCountByTranmissionIsAutoRandom = random.Next(0, 101);
                var jsonData = await carCountByTranmissionIsAutoResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCountByTranmissionIsAuto = values.carCountByTranmissionIsAuto;
                ViewBag.carCountByTranmissionIsAutoRandom = carCountByTranmissionIsAutoRandom;
            }
            #endregion

            #region GetBrandNameByMaxCar
            var brandNameByMaxCarResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetBrandNameByMaxCar");
            if (brandNameByMaxCarResponseMessage.IsSuccessStatusCode)
            {
                int brandNameByMaxCarRandom = random.Next(0, 101);
                var jsonData = await brandNameByMaxCarResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.brandNameByMaxCar = values.brandNameByMaxCar;
                ViewBag.brandNameByMaxCarRandom = brandNameByMaxCarRandom;
            }
            #endregion

            #region GetBlogTitleByMaxBlogComment
            var blogTitleByMaxBlogCommentResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetBlogTitleByMaxBlogComment");
            if (blogTitleByMaxBlogCommentResponseMessage.IsSuccessStatusCode)
            {
                int blogTitleByMaxBlogCommentRandom = random.Next(0, 101);
                var jsonData = await blogTitleByMaxBlogCommentResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.blogTitleByMaxBlogComment = values.blogTitleByMaxBlogComment;
                ViewBag.blogTitleByMaxBlogCommentRandom = blogTitleByMaxBlogCommentRandom;
            }
            #endregion

            #region GetCarCountByKmSmallerThen1000
            var carCountByKmSmallerThen1000ResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetCarCountByKmSmallerThen1000");
            if (carCountByKmSmallerThen1000ResponseMessage.IsSuccessStatusCode)
            {
                int carCountByKmSmallerThen1000Random = random.Next(0, 101);
                var jsonData = await carCountByKmSmallerThen1000ResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCountByKmSmallerThen1000 = values.carCountByKmSmallerThen1000;
                ViewBag.carCountByKmSmallerThen1000Random = carCountByKmSmallerThen1000Random;
            }
            #endregion

            #region GetCarCountByFuelGasolineOrDiesel
            var carCountByFuelGasolineOrDieselResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            if (carCountByFuelGasolineOrDieselResponseMessage.IsSuccessStatusCode)
            {
                int carCountByFuelGasolineOrDieselRandom = random.Next(0, 101);
                var jsonData = await carCountByFuelGasolineOrDieselResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCountByFuelGasolineOrDiesel = values.carCountByFuelGasolineOrDiesel;
                ViewBag.carCountByFuelGasolineOrDieselRandom = carCountByFuelGasolineOrDieselRandom;
            }
            #endregion

            #region GetCarCountByFuelElectric
            var carCountByFuelElectricResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetCarCountByFuelElectric");
            if (carCountByFuelElectricResponseMessage.IsSuccessStatusCode)
            {
                int carCountByFuelElectricRandom = random.Next(0, 101);
                var jsonData = await carCountByFuelElectricResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carCountByFuelElectric = values.carCountByFuelElectric;
                ViewBag.carCountByFuelElectricRandom = carCountByFuelElectricRandom;
            }
            #endregion

            #region GetCarBrandAndModelByRentPriceDailyMax
            var carBrandAndModelByRentPriceDailyMaxResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
            if (carBrandAndModelByRentPriceDailyMaxResponseMessage.IsSuccessStatusCode)
            {
                int carBrandAndModelByRentPriceDailyMaxRandom = random.Next(0, 101);
                var jsonData = await carBrandAndModelByRentPriceDailyMaxResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carBrandAndModelByRentPriceDailyMax = values.carBrandAndModelByRentPriceDailyMax;
                ViewBag.carBrandAndModelByRentPriceDailyMaxRandom = carBrandAndModelByRentPriceDailyMaxRandom;
            }
            #endregion

            #region GetCarBrandAndModelByRentPriceDailyMin
            var carBrandAndModelByRentPriceDailyMinResponseMessage = await client.GetAsync("https://localhost:7049/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
            if (carBrandAndModelByRentPriceDailyMinResponseMessage.IsSuccessStatusCode)
            {
                int carBrandAndModelByRentPriceDailyMinRandom = random.Next(0, 101);
                var jsonData = await carBrandAndModelByRentPriceDailyMinResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.carBrandAndModelByRentPriceDailyMin = values.carBrandAndModelByRentPriceDailyMin;
                ViewBag.carBrandAndModelByRentPriceDailyMinRandom = carBrandAndModelByRentPriceDailyMinRandom;
            }
            #endregion

            return View();
        }
    }
}
