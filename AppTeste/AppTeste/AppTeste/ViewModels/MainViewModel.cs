using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTeste.ViewModels
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class MainViewModel : ViewModel
    {
        public MainViewModel()
        {
            this.SaveCommand = new Command(Save);
            this.DeleteCommand = new Command(Delete);
        }

        private string _name;
        private string _legalName;
        private double _salary;
        private ObservableCollection<City> _cities = new ObservableCollection<City>();

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Set(ref _name, value);
            }
        }

        public string LegalName
        {
            get { return _legalName; }
            set { Set( ref _legalName, value); }
        }

        public double Salary
        {
            get { return _salary; }
            set { Set(ref _salary, value); }
        }

        public ObservableCollection<City> Cities
        {
            get
            {
                return _cities;
            }
        }

        public Command SaveCommand { get; set; }
        public Command DeleteCommand { get; set; }

        public void Save()
        {
            Cities.Add(new City { Name = this.Name });

            Name = "";
            LegalName = "";

            OnPropertyChanged("Cities");
        }

        public void Delete()
        {
            if (Cities.Any())
                Cities.RemoveAt(0);

            OnPropertyChanged("Cities");
        }
        
    }
}
