using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploController
{
    public class PessoaInput
    {
        public long id {get; private set;}
        
        [Required]
        [MinLength(3)]
        public string nome {get; private set;}

        public PessoaInput(long id, string nome){
            this.id = id;
            this.nome = nome;
        }
    }
}