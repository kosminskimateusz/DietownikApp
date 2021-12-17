namespace DietownikApp.Services
{
    public class LocalService
    {
        private readonly HttpClient httpClient;

        public LocalService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public string GetBaseUrl()
        {
            return httpClient.BaseAddress.ToString();
        }
    }
}
