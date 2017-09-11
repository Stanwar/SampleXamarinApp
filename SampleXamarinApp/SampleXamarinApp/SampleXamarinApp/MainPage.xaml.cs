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
            InitializeComponent();
        }

        public async void GotoGrid(object sender, EventArgs e){
            NavigationPage gridPage = new NavigationPage(new Pages.GridPage());
            await this.Navigation.PushAsync(gridPage);
        }

        public async void GotoViews(object sender, EventArgs e){
            NavigationPage viewPage = new NavigationPage(new Pages.ListViewExample());
            await this.Navigation.PushAsync(viewPage);
        }
    }
}
