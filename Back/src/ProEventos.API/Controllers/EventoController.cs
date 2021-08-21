using System;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController() 
        {     
        }

        [HttpGet]
        public Evento Get() 
        {
           return new Evento() {
              EventoId = 1,
              Tema = "Angular 11 e .NET 5",
              Local = "Fortaleza",
              Lote = "1º lote",
              QtdPessoas = 250,
              DataEvento = DateTime.Now.AddDays(2).ToString(),
              ImagemURL = "foto.png"
           };
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
