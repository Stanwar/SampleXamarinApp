using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleXamarinApp.Pages
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }
		public void GotoGrid(object sender, EventArgs e)
		{
            Navigation.PushAsync(new Pages.GridPage());
		}

		public void GotoViews(object sender, EventArgs e)
		{
            Navigation.PushAsync(new Pages.ListViewExample());
		}
    }
}