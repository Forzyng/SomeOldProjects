using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WelcomeASP.Data;
using WelcomeASP.Data.Entities.Trello;

namespace WelcomeASP.Controllers
{
    public class TrelloController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrelloController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Построит все доступные доски
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            return View(await _context.Boards.ToListAsync());
        }

        /// <summary>
        /// Отобразить колонки для данной доски
        /// </summary>
        /// <param name="id">Id Доски</param>
        /// <returns></returns>
        public async Task<IActionResult> ShowColumns(Guid id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var Board = _context.Boards.First(b => b.Id == id);

            ViewData["Title"] = "Доска: " + Board.Title;
            ViewData["ParallaxTitle"] = Board.Title;
            ViewData["ParallaxText"] = "Information  e.t.c";

            ViewData["BoardId"] = Board.Id;

            var column = _context.Columns
                .Include(c => c.Cards)
                .Where(m => m.BoardId == id);
            if (column == null)
            {
                return NotFound();
            }

            return View(await column.ToListAsync());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBoard([Bind("Id,Title")] Board board)
        {
            if (ModelState.IsValid)
            {
                board.Id = Guid.NewGuid();
                _context.Add(board);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ShowColumns), new { board.Id });
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateColumn([Bind("Id,BoardId,Title")] Column column)
        {
            if (ModelState.IsValid)
            {
                column.Id = Guid.NewGuid();
                _context.Add(column);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ShowColumns), new { Id = column.BoardId });
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCard([Bind("Id,ColumnId,Title,Body")] Card card, Guid BoardId)
        {
            if (ModelState.IsValid)
            {
                card.Id = Guid.NewGuid();
                _context.Add(card);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ShowColumns), new {Id = BoardId});
            }
            return View(card);
        }
    }
}
