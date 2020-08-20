
namespace Services.Models
{
    public class GlobalResponse
    {
        public long updated { get; set; }
        public long cases { get; set; }
        public long todayCases { get; set; }
        public long deaths { get; set; }
        public long todayDeaths { get; set; }
        public long recovered { get; set; }
        public long active { get; set; }
        public long critical { get; set; }
        public long casesPerOneMillion { get; set; }
        public long deathsPerOneMillion { get; set; }
        public long tests { get; set; }
        public long testsPerOneMillion { get; set; }
        public string continent { get; set; }
        public int affectedCountries { get; set; }
    }
}
