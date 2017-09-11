using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace SampleXamarinApp.Pages
{
    public class ListViewExample : ContentPage
    {
        public ListViewExample()
        {
            ListView listView = new ListView();
            List<TextCell> cells = new List<TextCell>();

            for (var i = 0; i < 10;i++){
                TextCell cell = new TextCell();
                cell.Text = "Cell No. " + i;
                cells.Add(cell);
            }

            listView.ItemsSource = cells;

            Content = listView;
        }
    }
}

