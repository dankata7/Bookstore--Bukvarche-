using Bookstore_Bukvarche.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_Bukvarche.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Books()
        {
            var books = await _context.Products.ToListAsync();


       
            return View(books);
            
        }
    }
}
