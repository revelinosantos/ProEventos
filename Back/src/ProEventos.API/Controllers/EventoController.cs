using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
   public IEnumerable<Evento> _evento = new Evento[] {
      new Evento() 
      {
         EventoId = 1,
         Local = "Porto Velho",
         DataEvento = DateTime.Now.AddDays(10).ToString("dd/MM/yyyy"),
         Tema = "Angular e .NET",
         QtdPessoas = 350,
         Lote = "001",
         ImagemUrl = "foto.png"
      },
      new Evento() 
      {
         EventoId = 2,
         Local = "Rio de Janeiro",
         DataEvento = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"),
         Tema = "Angular 19 .NET 9",
         QtdPessoas = 150,
         Lote = "30",
         ImagemUrl = "foto2.png"
      },
      new Evento() 
      {
         EventoId = 3,
         Local = "Manaus",
         DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
         Tema = "JWT com Angular e .NET",
         QtdPessoas = 45,
         Lote = "938",
         ImagemUrl = "foto3.png"
      }
   };
   public EventoController(){}
    

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
       return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
       return _evento.Where( evento => evento.EventoId == id);
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
