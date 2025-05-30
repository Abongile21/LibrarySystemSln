using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSln
{
   class DVD : LibraryItem
    {

        public string Director { get; set; }
        public string Duration { get; set; }
        public override void Display()
        {
            Console.WriteLine($"[DVD] - ID: {ID}  Title: {Title}  Year: {Year} Director: {Director} Duration: {Duration}");
        }
    }
}
