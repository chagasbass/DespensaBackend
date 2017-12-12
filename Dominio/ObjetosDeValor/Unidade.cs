using Despensa.Compartilhados.ObjetosDeValor;
using Flunt.Validations;

namespace Dominio.ObjetosDeValor
{
    public class Unidade:ObjetoDeValor
    {
        public Unidade(string valor)
        {
            Valor = valor;

            AddNotifications(new Contract()
                .IsNullOrEmpty(Valor, "Valor", "A medida do item é inválida"));
        }

        public string Valor { get; private set; }
    }
}