using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Marvel.WebAPI.Properties.Domains;

namespace Senai.Marvel.WebAPI.Properties.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagensController : ControllerBase
    {
        List<PersonagemDomain> personagens = new List<PersonagemDomain>()
        {
            new PersonagemDomain{ID = 1, NomePersonagem = "Homem-Aranha ",Lancamento= "Amazing Fantasy #15 (1962)",Descricao= "O adolescente que é mordido por uma aranha radioativa conseguiu se tornar no super-herói mais famoso de todos os tempos, estabelecendo uma forte conexão com todos os jovens que entram em contato com sua história."},
            new PersonagemDomain {ID = 2, NomePersonagem = "O Incrível Hulk",Lancamento=" O Incrível Hulk #1 (1962)",Descricao="O Incrível Hulk não é mais do que uma alegoria sobre a perda do auto-controle e como a raiva pode ser canalizada para algo positivo."},
            new PersonagemDomain {ID = 3, NomePersonagem="Homem de Ferro",Lancamento= "Tales of Suspense #39 (1963)", Descricao="Homem de Ferro é um personagem conhecido por ter pegado em uma situação extremamente má e se tornar em um super-herói. Com a ajuda de dinheiro e genialidade, claro."}
        };

        [HttpGet]
        public IEnumerable<PersonagemDomain> get() => personagens;

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            PersonagemDomain PersonagemEspecifico = personagens.Find(x => x.ID == id);

            if (PersonagemEspecifico == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(PersonagemEspecifico);
            }
        }
    }
}