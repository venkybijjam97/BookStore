using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
       
       public string BookDetails()
        {
            return "book details";
        }

        public string ListOfBooks()
        {
            return "List of books";
        }

        public string GetBook(int id)
        {
            return $"Book Details by ID = {id}";
        }

        public string GetBookDetailsOnNameAndAuthor(string name,string Author)
        {
            return $"Book details filter by name and author ={name} and {Author}"; 

        }
    }
}
