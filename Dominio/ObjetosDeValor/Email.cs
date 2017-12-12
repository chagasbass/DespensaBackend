using Despensa.Compartilhados.ObjetosDeValor;
using Flunt.Validations;

namespace Dominio.ObjetosDeValor
{
    public class Email:ObjetoDeValor
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            AddNotifications(new Contract()
                .IsEmail(Endereco, "Email", "Email inválido"));
        }

        public string Endereco { get; private set; }
    }
}