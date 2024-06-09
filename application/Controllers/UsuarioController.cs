using firstApi.domain.Models;
using firstApi.infrastructure.Repositorios.interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace firstApi.application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio repositorio;
        public UsuarioController(IUsuarioRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<List<UsuarioModel>> findUsers()
        {
            return await repositorio.FindUsuarios();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<UsuarioModel> findUser(int id)
        {
            return await repositorio.FindUsuario(id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public async Task<UsuarioModel> Post([FromBody] UsuarioModel usuario)
        {
            return await repositorio.AdicionarUsuario(usuario);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
