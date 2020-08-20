using System.Net.Http;

namespace Services.Implementations
{
    public class BaseServiceImpl
    {
        protected readonly HttpClient HttpClient;

        public BaseServiceImpl(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
    }
}
