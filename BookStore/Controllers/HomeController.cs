using Microsoft.AspNetCore.Mvc;
using BookStore.Repository;
using System.Dynamic;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookRepository _bookrepository;

        public HomeController()
        {
            _bookrepository = new BookRepository();
        }
        public ViewResult Index()
        {
          var booklist=  _bookrepository.BookList();
            return View(booklist);
        }

        public ViewResult Bookdetails(int id)
        {
            var bookdetails = _bookrepository.bookdetails(id);
            return View(bookdetails);
        }
        public ViewResult AboutUs()
        {
            ViewBag.name = "Venky";
            dynamic obj = new ExpandoObject();
            obj.id = 1;
            obj.names = "venkat";
            ViewBag.obj = obj;

            ViewData["ActionName"] = "AboutUs Page";
            ViewData["ActionDetails"] = new BookModel { id = 1,BookName = ".net" };
            
            return View();
        }

        public ViewResult Private()
        {
            return View();
        }
    }
}
