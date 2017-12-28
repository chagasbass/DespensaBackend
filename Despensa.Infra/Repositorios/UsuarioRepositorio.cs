using Despensa.Infra.Contextos;
using Dominio.Entidades;
using Dominio.Repositorios;
using System;
using System.Threading.Tasks;

namespace Despensa.Infra.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        readonly DespensaContexto Contexto;

        public UsuarioRepositorio(DespensaContexto _Contexto)
        {
            Contexto = _Contexto;
        }

        public Usuario AlterarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario CadastrarUsuario(Usuario usuario)
        {
            //var usuarios = Contexto.Banco.GetCollection<Usuario>("usuarios");
            //await usuarios.InsertOneAsync(usuario);

            //var resultado = usuario.Id;

            //return usuario;

            throw new NotImplementedException();
        }

        public Usuario ListarUsuario(string email)
        {
            throw new  NotImplementedException();
            
        }
    }
}
