using Despensa.Compartilhados.Comandos;
using Flunt.Notifications;
using Flunt.Validations;

namespace Dominio.Comandos.Usuarios
{
    /// <summary>
    /// Comando de login de usuário
    /// </summary>
    public class LoginComando : Notifiable, IComando
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public void ValidarComando()
        {
            AddNotifications(new Contract()
           .IsEmailOrEmpty(Login, "Login", "Login ou senha inválidos")
           .IsNotNullOrEmpty(Senha, "Senha", "Login ou senha inválidos"));
        }
    }
}