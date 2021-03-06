﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClientConvertisseurV1.Service
{
    class WSService
    {
        static HttpClient httpClient = new HttpClient();
        public WSService() {
            httpClient.BaseAddress = new Uri("http://localhost:1864/api/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<List<Model.Devise>> getAllDevisesAsync()
        {
            List<Model.Devise> devises = new List<Model.Devise>();
            HttpResponseMessage response = await httpClient.GetAsync("Devise");
            if (response.IsSuccessStatusCode)
            {
                devises = await response.Content.ReadAsAsync<List<Model.Devise>>();
            }
            return devises;
        }
    }
}
