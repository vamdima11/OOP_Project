using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace BookStoresWebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookStoresDBContext _context;

        public BooksController(BookStoresDBContext context)
        {
            _context = context;
        }

        // GET: api/GetBooks
        [HttpGet("GetBooks")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }
        [HttpPost("TakeBook")]
        public async Task<ActionResult> TakeBook([FromBody] BookUser bookUser)
        {
            await _context.BookUsers.AddAsync(bookUser);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("GetBooksUsers")]
        public async Task<ActionResult<IEnumerable<BookUser>>> GetBooksUsers()
        {
            return await _context.BookUsers.Include(bu => bu.Book).ToListAsync();
        }



        [HttpPut("UpdateBook/{id}")]
        public async Task<ActionResult> UpdateBook(int id, [FromBody] Book book)
        {
            var oldBook = await _context.Books.FindAsync(id);
            oldBook.book_quantity = book.book_quantity;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpGet("GetBookUsers/{userId}")]
        public async Task<ActionResult<IEnumerable<BookUser>>> GetBooksTakenByUser(int userId)
        {
            return await _context.BookUsers.Include(bu => bu.Book).Where(bu => bu.UserId == userId).ToListAsync();
        }

        [HttpDelete("DeleteBookUser/{bookId}/{userId}")]
        public async Task<ActionResult> DeleteBookUser(int bookId, int userId)
        {
            var bookUser = await _context.BookUsers.FindAsync(userId, bookId);
            _context.Remove(bookUser);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}