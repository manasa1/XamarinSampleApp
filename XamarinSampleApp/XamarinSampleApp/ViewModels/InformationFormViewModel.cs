using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XamarinSampleApp.Models;
using XamarinSampleApp.WebApis;

namespace XamarinSampleApp.ViewModels
{
   public class InformationFormViewModel : INotifyPropertyChanged
    {
    
        public InformationFormViewModel()//ctor tab
        {


            GetValues();
           this.Datetime = new DateTime(2011, 12, 18);
            maritalStatus = new ObservableCollection<string>();
            maritalStatus.Add("Single");
            maritalStatus.Add("Married");
            LoadData();
        }

        private async void GetValues()
        {
         
            var list = new CountryList();
            Country =await list.GetCountries();
        }

        private ObservableCollection<Countries> countriesList;

        public ObservableCollection<Countries> Country//propfull tab twice
        {
            get { return countriesList; }
            set
            {
                countriesList = value;
            OnPropertyChanged();
            }
        }

        private DateTime dateTime;

        public DateTime Datetime
        {

            get { return dateTime; }

            set
            {
                dateTime = value;
                OnPropertyChanged();
            }
            }
        private ObservableCollection<string> maritalStatus;

        public ObservableCollection<string>  Status
        {

            get { return maritalStatus; }

            set
            {
                maritalStatus = value;
                OnPropertyChanged();
            }
        }

        private Dictionary<int, string> myList;
        public Dictionary<int, string> MyList
        {
            get { return myList; }
            set
            {
                myList = value;
                OnPropertyChanged();
            }
        }

        private void LoadData()
        {
            for (int i = 0; i < 3; i++)
            {
                MyList.Add(i, "Male " + i);
            }
        }













        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
