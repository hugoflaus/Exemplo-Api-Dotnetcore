using System;
using System.Collections.Generic;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private IConfiguration _config;
        public FuncionarioController([FromServices]IConfiguration Config)
        {
            this._config = Config;
        }
        // GET api/values
        [Produces("application/json")]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {   
                return  Ok(new FuncionarioDA(this._config).BuscarTodos());
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { error = ex.Message});
            }
        
        }

        // GET api/values/5
        [Produces("application/json")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {   
               return  Ok(new FuncionarioDA(this._config).BuscarPorId(id));
            }
            catch (System.Exception ex)
            {
               return BadRequest(new { error = ex.Message});
            }
        }

        // POST api/values
        [Produces("application/json")]
        [HttpPost]
        public IActionResult Post([FromBody] Funcionario funcionario)
        {
            try
            {   
               return  Ok(new FuncionarioDA(this._config).Adicionar(funcionario));
            }
            catch (System.Exception ex)
            {
               return BadRequest(new { error = ex.Message});
            }
        }

        // PUT api/values/5
        [Produces("application/json")]
        [HttpPut()]
        public IActionResult Put([FromBody] Funcionario funcionario)
        {
            try
            {   
                if(new FuncionarioDA(this._config).Alterar(funcionario)){
                    return Ok(funcionario);
                }else{
                    return BadRequest(new { error = "Funcionário não encontrado"});
                }
            }
            catch (System.Exception ex)
            {
               return BadRequest(new { error = ex.Message});
            }
            
        }

        // DELETE api/values/5
        [Produces("application/json")]
        [HttpDelete("{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {   
                if(new FuncionarioDA(this._config).Excluir(id)){
                    return Ok("Funcionário excluido com Sucesso");
                }else{
                    return BadRequest(new { error = "Funcionário não encontrado"});
                }
            }
            catch (System.Exception ex)
            {
               return BadRequest(new { error = ex.Message});
            }
           
        }
    }
}
