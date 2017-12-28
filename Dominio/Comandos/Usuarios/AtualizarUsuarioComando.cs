using Flunt.Notifications;
using Despensa.Compartilhados.Comandos;
using Flunt.Validations;

namespace Dominio.Comandos.Usuarios
{
    public class AtualizarUsuarioComando : Notifiable, IComando
    {
        public string Login { get; set; }
        public string Email { get; set; }

        public void ValidarComando()
        {
            AddNotifications(new Contract()
             .IsNotNullOrEmpty(Login, "Login", "Login obrigatório")
             .IsEmail(Login, "Login", "Login inválido")
             .IsNotNullOrEmpty(Email, "Email", "Email obrigatório")
             .IsEmail(Email, "Email", "Email inválido"));
        }
    }
}