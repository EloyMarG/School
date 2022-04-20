using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using School_5.Models;
using Microsoft.EntityFrameworkCore;

namespace School_5.Controllers
{
    public class EstudiantesController : Controller
    {
        private readonly School _context;

        public IActionResult Index()
        {
            var estudiantes = _context.People
                            .Where(r => r.EnrollmentDate != null)
                            .ToList();

            return View(estudiantes);
        }

        public IActionResult Ficha(int id)
        {

           // ViewData["Categorias"] = new SelectList(_context.Categories.ToList(), "CategoryID", "CategoryName");
           // ViewData["Proveedores"] = new SelectList(_context.Suppliers.ToList(), "SupplierID", "CompanyName");

            var estudiante = _context.People
                            .Where(r => r.PersonID == id)
                            .FirstOrDefault();

            return View(estudiante);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Ficha(int id, Person estudiante)
        {

            if(id != estudiante.PersonID) return NotFound();

            if(ModelState.IsValid)
            {
             _context.Update(estudiante);
             _context.SaveChanges();   
            };
            
            return View(estudiante);


        }


        public IActionResult Nuevo()
        {
           // ViewData["Categorias"] = new SelectList(_context.Categories.ToList(), "CategoryID", "CategoryName");
           // ViewData["Proveedores"] = new SelectList(_context.Suppliers.ToList(), "SupplierID", "CompanyName");

            return View("Ficha", new Person());
        }




        public EstudiantesController(School context)
        {
            _context = context;
        }
    }
}