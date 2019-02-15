using Microsoft.AspNetCore.Mvc;
using Senai.SviGufo.WebApi.Interfaces;
using Senai.SviGufo.WebApi.Properties.Domains;
using Senai.SviGufo.WebApi.Repositories;
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
            new TipoEventoDomain{ID = 4, Nome = "Design"}
        };

        private ITipoEventoRepository tipoEventoRepository { get; set; }

        public TiposEventosController()
        {
            tipoEventoRepository = new TipoEventoRepository();
        }
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
        public IEnumerable<TipoEventoDomain> get() => tipoEventoRepository.listar();

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
        /// <summary>
        /// Envia dados
        /// </summary>
        /// <param name="tipoEvento"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult post(TipoEventoDomain tipoEvento)
        {
            return Ok();
        }
        /// <summary>
        /// Atualiza dados
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult put(TipoEventoDomain tipoEvento)
        {
            return Ok();
        }
        /// <summary>
        /// Altera tipo de evento passando o id pela url
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tipoEvento"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult putbyid(int id,TipoEventoDomain tipoEvento)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            return Ok();
        }
    }
}