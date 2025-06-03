using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSln
{
    abstract class LibraryItem

    {
        public string? Type { get; set; }
        public string? Title{ get; set; }
        public string? ID { get; set; }
        public int Year { get; set; }

        public abstract void Display();





    }
}
