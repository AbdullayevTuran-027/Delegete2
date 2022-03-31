using System;
using System.Collections.Generic;
using System.Text;

namespace Delegete_part2.Models
{
    internal class Book
    {
        internal int? Id;

        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; } 

        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}- AuthorName:{AuthorName}- PageCount:{PageCount}");
        }
    }

}
