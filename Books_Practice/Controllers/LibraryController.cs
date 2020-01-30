using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Books_Practice.Data;
using Books_Practice.Models;

namespace Books_Practice.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            LList theModel = new LList();
            List<Library> libList = new List<Library>();

            Library l1 = new Library();
            l1.Id = 1;
            l1.Name = "Big Library";
            l1.Manager = "Karen";
            libList.Add(l1);

            Library l2 = new Library();
            l2.Id = 2;
            l2.Name = "Small Library";
            l2.Manager = "Pillip";
            libList.Add(l2);

            Library l3 = new Library();
            l3.Id = 3;
            l3.Name = "Medium Library";
            l3.Manager = "Gretchen";
            libList.Add(l3);

            theModel.lList = libList;

            return View(theModel);
        }

        public IActionResult Details(int Id, string Name, string Manager)
        {
            Library l1 = new Library();
            l1.Id = Id;
            l1.Name = Name;
            l1.Manager = Manager;

            return View(l1);
        }
    }
}