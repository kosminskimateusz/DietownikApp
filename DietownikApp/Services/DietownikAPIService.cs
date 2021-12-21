namespace DietownikApp.Services
{
    public class DietownikAPIService
    {
        private readonly HttpClient httpClient;

        public DietownikAPIService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public HttpClient GetHttpClient()
        {
            return httpClient;
        }
    }
}
