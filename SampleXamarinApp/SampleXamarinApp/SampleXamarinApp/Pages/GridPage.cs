﻿using System;

using Xamarin.Forms;

namespace SampleXamarinApp.Pages
{
    public class GridPage : ContentPage
    {
        public GridPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

