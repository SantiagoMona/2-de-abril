// Estoy agregando un comentario
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoBasesDeDatossa.Data;

namespace proyectoBasesDeDatoss.Controllers
{
    public class UsersController : Controller
    {
        public readonly DBContext _context;// DECLARACION DE VARIABLE LA CUAL SU TIPO ES EL MISMO NOMBRE DEL ARCHIVO DE DATA 

        public UsersController(DBContext context) // EN ESTE CONSTRUCTOR SE LE ASIGNA EL VALOR DE DBContext A context
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
           return View(await _context.Users.ToListAsync()); // esto me trae todo los que tenga esa tabla
        }

        public async Task<IActionResult> Details(int? id)
        {
            return View(await _context.Users.FirstOrDefaultAsync(m => m.Id == id));
        }

    }
}