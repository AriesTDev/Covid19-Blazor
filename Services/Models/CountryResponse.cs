
namespace Services.Models
{
    public class CountryResponse
    {
        public long updated { get; set; }
        public string country { get; set; }
        public CountryInfo countryInfo { get; set; }
        public long cases { get; set; }
        public long todayCases { get; set; }
        public long deaths { get; set; }
        public long todayDeaths { get; set; }
        public long recovered { get; set; }
        public long active { get; set; }
        public long critical { get; set; }
        public int casesPerOneMillion { get; set; }
        public int deathsPerOneMillion { get; set; }
        public int tests { get; set; }
        public int testsPerOneMillion { get; set; }
        public string continent { get; set; }
    }
}
