using Despensa.Compartilhados.ObjetosDeValor;
using Flunt.Validations;

namespace Dominio.ObjetosDeValor
{
    public class Nome:ObjetoDeValor
    {
        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;

            AddNotifications(new Contract()
               .IsNotNullOrEmpty(PrimeiroNome, "Nome", "Nome inválido")
               .IsNotNullOrEmpty(Sobrenome, "Sobrenome", "Nome inválido"));
        }

        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
    }
}
