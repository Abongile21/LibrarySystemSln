using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSln
{
   class DVD : LibraryItem
    {

        public string? Director { get; set; }
        public TimeSpan Duration { get; set; }
        public override void Display()

        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[DVD] - ");
            Console.ResetColor();

            Console.WriteLine($"         ID: {ID}  Title: {Title}  Year: {Year} Director: {Director} Duration: {Duration}");
        }
    }
}