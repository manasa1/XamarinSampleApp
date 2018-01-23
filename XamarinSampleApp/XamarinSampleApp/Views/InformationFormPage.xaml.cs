using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinSampleApp.Views
{
    public partial class InformationFormPage : ContentPage
    {
        public InformationFormPage()
        {
            try
            {
                InitializeComponent();
               this.BindingContext = new
                {
                    Name = "Name",
                   UploadPic = "Upload Photo",
                   TakePic="Take Photo",
                   Nationality = "Nationality",
                   DOB="Date of Birth",
                   MaritalStatus= "Marital Status",
                   Sex ="Sex"
               };

            }
            catch (Exception ex)
            {

            }
          GetCountriesList();
        }
        public async Task<string> GetCountriesList()
        {

            var client = new System.Net.Http.HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            var address = "https://api.printful.com/countries"; //?format=application/json";

            var response = await client.GetAsync(address);

            var airportJson = response.Content.ReadAsStringAsync().ToString();

            //var rootobject = JsonConvert.DeserializeObject<Rootobject>(airportJson);

            return airportJson;

        }
    }
}
