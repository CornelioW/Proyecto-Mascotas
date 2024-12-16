using Microsoft.AspNetCore.Mvc;
using PetApi.Data;
using PetApi.Models;
using System.Linq; // <- Necesario para ToList()

namespace PetApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : ControllerBase
    {
        private readonly PetContext _context;

        public PetsController(PetContext context)
        {
            _context = context;
        }

        [HttpGet]
public IActionResult GetPets()
{
    var pets = _context.Pets.ToList();
    if (pets.Count == 0)
    {
        return Ok("No hay mascotas registradas."); // Mensaje si la lista está vacía
    }
    return Ok(pets);
}


    }
}
