using System;
using System.Net.Http;

namespace Entidades
{
    public delegate void DataResponse(string json, object originalSender);
    public class Descargador
    {
        public event DataResponse FinDescarga;
        private HttpClient client;

        public Descargador()
        {
            this.client = new HttpClient();
        }
        public async void Descargar(string url, object originalSender)
        {
            try
            {
                HttpResponseMessage response = await this.client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                FinDescarga.Invoke(responseBody, originalSender);
            }
            catch (Exception){ }
        }
    }
}
