namespace DietownikApp.Services
{
    public class DietownikAPIService
    {
        private readonly HttpClient httpClient;

        public DietownikAPIService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public string GetBaseUrl()
        {
            return httpClient.BaseAddress.ToString();
        }
    }
}
