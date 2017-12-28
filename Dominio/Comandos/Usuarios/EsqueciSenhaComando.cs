using Despensa.Compartilhados.Comandos;
using Flunt.Notifications;
using Flunt.Validations;

namespace Dominio.Comandos.Usuarios
{
    public class EsqueciSenhaComando : Notifiable, IComando
    {
        public string Login { get; set; }
        public string Codigo { get; set; }

        public void ValidarComando()
        {
            AddNotifications(new Contract()
              .IsNotNullOrEmpty(Login, "Login", "Login inválido")
               .IsEmail(Login, "Login", "Login inválidos"));
        }
    }
}
