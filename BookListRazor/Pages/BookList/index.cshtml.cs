using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class indexModel : PageModel
    {

        private readonly ApplicationDBContext applicationDbContext;

        public indexModel(ApplicationDBContext db)
        {
            applicationDbContext = db;
        }


        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await applicationDbContext.Book.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id) {


            var book = await applicationDbContext.Book.FindAsync(id);

            if (book == null) {
                return NotFound();
            }

            applicationDbContext.Book.Remove(book);
            await applicationDbContext.SaveChangesAsync();

            return RedirectToPage("Index");
        }

    }
}
