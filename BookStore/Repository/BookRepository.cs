
using BookStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> BookList()
        {
            
            return GetAllBooks(); 
        }

        public BookModel bookdetails(int id)
        {
          
            return GetAllBooks().Where(x=>x.id==id).FirstOrDefault();
        }

        public List<BookModel> bookdetailsbyidandname(string title, string name)
        {
            return GetAllBooks().Where(x => x.Title.Contains(title) && x.BookName.Contains(name)).ToList();
        }

        private List<BookModel>  GetAllBooks()
        {
            return new List<BookModel>()
            {
                new BookModel{id = 1, BookName="C#", Title="c# title", Description="this is c# Language"},
                new BookModel{id = 2, BookName="F#", Title="f# title", Description ="this is F# Language"},
                new BookModel{id = 3, BookName="c", Title="c title", Description="This is c Language" }
            };
        }

       
    }
}
