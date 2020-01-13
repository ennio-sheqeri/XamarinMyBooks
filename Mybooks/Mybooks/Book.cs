using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mybooks
{
     public class Book
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; } 
        public string Name { get; set; }
        public string Author { get; set; }

    }
}
