using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_Practice.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }
        public int Price { get; set; }
        public DateTime Published { get; set; }
    }
    public class BookList
    {
        public List<Books> bookList { get; set; }

    }
}
