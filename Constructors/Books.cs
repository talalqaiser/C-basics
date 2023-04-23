using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Books
    {
        public string title;
        public string author;
        public int year;
        public int pages;
        public Books(string atitle, string aauthor, int ayear, int apages) { 
            title = atitle;
            author = aauthor;
            year = ayear;
            pages = apages;
        }
    }
}
