using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventosController : ControllerBase
{
    private readonly DataContext _context;

    public EventosController(DataContext context)
    {
        this._context = context;
    }


    [HttpGet]
    public IEnumerable<Evento> Get()
    {
       return _context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
       return _context.Eventos.FirstOrDefault( 
          evento => evento.EventoId == id
       );
    }

    [HttpPost]
    public string Post()
    {
       return "olá meu Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
       return $"Exemplo de put ID = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
       return $"Exemplo de Delete ID = {id}";
    }
    
    
}
