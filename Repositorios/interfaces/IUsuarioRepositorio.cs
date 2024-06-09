using primeiraApi.Models;

namespace primeiraApi.Repositorios.interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> FindUsuarios();
        Task<UsuarioModel> FindUsuario(int id); 
        Task<UsuarioModel> AdicionarUsuario(UsuarioModel usuario);
        Task<UsuarioModel> EditarUsuario(UsuarioModel usuario, int id);
        Task<string> DeletarUsuario(int id);
    }
}
