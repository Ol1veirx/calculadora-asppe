using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPPE___SOMA.Data;
using ASPPE___SOMA.Models;

namespace ASPPE___SOMA.Controllers
{
    public class EquipesController : Controller
    {
        private readonly ASPPE___SOMAContext _context;

        public EquipesController(ASPPE___SOMAContext context)
        {
            _context = context;
        }

        // GET: Equipes
        public async Task<IActionResult> Index()
        {
            var equipesOrdenadasPorPontos = await _context.Equipes
                .OrderByDescending(equipe => equipe.Pontos)
                .ToListAsync();
            return View(equipesOrdenadasPorPontos);
        }

        // GET: Equipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipes = await _context.Equipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipes == null)
            {
                return NotFound();
            }

            return View(equipes);
        }

        // GET: Equipes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Equipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Peso,Quantidade, Pontos, MaiorPeixe")] Equipes equipes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipes);
        }

        // GET: Equipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipes = await _context.Equipes.FindAsync(id);
            if (equipes == null)
            {
                return NotFound();
            }
            return View(equipes);
        }

        // POST: Equipes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Peso,Quantidade, Pontos, MaiorPeixe")] Equipes equipes)
        {
            if (id != equipes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipesExists(equipes.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(equipes);
        }

        // GET: Equipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipes = await _context.Equipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipes == null)
            {
                return NotFound();
            }

            return View(equipes);
        }

        // POST: Equipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipes = await _context.Equipes.FindAsync(id);
            if (equipes != null)
            {
                _context.Equipes.Remove(equipes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipesExists(int id)
        {
            return _context.Equipes.Any(e => e.Id == id);
        }

        public IActionResult Somar(int? id)
        {
            if (id == null) return NotFound();
            var equipes = _context.Equipes.Find(id);
            if (equipes == null) return NotFound();
            return View(equipes); 
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Somar(int id, int valorSomarQuantidade, double valorSomarPeso, double valorSomarPontos)
        {
            var equipe = _context.Equipes.Find(id);

            if (equipe == null) return NotFound();

            equipe.Quantidade += valorSomarQuantidade;
            equipe.Peso += valorSomarPeso;
            equipe.Pontos += valorSomarPontos;

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
