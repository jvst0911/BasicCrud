using BasicCrud.Core.Entities;
using BasicCrud.Core.Entities.Mock;
using BasicCrud.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BasicCrud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            var pessoas = PessoaMock._pessoas.Select(x => x);
            if (pessoas.Count() > 0)
                return Ok(pessoas);
            else
                return NoContent();
        }
        [HttpGet("{cpf}")]
        public ActionResult GetByCpf([FromRoute] string cpf)
        {
            var pessoa = PessoaMock._pessoas.Where(x => Utils.DeixaNumeros(x.CPF) == Utils.DeixaNumeros(cpf)).FirstOrDefault();
            if (pessoa != null || pessoa != default)
                return Ok(pessoa);
            else
                return NoContent();
        }
        [HttpPost]
        public ActionResult Post(Pessoa person)
        {
            PessoaMock._pessoas.Add(person);
            return Ok();
        }
        [HttpDelete("{cpf}")]
        public ActionResult Delete([FromRoute] string cpf)
        {
            var pessoa = PessoaMock._pessoas.Where(x => Utils.DeixaNumeros(x.CPF) == Utils.DeixaNumeros(cpf)).FirstOrDefault();

            if (pessoa != null || pessoa != default)
            {
                PessoaMock._pessoas.Remove(pessoa);
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}
