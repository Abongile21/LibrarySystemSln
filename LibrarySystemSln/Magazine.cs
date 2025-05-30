using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSln
{
    internal class Magazine : LibraryItem
    {
        public override void Display()
        {
            Console.WriteLine($"[Magazine] - ID: {ID}  Title: {Title}  Year: {Year}");

        }
    }
}
