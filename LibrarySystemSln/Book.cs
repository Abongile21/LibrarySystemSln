using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSln
{
    class Book : LibraryItem
    {

        public string? Author{get; set;}
        public string? Genre { get; set; }
        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[Book] - ");
            Console.ResetColor();
            Console.WriteLine($"         ID: {ID}  Title: {Title}  Year: {Year} Author: {Author} Genre: {Genre}");
           
        }
    }
}
