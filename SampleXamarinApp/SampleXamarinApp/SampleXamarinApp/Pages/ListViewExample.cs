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
            listView.ItemsSource = new Data.Items().GetItemData();
            listView.ItemTemplate = new DataTemplate(() => {
                var cell = new TextCell();
                cell.SetBinding(TextCell.TextProperty, "ItemName");
                cell.SetBinding(TextCell.DetailProperty, "ItemId");
                return cell;
            });

            Content = listView;
        }
    }
}

