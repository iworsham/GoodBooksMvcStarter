using GoodBooksMvc.DataAccess;
using GoodBooksMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GoodBooksMvc.DataAccess;
using GoodBooksMvc.Models;

namespace GoodBooksMvc.Controllers
{
    public class BooksController : Controller
    {
        private readonly GoodBooksMvcContext _context;
        public BooksController(GoodBooksMvcContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var books = _context.Books.ToList();

            return View(books);
        }
    }
}
