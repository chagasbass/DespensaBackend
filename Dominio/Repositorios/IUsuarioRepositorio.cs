using Dominio.Entidades;

namespace Dominio.Repositorios
{
    public interface IUsuarioRepositorio
    {
        Usuario CadastrarUsuario(Usuario usuario);
        Usuario AlterarUsuario(Usuario usuario);
        Usuario ListarUsuario(string email);
    }
}