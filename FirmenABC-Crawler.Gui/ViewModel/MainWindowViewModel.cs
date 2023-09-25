using FirmenABC_Crawler.Gui.Extentions;
using FirmenABC_Crawler.Gui.Infrastructure;
using FirmenABC_Crawler.Gui.Model;
using FirmenABC_Crawler.Gui.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace FirmenABC_Crawler.Gui.ViewModel
{
    internal class MainWindowViewModel : BaseViewModel
    {
        private List<Company> _allCompanies = null;
        private List<Sector> _selectedSectors = new List<Sector>();
        private List<District> _selectedDistricts = new List<District>();

        public MainWindowViewModel()
        {
            _allCompanies = CompanyListReader.GetCompanies();
            RefreshCompanies();
        }

        private string _searchText = string.Empty;
        public string SearchText
        {
            get => _searchText;
            set
            {
                if(_searchText == value)
                    return;
                _searchText = value;
                OnPropertyChanged();
                RefreshCompanies();
            }
        }

        void RefreshCompanies()
        {
            //  Search term sorted
            List<Company> companies = _allCompanies.Where(x => x.BusinessDesc.ToLower().Contains(SearchText.ToLower())
                                              || x.Name.ToLower().Contains(SearchText.ToLower())
                                              || x.Street.ToLower().Contains(SearchText.ToLower())
                                              || x.City.ToLower().Contains(SearchText.ToLower())
                                              || x.FoundingDate.ToLower().Contains(SearchText.ToLower())).ToList();

            Companies = companies;

            //  Sector sorted

            //List<Company> sectorSorted = companies.Select(x => x.District == );
            //foreach
            //
            //OnPropertyChanged(nameof(Companies));
        }

        private Company _selectedCompany = null;
        public Company SelectedCompany
        {
            get => _selectedCompany;
            set
            {
                if (_selectedCompany == value)
                    return;

                _selectedCompany = value;
                OnPropertyChanged(nameof(SelectedCompany));
            }
        }

        private List<Company> _companies = null;
        public List<Company> Companies
        {
            get => _companies;
            set
            {
                if (_companies == value)
                    return;
                _companies = value;
                OnPropertyChanged(nameof(Companies));
            }
        }

        public bool DornbirnActive { get; set; }
        public bool BregenzActive { get; set; }
        public bool FeldkirchActive { get; set; }
        public bool BludenzActive { get; set; }

        public bool TrafficActive { get; set; }
        public bool GasStationActive { get; set; }

        public void FilterChanged(object sender)
        {
            District district = (District)Enum.Parse(typeof(District), (sender as CheckBox).Content.ToString());
            _selectedDistricts.Add(district);
        }


    }
}