using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExemploController.Controllers
{
    [ApiController]
    [Route("[controller]")] //aqui é onde defino a rota, [controller] quer dizer que o nome da rota é o mesmo nome da controller
    public class ExemploController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<List<PessoaInput>> getAll(){
            PessoaInput pessoa = new PessoaInput(1,"Ze");
            PessoaInput pessoa1 = new PessoaInput(2,"Maria");
            List<PessoaInput> listaPessoaInput = new List<PessoaInput>();
            listaPessoaInput.Add(pessoa);
            listaPessoaInput.Add(pessoa1);
            return listaPessoaInput;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<PessoaInput> findById(long id){
            PessoaInput pessoa = new PessoaInput(1,"Ze");
            return pessoa;
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status304NotModified)]
        public ActionResult<PessoaInput> update(long id, PessoaInput pessoa){
            if(ModelState.IsValid){
                PessoaInput p = new PessoaInput(pessoa.id,"Novo nome");
                return CreatedAtAction("update",p);
            }
            return BadRequest();
            
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<PessoaInput> save(PessoaInput pessoa){
            if(ModelState.IsValid){
                return CreatedAtAction("save",pessoa);
            }
            return BadRequest();
        }
    }
}