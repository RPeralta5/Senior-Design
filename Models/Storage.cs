using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class Storage
    {
        public List<Item> items = new List<Item>();
        public static IEnumerable<Item> Items
        {
            get { return Items; }
        }
        public void AddItem(Item thing)
        {
            items.Add(thing);
        }
    }
}
