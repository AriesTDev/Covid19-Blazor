using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Services.Interfaces;
using Services.Models;
using Microsoft.Extensions.Logging;

namespace Services.Implementations
{
    public class CovidService : ServiceBase, ICovidService
    {
        public CovidService(ILogger<CovidService> logger, HttpClient httpClient) : base(logger, httpClient) //public UploadFileService(HttpClient httpClient) : base(httpClient)
        {

        }

        public async Task<GlobalResponse> GetGlobalStatus()
        {
            try
            {
                var response = await HttpClient.GetAsync("all").ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var resultResponse = await response.Content
                    .ReadAsAsync<GlobalResponse>().ConfigureAwait(false);

                return resultResponse;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new GlobalResponse();
            }
        }

        public async Task<IEnumerable<ContinentResponse>> GetContinentStatus()
        {
            try
            {
                var response = await HttpClient.GetAsync("continents").ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var resultResponse = await response.Content
                    .ReadAsAsync<IEnumerable<ContinentResponse>>().ConfigureAwait(false);

                return resultResponse;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new List<ContinentResponse>();
            }
        }

        public async Task<IEnumerable<CountryResponse>> GetCountryStatus()
        {
            try
            {
                var response = await HttpClient.GetAsync("countries").ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var resultResponse = await response.Content
                    .ReadAsAsync<IEnumerable<CountryResponse>>().ConfigureAwait(false);

                return resultResponse;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new List<CountryResponse>();
            }
        }

    }
}
