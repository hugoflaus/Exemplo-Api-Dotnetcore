using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System;
using Model;
using System.Linq;

namespace DataAccess
{
    public class FuncionarioDA
    {
        private IConfiguration _configuracoes;

        private static List<Funcionario> listaFuncionarios = new List<Funcionario>();

        public FuncionarioDA(IConfiguration config)
        {
            _configuracoes = config;
        }

        public IEnumerable<Funcionario> BuscarTodos()
        { 
          if(listaFuncionarios.Count >=1)
            return listaFuncionarios;
          else
            throw new Exception("A lista de funcionários está vazia");
        }


        public Funcionario BuscarPorId(int Id)
        {
            var funcionario = listaFuncionarios.FirstOrDefault((x => x.id == Id));
            if(funcionario != null)
              return funcionario;
            else
              throw new Exception("Funcionário não encontrado");
            
        }

        public bool Excluir(int Id)
        {
          var removido = false;
          foreach (var item in listaFuncionarios)
          {
              if(item.id == Id)
              {
                listaFuncionarios.Remove(item);
                removido = true;
                break;
              }
          } 
          
          return removido;
        }

        public bool Alterar(Funcionario funcionario)
        {
          int index = listaFuncionarios.FindIndex(m => m.id == funcionario.id);
          if(index >= 0){
            funcionario.dataAtualizacao = DateTime.Now;
            listaFuncionarios[index] = funcionario;
            return true;
          }else{
            return false;
          }
        }

        public Funcionario Adicionar(Funcionario funcionario)
        {
           funcionario.id = listaFuncionarios.Count + 1;
           funcionario.dataCriacao = DateTime.Now;
           listaFuncionarios.Add(funcionario);
           return funcionario;
        }
    }
}
