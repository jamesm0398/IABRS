/*###############################################################
 *  File:           HomeController.cs
 *  Project :       NAD Assignment 4
 *  Programmer :    John Hall, James Milne
 *  Date :          11/10/2019
 *  
 *  Name:           HomeController
 *  Purpose:        Handles all http requests to standard user pages 
 * ##############################################################*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using IABRS.Models;
using IABRS.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace IABRS.Controllers
{


    public class HomeController : Controller
    {

        private readonly User _user;
        private readonly CourseUser _courseUser;
        public UserManager<User> userManager { get; }


        
        /// <summary>
        /// Serves the home page
        /// </summary>
        /// <returns>IActionResult home page</returns>
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Serves the Your profile page
        /// </summary>
        /// <returns>IActionResult Your profile page</returns>
        
        public async Task<IActionResult> YourProfileAsync()
        {
            testsForNADContext db = new testsForNADContext();
            var curUser = await userManager.GetUserAsync(HttpContext.User);

            IQueryable<User> user = from u in db.User select u;
            

            ViewData["UserInfo"] = user;
            return View();
        }
        /// <summary>
        /// Serves the home page
        /// </summary>
        /// <returns>IActionResult home page</returns>

        public async Task<IActionResult> SellBooksAsync()
        {
            var curUser = await userManager.GetUserAsync(HttpContext.User);
            List<BookUsers> ownedBooks = new List<BookUsers>();
            testsForNADContext db = new testsForNADContext();
            IQueryable<BookUsers> bookUsers = from u in db.BookUsers where u.UserId == curUser.UserId select u;

            foreach (BookUsers book in bookUsers)
            {
                book.Book = (Book)(from u in db.BookUsers where u.UserId == curUser.UserId select u);
                ownedBooks.Add(book);
            }

           

            ViewData["UsersBooks"] = ownedBooks;
            return View();
        }
        /// <summary>
        /// Serves the Buy books page
        /// </summary>
        /// <returns>IActionResult Buy books page</returns>

        public IActionResult BuyBooks()
        {
            List<Book> books = new List<Book>();
            testsForNADContext db = new testsForNADContext();
            IQueryable<Book> booksIQ = from u in db.Book select u;

            foreach(Book item in booksIQ)
            {
                books.Add(item);
            }


            ViewData["Books"] = books;
            return View();
        }
        /// <summary>
        /// Serves the Shopping cart page
        /// </summary>
        /// <returns>IActionResult Shopping cart page</returns>
        
        public async Task<IActionResult> ShoppingCartAsync()
        {
            var curUser = await userManager.GetUserAsync(HttpContext.User);
            List<BookUsers> booksInCart = new List<BookUsers>();
            testsForNADContext db = new testsForNADContext();
            IQueryable<BookUsers> bookUsers = from u in db.BookUsers select u;


            foreach(BookUsers item in bookUsers)
            {
                item.Book =(Book) (from u in db.BookUsers where u.InCart == true && u.UserId == curUser.UserId select u);
                booksInCart.Add(item);
            }


            if(booksInCart == null)
            {
                return View("No items in cart");
            }

            ViewData["Books"] = booksInCart;
            return View();




        }
        /// <summary>
        /// Serves the Privacy page
        /// </summary>
        /// <returns>IActionResult privacy page</returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Is triggered on error and shows an error report
        /// </summary>
        /// <returns>IActionResult error report</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
