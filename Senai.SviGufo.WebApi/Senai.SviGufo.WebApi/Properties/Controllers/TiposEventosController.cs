using Microsoft.AspNetCore.Mvc;
using Senai.SviGufo.WebApi.Properties.Domains;
using System.Collections.Generic;

namespace Senai.SviGufo.WebApi.Properties.Controllers
{
    //Define que o retorno será um json
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TiposEventosController : ControllerBase
    {
        List<TipoEventoDomain> tiposEventos = new List<TipoEventoDomain>()
        {
            new TipoEventoDomain{ID = 1, Nome= "Tecnologia"},
            new TipoEventoDomain{ID = 2, Nome = "Arquitetura"},
            new TipoEventoDomain{ID = 3, Nome= "Engenharia"},
            new TipoEventoDomain{ID = 4, Nome = "Educação"}
        };
        /// <summary>
        /// Retorna uma string atraves do metodo get
        /// </summary>
        /// <returns></returns>
        /// 
        //[HttpGet]
        //public string get()
        //{
        //    return "Requisição recebida com sucesso";
        //}


        [HttpGet]
        //retorna uma lista de eventos
        public IEnumerable<TipoEventoDomain> get() => tiposEventos;

        /// <summary>
        /// Retorna um tipo de evento pelo seu id
        /// </summary>
        /// <param name="id"> id do evento</param>
        /// <returns> tipo de evento</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            TipoEventoDomain TipoEventoSerProcurado = tiposEventos.Find(x => x.ID == id);
            if (TipoEventoSerProcurado == null)
            {
                return NotFound();

            }
            else
            {
                return Ok(value: TipoEventoSerProcurado);
            }
        }
    }
}