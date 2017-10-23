using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClientConvertisseurV2.Service
{
    class WSService
    {
        private static HttpClient httpClient = new HttpClient();
        private static Service.ErrorDialog error = new ErrorDialog();
        private static WSService instance = new WSService();

        private WSService()
        {
            httpClient.BaseAddress = new Uri("http://localhost:1864/api/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<Model.Devise>> getAllDevisesAsync()
        {
            List<Model.Devise> devises = new List<Model.Devise>();
            HttpResponseMessage response = null;
            try
            {
                response = await httpClient.GetAsync("devise");
            }
            catch (Exception e)
            {
                await error.showErrorAsync("WS non disponible");
            }
            if (response.IsSuccessStatusCode)
            {
                devises = await response.Content.ReadAsAsync<List<Model.Devise>>();
            }
            return devises;
        }

        public static WSService getInstance()
        {
            return instance;
        }
    }
}
