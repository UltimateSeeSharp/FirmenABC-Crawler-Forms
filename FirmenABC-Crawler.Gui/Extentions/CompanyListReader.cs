using FirmenABC_Crawler.Gui.Model;
using FirmenABC_Crawler.Gui.Model.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FirmenABC_Crawler.Gui.Extentions
{
    internal class CompanyListReader
    {
        internal static List<Company> GetCompanies()
        {
            List<Company> companies = new List<Company>();
            foreach (Enum district in Enum.GetValues(typeof(District)))
            {
                foreach (Enum sector in Enum.GetValues(typeof(Sector)))
                {
                    var json = File.ReadAllText($"Assets\\{sector}{district}.txt");
                    var newCompanies = JsonConvert.DeserializeObject<List<Company>>(json);
                    companies.AddRange(newCompanies);
                }
            }
            return companies;
        }
    }
}
