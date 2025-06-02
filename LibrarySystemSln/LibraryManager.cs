using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSln
{
    internal class LibraryManager
    {
        public static LibraryItem  CreateItem(string type)
        {
            Console.Write("Enter ID: ");
            var id = Console.ReadLine();
            Console.Write("Enter Title: ");
            string title = Console.ReadLine()!;
            Console.Write("Enter Year Published: ");
            int year = int.Parse(Console.ReadLine()!);

            return type.ToLower() switch
            {
                "book" => new Book
                {
                    ID=id,
                    Title=title,
                    Year= year,
                    Author= Ask("Enter author's name: "),
                    Genre = Ask("Enter genre's name: ")

                },

                "dvd" => new DVD
                {
                     ID = id,
                     Title = title,
                     Year = year,
                     Director = Ask("Enter director's name: "),
                     Duration = Ask("Enter duration: "),

                },

                "magazine" =>new Magazine
                {

                     ID = id,
                     Title = title,
                     Year = year,
                     IssueNumber=Ask("Enter the issue number: "),
                     Month= Ask("Enter Month: ")
                     
                },
                _ => throw new ArgumentException("Invalid type selected")
            };
        }



       public static string Ask(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine()!;

        }
    }
}
