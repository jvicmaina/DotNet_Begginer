using Microsoft.AspNetCore.Mvc;
using virtual_fitness_coach.Data;

namespace virtual_fitness_coach.Controllers;

public class AuthController : Controller
{
    private readonly VfcDbContext _context;

    public AuthController(VfcDbContext context){
        _context =context;
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }
}
