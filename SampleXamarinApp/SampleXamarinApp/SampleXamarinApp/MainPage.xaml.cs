using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleXamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasBackButton(this,true);
            InitializeComponent();
        }

        public void GotoLanding(object sender, EventArgs e){
            NavigationPage landingPage = new NavigationPage(new Pages.LandingPage());
            App.Current.MainPage = landingPage;
        }
    }
}
