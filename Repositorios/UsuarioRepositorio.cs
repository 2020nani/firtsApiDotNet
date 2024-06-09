using Microsoft.EntityFrameworkCore;
using primeiraApi.Data;
using primeiraApi.Models;
using primeiraApi.Repositorios.interfaces;

namespace primeiraApi.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefasDBContext _dBContext;
        public UsuarioRepositorio(SistemaTarefasDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<UsuarioModel> AdicionarUsuario(UsuarioModel usuario)
        {
            await _dBContext.Usuarios.AddAsync(usuario);
            _dBContext.SaveChanges();
            return usuario;
        }

        public async Task<string> DeletarUsuario(int id)
        {
            UsuarioModel usuarioAtual = await FindUsuario(id);
            if (usuarioAtual == null)
            {
                throw new Exception($"Usuario com id: {id} nao encontrado");
            };
            _dBContext.Remove(usuarioAtual);
            var msg = "Usuario apagado com sucesso";
            return msg;
        }

        public async Task<UsuarioModel> FindUsuario(int id)
        {
            return await _dBContext.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<UsuarioModel>> FindUsuarios()
        {
            return await _dBContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> EditarUsuario(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioAtual = await FindUsuario(id);
            if (usuarioAtual == null) {
                throw new Exception($"Usuario com id: {id} nao encontrado");
            };
            usuarioAtual.Nome = usuario.Nome;
            usuarioAtual.Email = usuario.Email;
            _dBContext.Usuarios.Update(usuarioAtual);
            await _dBContext.SaveChangesAsync();
            return usuarioAtual;
        }
    }
}
