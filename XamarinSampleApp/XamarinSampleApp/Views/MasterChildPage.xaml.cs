using Assignment.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinSampleApp.Views
{
    public partial class MasterChildPage : MasterDetailPage
    {
        public List<MasterPageItems> menuList { get; set; }

        public MasterChildPage()
        {
            try
            {


                InitializeComponent();

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PersonalDetailPage)));
                var personalDetails = new MasterPageItems() { Name = "Home", Photo = "Home.png", TargetType = typeof(PersonalDetailPage) };
                var informationForm = new MasterPageItems() { Name = "Add New", Photo = "AddPersonInformation.png", TargetType = typeof(InformationFormPage) };


                menuList = new List<MasterPageItems>();

                menuList.Add(personalDetails);
                menuList.Add(informationForm);
                MasterListview.ItemsSource = menuList;

            }
            catch (Exception ex)
            {

            }
          



        }
        public void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItems)e.SelectedItem;


            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance((page)));
            IsPresented = false;
        }
    }
}
