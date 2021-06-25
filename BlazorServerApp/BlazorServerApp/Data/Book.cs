using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Data
{
    public class Book
    {
        //unit of work
        public int BookId { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string Type { get; set; }
        public int PubId { get; set; }
        public decimal? Price { get; set; }
        public string Notes { get; set; }
        public DateTime PublishedDate { get; set; }
        public decimal? penalty_amount { get; set; }
        public int? book_quantity { get; set; }
        public Book()
        
        {

        }
        public Book(int bookId, string title, string type, int PubId, decimal price,
                   string notes, DateTime pblishedDate)
        {
            BookId = bookId;
            Title = title;
            Type = type;
            Notes = notes;
            PublishedDate = pblishedDate;
        }
    }
}
