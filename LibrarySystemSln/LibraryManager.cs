using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSln
{
    internal class LibraryManager
    {


       public void Ask(string prompt)
        {
            Console.WriteLine(prompt);
            string answer = Console.ReadLine();
        }
    }
}
