using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_Practice.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
    }

    public class LList
    {
        public List<Library> lList { get; set; }
    }
}
