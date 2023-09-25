using FirmenABC_Crawler.Gui.Model.Enum;
using Newtonsoft.Json;
using System.Reflection.Emit;

namespace FirmenABC_Crawler.Gui.Model
{
    internal class Company
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        [JsonProperty(PropertyName = "website")]
        public string Website { get; set; }

        public string Fax { get; set; }

        public string Street { get; set; }

        public string Plz { get; set; }

        public string City { get; set; }

        [JsonProperty("business_desc")]
        public string BusinessDesc { get; set; }

        [JsonProperty("founding_date")]
        public string FoundingDate { get; set; }

        public string Owner { get; set; }

        public District District { get; set; }

        public Sector Sector { get; set; }
    }
}
