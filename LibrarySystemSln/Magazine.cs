using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemSln
{
    class Magazine : LibraryItem
    {

        public string IssueNumber { get; set; }
        public string Month { get; set; }
        public override void Display()
        {
            Console.WriteLine($"[Magazine] - ID: {ID}  Title: {Title}  Year: {Year} IssueNumber: {IssueNumber} Month: {Month}");

        }
    }
}
