﻿using CarBook.Dto.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsMainComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailsMainComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7049/api/Blogs/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBlogByIdDto>>(jsonData);
                return View(values);
            }


            var responseMessage2 = await client.GetAsync($"https://localhost:7049/api/Comments/GetCommentsCountByBlog?id=" + id);
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBlogByIdDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
