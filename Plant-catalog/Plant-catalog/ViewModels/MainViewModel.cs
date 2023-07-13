using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Plant_catalog.Data;
using Plant_catalog.Models;

namespace Plant_catalog.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PlantCatalogContext dbContext;
        private List<Plant> allPlants;
        private List<PlantViewModel> filteredPlants;
        private string searchTerm;

        public List<PlantViewModel> FilteredPlants
        {
            get { return filteredPlants; }
            set
            {
                filteredPlants = value;
                OnPropertyChanged();
            }
        }

        public string SearchTerm
        {
            get { return searchTerm; }
            set
            {
                searchTerm = value;
                ApplySearch();
            }
        }

        public MainViewModel()
        {
            dbContext = new PlantCatalogContext();
            allPlants = dbContext.Plants.ToList();
            FilteredPlants = allPlants.Select(p => new PlantViewModel(p)).ToList();
        }

        private void ApplySearch()
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                FilteredPlants = allPlants.Select(p => new PlantViewModel(p)).ToList();
            }
            else
            {
                FilteredPlants = allPlants.Where(p =>
                    p.CommonName.ToLower().Contains(searchTerm.ToLower()) ||
                    p.ScientificName.ToLower().Contains(searchTerm.ToLower()) ||
                    p.Description.ToLower().Contains(searchTerm.ToLower()) ||
                    p.PositiveProperties.ToLower().Contains(searchTerm.ToLower()) ||
                    p.NegativeProperties.ToLower().Contains(searchTerm.ToLower()) ||
                    p.GrowthRegion.ToLower().Contains(searchTerm.ToLower())
                ).Select(p => new PlantViewModel(p)).ToList();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
