using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSln
{
     class Library
    {
        private readonly Dictionary<string, LibraryItem> items = new();
        private  int numDVD, numBooks, numMagazines;

        public void AddItem(LibraryItem item)
        {
            if (items.ContainsKey(item.ID))
            {
                throw new ArgumentException("Item with this ID already exists.");
            }
            items[item.ID] = item;

        }

        public void DeleteItem(string ID)
        {
            if (!items.Remove(ID))
            {
                throw new KeyNotFoundException("Item ID not found.");
            }
        }


        public LibraryItem SearchItem( string ID)
        {
            if (items.TryGetValue(ID, out var item))
                return item;
            throw new KeyNotFoundException("Item ID not found.");
        }

        public void Filter(string type)
        {
            foreach (LibraryItem item in items.Values)

            {
               if(type==item.Type)
                 item.Display();
            }
        }

        public void DisplayItems()
        {
            
            if (items.Count == 0)
            {
                Console.WriteLine("No items in the Library");

            }
            
            foreach(LibraryItem item in items.Values)
            {
                item.Display();
                if (item.Type.ToLower() == "dvd")
                {
                    numDVD = item.ToString().Count();
                }
                if (item.Type.ToLower()=="book")
                {
                    numBooks = item.ToString().Count();
                }
                if (item.Type.ToLower() == "magazine")
                {
                    numMagazines = item.ToString().Count();
                }
            }
            
        }

    }
}
