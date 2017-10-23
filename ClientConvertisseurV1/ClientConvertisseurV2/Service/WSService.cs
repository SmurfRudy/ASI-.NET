using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Net.Http;
using System.Net.Http.Headers;
=======
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
>>>>>>> 71c5c606c6b23313cac7c97fa318da2b4f4abc4d
using System.Threading.Tasks;

namespace ClientConvertisseurV2.Service
{
    class WSService
    {
<<<<<<< HEAD
        private static HttpClient httpClient = new HttpClient();
        private static Service.ErrorDialog error = new ErrorDialog();
        private static WSService instance = new WSService();

        private WSService()
        {
            httpClient.BaseAddress = new Uri("http://localhost:1640/api/");
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
=======
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
>>>>>>> 71c5c606c6b23313cac7c97fa318da2b4f4abc4d
        }
    }
}
