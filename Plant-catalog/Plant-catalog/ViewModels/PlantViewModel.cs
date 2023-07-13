using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Plant_catalog.Models;

namespace Plant_catalog.ViewModels
{
    public class PlantViewModel : INotifyPropertyChanged
    {
        private Plant plant;

        public string CommonName
        {
            get { return plant.CommonName; }
            set
            {
                plant.CommonName = value;
                OnPropertyChanged();
            }
        }

        public string ScientificName
        {
            get { return plant.ScientificName; }
            set
            {
                plant.ScientificName = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return plant.Description; }
            set
            {
                plant.Description = value;
                OnPropertyChanged();
            }
        }

        public string PositiveProperties
        {
            get { return plant.PositiveProperties; }
            set
            {
                plant.PositiveProperties = value;
                OnPropertyChanged();
            }
        }

        public string NegativeProperties
        {
            get { return plant.NegativeProperties; }
            set
            {
                plant.NegativeProperties = value;
                OnPropertyChanged();
            }
        }

        public string GrowthRegion
        {
            get { return plant.GrowthRegion; }
            set
            {
                plant.GrowthRegion = value;
                OnPropertyChanged();
            }
        }

        public PlantViewModel(Plant plant)
        {
            this.plant = plant;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
