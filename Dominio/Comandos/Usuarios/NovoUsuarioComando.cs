using Despensa.Compartilhados.Comandos;
using Flunt.Notifications;
using Flunt.Validations;

namespace Dominio.Comandos.Usuarios
{
    /// <summary>
    /// Comando para criação de novo usuário
    /// </summary>
    public class NovoUsuarioComando : Notifiable, IComando
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public void ValidarComando()
        {
            AddNotifications(new Contract()
            .IsNotNullOrEmpty(Nome, "Nome", "Nome inválido")
            .IsNotNullOrEmpty(Sobrenome, "Sobrenome", "Nome inválido")
            .IsLowerThan(3, Nome.Length, "Nome", "O nome  deve conter mais que 3 caracteres")
            .IsLowerThan(3, Sobrenome.Length, "Sobrenome", "O nome  deve conter mais que 3 caracteres")
            .IsEmailOrEmpty(Email, "Email", "E-mail inválido")
            .IsNotNullOrEmpty(Senha, "Senha", "Login ou senha inválidos")
             .IsLowerThan(3, Senha.Length, "Senha", "A senha deve conter mais que 3 caracteres"));
        }
    }
}