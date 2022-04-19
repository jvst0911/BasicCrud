using BasicCrud.Entities;
using BasicCrud.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BasicCrud.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(IPessoaRepository personRepository)
        {
            _pessoaRepository = personRepository;
        }
        [HttpPost]
        public ActionResult Post(Pessoa person)
        {
            var post = _pessoaRepository.Insert(person);
            if (post > 0)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var get = _pessoaRepository.GetAll();
            if (get != null)
            {
                return Ok(get);
            }
            else
            {
                return NotFound();
            }

        }
        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute] int id)
        {
            var get = _pessoaRepository.GetById(id);
            if (get != null)
            {
                return Ok(get);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            var del = _pessoaRepository.Delete(id);
            if (del == 1)
            {
                return Ok(del);
            }
            else
            {
                return BadRequest("salah NIK atau nik tidak ditemukan");
            }
        }
        [HttpPut]
        public ActionResult Put(Pessoa person)
        {
            var get = _pessoaRepository.Update(person);
            return Ok(get);
        }
    }
}
