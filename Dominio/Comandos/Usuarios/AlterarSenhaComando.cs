using Despensa.Compartilhados.Comandos;
using Flunt.Notifications;
using Flunt.Validations;

namespace Dominio.Comandos.Usuarios
{
    public class AlterarSenhaComando : Notifiable, IComando
    {
        public string Login { get; set; }
        public string NovaSenha { get; set; }
        public string ConfirmacaoDeSenha { get; set; }

        public void ValidarComando()
        {
            AddNotifications(new Contract()
             .IsNotNullOrEmpty(Login, "Login", "Login inválido")
             .IsEmail(Login,"Login","Login inválido")
             .IsNotNullOrEmpty(NovaSenha, "NovaSenha", "Nova senha inválida")
             .IsLowerThan(3, NovaSenha.Length, "Nova Senha", "A nova Senha  deve conter mais que 3 caracteres")
             .IsNotNullOrEmpty(ConfirmacaoDeSenha, "ConfirmacaoDeSenha", "Confirmação de senha inválida")
             .IsLowerThan(3, NovaSenha.Length, "ConfirmacaoDeSenha", "A confirmação de senha  deve conter mais que 3 caracteres")
             .AreNotEquals(NovaSenha, ConfirmacaoDeSenha, "Senha", "As senhas devem ser iguais"));
        }
    }
}