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
    public class BooksController : Controller
    {       

        // GET: Books
        public async Task<IActionResult> Index()
        {
            BookList theModel = new BookList();
            List<Books> bList = new List<Books>();
            Books b1 = new Books();
            b1.Id = 1;
            b1.Title = "Harry Potter";
            b1.Author = "JK Rowling";
            b1.Length = 200;
            b1.Price = (int)2.50;
            b1.Published = new DateTime(2000, 1, 1);
            bList.Add(b1);

            Books b2 = new Books();
            b2.Id = 2;
            b2.Title = "Lord of The Rings";
            b2.Author = "JRR Tolkein";
            b2.Length = 300;
            b2.Price = (int)7.75;
            b2.Published = new DateTime(2010, 1, 1);
            bList.Add(b2);

            Books b3 = new Books();
            b3.Id = 3;
            b3.Title = "Cat in the Hat";
            b3.Author = "Dr Seuss";
            b3.Length = 400;
            b3.Price = (int)13;
            b3.Published = new DateTime(2009, 1, 1);
            bList.Add(b3);

            Books b4 = new Books();
            b4.Id = 4;
            b4.Title = "Harry Potter 2 Electric Boogaloo";
            b4.Author = "JK Rowling";
            b4.Length = 500;
            b4.Price = (int)6.50;
            b4.Published = new DateTime(2007, 1, 1);
            bList.Add(b4);

            Books b5 = new Books();
            b5.Id = 5;
            b5.Title = "The Thorax";
            b5.Author = "Dr Seuss";
            b5.Length = 600;
            b5.Price = (int)10;
            b5.Published = new DateTime(2019, 1, 1);
            bList.Add(b5);

            theModel.bookList = bList;
            return View(theModel);
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int Id, string Title, string Author, int Length, int Price, DateTime Published)
        {
            Books books = new Books();
            books.Id = Id;
            books.Title = Title;
            books.Author = Author;
            books.Length = Length;
            books.Price = Price;
            books.Published = Published;

            return View(books);
        }

        // GET: Books/Create
        

        // GET: Books/Edit/5
       

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        

        // GET: Books/Delete/5
        

        // POST: Books/Delete/5
        
    }
}
