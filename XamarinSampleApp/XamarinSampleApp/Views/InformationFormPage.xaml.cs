using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinSampleApp.Models;
using XamarinSampleApp.ViewModels;


namespace XamarinSampleApp.Views
{
    public partial class InformationFormPage : ContentPage
    {
        private HttpClient client = new HttpClient();

        public InformationFormPage()
        {
            try
            {
                InitializeComponent();
         this.BindingContext = new InformationFormViewModel();

                this.BindingContext = new
                {
                    Name = "Name",
                    UploadPic = "Upload Photo",
                    TakePic = "Take Photo",
                    Nationality = "Nationality",
                    DOB = "Date of Birth",
                    MaritalStatus = "Marital Status",
                    Sex = "Sex"
                };

            }
            catch (Exception ex)
            {

            }
            //var answers = new List<string>();
            //answers.Add("Yes");
            //answers.Add("No");
            //var RadioGroup = new BindableRadioGroup()
            //{
            //    ItemsSource = answers,
            //    Orientation = StackOrientation.Horizontal
            //};
        }
        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    var response = await client.GetAsync("https://peopledetails.azurewebsites.net/api/country");
        //    string Json = await response.Content.ReadAsStringAsync();

        //    var post = JsonConvert.DeserializeObject<List<Countries>>(Json);

        //    Picker.ItemsSource = post;

        //}
    }
}
