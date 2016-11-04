using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebAPI_App.Models;


namespace WebAPI_App
{
    public class WebAPIAppClientController : Controller
    {
        // GET: WebAPIAppClient
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult SeeAllBooks()
        {
            IList<BookModel> books = LibraryServiceProxy.GetAllBookDetails();
            return Json(books,JsonRequestBehavior.AllowGet);
        }

        public bool AddBook(String title, String author)
        {
            BookModel bookModel = new BookModel();
            bookModel.Title = title;
            bookModel.Author = author;
            bool status = LibraryServiceProxy.AddBook(bookModel);
            return status;
        }
    }
}