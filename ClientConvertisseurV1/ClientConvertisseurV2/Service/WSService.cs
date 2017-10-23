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
        private static HttpClient httpClient;
        Service.ErrorMessage erreur_message = new Service.ErrorMessage();
        public WSService()
        {
            if (httpClient == null)
            {
                httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("http://localhost:1864/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }


        public async Task<List<Model.Devise>> getAllDevisesAsync()
        {
            List<Model.Devise> devises = new List<Model.Devise>();
            try {
                HttpResponseMessage response = await httpClient.GetAsync("Devise");
                if (response.IsSuccessStatusCode)
                {
                    devises = await response.Content.ReadAsAsync<List<Model.Devise>>();
                }
            }
            catch (Exception e)
            {
                await erreur_message.sendMessageErrorAsync("récupération devise");
            }

            
            return devises;
        }
    }
}
