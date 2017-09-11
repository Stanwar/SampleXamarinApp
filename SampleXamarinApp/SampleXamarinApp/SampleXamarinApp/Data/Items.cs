using System;
using System.Collections.Generic;

namespace SampleXamarinApp.Data
{
    public class Items
    {

		public int ItemId
		{
			get;
			set;
		}
        public string ItemName
        {
            get;
            set;
        }

        public Items()
        {
        }

        public List<Items> GetItemData(){
            List<Items> itemList = new List<Items>();

            Items item = new Items();
            item.ItemId = 1;
            item.ItemName = "First";
            itemList.Add(item);

            item = new Items();
            item.ItemId = 2;
            item.ItemName = "Second";
            itemList.Add(item);

            item = new Items();
            item.ItemId = 3;
            item.ItemName = "Third";
            itemList.Add(item);

            return itemList;
        }
    }
}
