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
        public MasterChildPage()
        {
            InitializeComponent();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PersonalDetailPage)));

        }
    }
}
