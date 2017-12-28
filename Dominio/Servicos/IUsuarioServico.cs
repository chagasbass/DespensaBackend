using Dominio.Comandos.Usuarios;
using Dominio.Entidades;

namespace Dominio.Servicos
{
    public interface IUsuarioServico
    {
        Usuario CadastrarUsuario(NovoUsuarioComando usuario);
        Usuario AlterarUsuario(AtualizarUsuarioComando usuario);
        Usuario ListarUsuario(string email);
    }
}