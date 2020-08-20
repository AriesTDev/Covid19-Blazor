using Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICovidService
    {
        Task<GlobalResponse> GetGlobalStatus();
        Task<IEnumerable<ContinentResponse>> GetContinentStatus();
        Task<IEnumerable<CountryResponse>> GetCountryStatus();
    }
}
