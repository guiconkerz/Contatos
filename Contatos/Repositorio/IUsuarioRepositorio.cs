using Contatos.Models;

namespace Contatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarUsuario(string login);
        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Remover(int id);
    }
}
