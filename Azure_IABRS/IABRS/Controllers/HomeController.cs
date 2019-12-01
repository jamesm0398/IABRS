﻿/*###############################################################
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

namespace IABRS.Controllers
{


    public class HomeController : Controller
    {

        private readonly User _user;
        private readonly CourseUser _courseUser;

        
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
        
        public IActionResult YourProfile(User uModel)
        {
            ViewData["UserInfo"] = uModel;
            return View();
        }
        /// <summary>
        /// Serves the home page
        /// </summary>
        /// <returns>IActionResult home page</returns>

        public IActionResult SellBooks(List<BookUsers> books)
        {
            List<BookUsers> ownedBooks = new List<BookUsers>();

            //add owned books to this list
            foreach (var book in books)
            {
                if (book.Owned == true)
                {
                    ownedBooks.Add(book);
                }
            }
            

            ViewData["UsersBooks"] = ownedBooks;
            return View();
        }
        /// <summary>
        /// Serves the Buy books page
        /// </summary>
        /// <returns>IActionResult Buy books page</returns>
       
        public IActionResult BuyBooks(List<BookUsers> books)
        {

            ViewData["Books"] = books;
            return View();
        }
        /// <summary>
        /// Serves the Shopping cart page
        /// </summary>
        /// <returns>IActionResult Shopping cart page</returns>
        
        public IActionResult ShoppingCart(List<BookUsers> books)
        {
            List<BookUsers> booksInCart = new List<BookUsers>();

            foreach (var book in books)
            {
                if (book.InCart == true)
                {
                    booksInCart.Add(book);
                }
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
