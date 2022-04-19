using Bookstore_Bukvarche.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_Bukvarche.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Books()
        {
            var books = await _context.Products.Where(x => x.Category.Name == "Книги").ToListAsync();

            return View(books);

        }

    
    public async Task<IActionResult> Textbooks()
    {
        var textbooks = await _context.Products.Where(x => x.Category.Name == "Учебници").ToListAsync();

        return View(textbooks);

    }
        public async Task<IActionResult> School_supplies()
        {
            var school_supplies = await _context.Products.Where(x => x.Category.Name == "Ученически пособия" || x.Category.Name == "Химикалки" || x.Category.Name == "Тетрадки" ).ToListAsync();

            return View(school_supplies);
        
        }
    }
}
    

