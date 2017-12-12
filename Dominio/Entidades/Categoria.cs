using Despensa.Compartilhados.Entidades;
using Flunt.Validations;
using System;

namespace Dominio.Entidades
{
    /// <summary>
    /// Entidade Categoria
    /// </summary>
    public class Categoria : Entidade
    {
        public Categoria(string nome) : base()
        {
            Nome = nome;
            DataCadastro = DateTime.Now;

            Validar();
        }

        public string Nome { get; private set; }
        public string Imagem { get; private set; }
        public DateTime DataCadastro { get; private set; }

        #region Métodos

        public void AlterarNome(string nome, string imagem)
        {
            Nome = nome;
            Imagem = imagem;

            AddNotifications(new Contract()
                .IsNullOrEmpty(Nome, "Nome", "o nome é inválido")
                .IsLowerThan(4, Nome.Length, "Nome", "O nome da categoria deve ter mais que 4 caracteres"));

        }

        protected override void Validar() => AddNotifications(new Contract()
               .IsNullOrEmpty(Nome, "Nome", "O nome da categoria é obrigatório")
            .IsLowerThan(4, Nome.Length, "Nome", "O nome da categoria deve ter mais que 4 caracteres"));

        #endregion

    }
}