using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinSampleApp.Models;

namespace XamarinSampleApp.WebApis
{
    public class CountryList
    {
       
        private const string url = "https://peopledetails.azurewebsites.net/";
        private HttpClient client = new HttpClient();
        public ObservableCollection<Countries> values;
        public async Task<ObservableCollection<Countries>> GetCountries()
        {
            //var countries = new List<Countries>();
          

                var response = await client.GetAsync(url + "api/country");
                string countryJson = await response.Content.ReadAsStringAsync();

               values = JsonConvert.DeserializeObject<ObservableCollection<Countries>>(countryJson);

               return values;
            }


           
          

            


        }
    }

