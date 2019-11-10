using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model{
    public class Funcionario {
        public int id { get; set; }

        public string nome { get; set; }

        public string endereco { get; set ;}

        public DateTime? dataCriacao { get; set; }

        public DateTime? dataAtualizacao { get; set; }

        public string email { get; set; }

        public string telefone { get; set; }
    }

}