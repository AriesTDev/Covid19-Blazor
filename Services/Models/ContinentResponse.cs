
namespace Services.Models
{
    public class ContinentResponse
    {
        public long updated { get; set; }
        public long cases { get; set; }
        public long todayCases { get; set; }
        public long deaths { get; set; }
        public long todayDeaths { get; set; }
        public long recovered { get; set; }
        public long active { get; set; }
        public long critical { get; set; }
        public string continent { get; set; }
    }
}
