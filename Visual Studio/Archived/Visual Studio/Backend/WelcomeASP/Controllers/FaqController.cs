using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WelcomeASP.Data;

namespace WelcomeASP.Controllers
{
    public class FaqController : Controller
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Реализация DI
        /// Получение в конструктор контекста на базу данных
        /// </summary>
        /// <param name="context"></param>
        public FaqController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Faqs.ToListAsync());
        }


    }

}
