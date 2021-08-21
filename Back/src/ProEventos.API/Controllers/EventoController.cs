using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
               EventoId = 1,
               Tema = "Angular 11 e .NET 5",
               Local = "Fortaleza",
               Lote = "1º lote",
               QtdPessoas = 250,
               DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
               ImagemURL = "foto.png"
         },            
         new Evento() {
               EventoId = 2,
               Tema = "Java",
               Local = "Caucaia",
               Lote = "2º lote",
               QtdPessoas = 350,
               DataEvento = DateTime.Now.AddDays(3).ToString(),
               ImagemURL = "java.png"
         }
      };
        public EventoController() 
        {     
        }

        [HttpGet]
        public IEnumerable<Evento> Get() 
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id) // Sobrecarga de métodos
        {
           return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post() 
        {
           return "exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id) 
        {
           return $"exemplo de Put com id = {id}";
        }

         [HttpDelete("{id}")]
        public string Delete(int id) 
        {
           return $"exemplo de Delete com id = {id}";
        }

    }
}
