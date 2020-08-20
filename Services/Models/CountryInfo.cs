
namespace Services.Models
{
    public class CountryInfo
    {
        public long _id { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
        public int lat { get; set; }
        public int @long { get; set; }
        public string flag { get; set; }

    }
}
