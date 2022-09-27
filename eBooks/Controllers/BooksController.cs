using Microsoft.AspNetCore.Mvc;
using eBooks.Data;
using eBooks.Models;
using Microsoft.EntityFrameworkCore;

namespace eBooks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly BooksContext dbContext;

        public BooksController(BooksContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public async Task<IActionResult> Books()
        {
            return Ok(await dbContext.Books.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddBooks(Books addBooks)
        {
            var books = new Books()
            {
                id = addBooks.id,
                Name = addBooks.Name,
                title = addBooks.title,
                Price = addBooks.Price
            };

            await dbContext.Books.AddAsync(books);
            await dbContext.SaveChangesAsync();
            return Ok(books);
        }

        public async Task<IActionResult> UpdateBooks()
        {
            return Ok();
        }
    }
}
