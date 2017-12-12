using Despensa.Compartilhados.Entidades;
using Dominio.Enums;
using Dominio.ObjetosDeValor;
using Flunt.Validations;
using System;

namespace Dominio.Entidades
{
    public class Item : Entidade
    {
        public Item(Categoria categoria, string nome, string marca, int quantidade, Unidade unidade, EStatusItem status, string imagem, DateTime dataValidade)
        {
            Categoria = categoria;
            Nome = nome;
            Marca = marca;
            Quantidade = quantidade;
            Unidade = unidade;
            Status = status;
            Imagem = imagem;
            DataValidade = dataValidade;
            DataDeCompra = DateTime.Now;
            DataCadastro = DateTime.Now;

            Validar();
        }

        public Categoria Categoria { get; private set; }
        public string Nome { get; private set; }
        public string Marca { get; private set; }
        public int Quantidade { get; private set; }
        public Unidade Unidade { get; private set; }
        public EStatusItem Status { get; private set; }
        public string Imagem { get; private set; }
        public DateTime DataValidade { get; private set; }
        public DateTime DataDeCompra { get; private set; }
        public DateTime DataCadastro { get; private set; }

        #region métodos

        public void AlterarCategoria(Categoria categoria)
        {
            Categoria = categoria;

            AddNotifications(Categoria);
        }
        public void AlterarNome(string nome)
        {
            Nome = nome;

            AddNotifications(new Contract()
                .IsNullOrEmpty(Nome, "Nome", "O nome do item é obrigatório")
                .IsLowerThan(4, Nome.Length, "Nome", "O nome do item deve ter mais que 4 caracteres"));
        }
        public void AlterarMarca(string marca)
        {
            Marca = marca;

            AddNotifications(new Contract()
                .IsNullOrEmpty(Marca, "Marca", "A marca do item é obrigatória")
                .IsLowerThan(2, Marca.Length, "Marca", "A marca do item deve ter mais que 2 caracteres"));
        }
        public void AlterarQuantidade(int quantidade)
        {
            Quantidade = quantidade;

            AddNotifications(new Contract()
                 .IsLowerOrEqualsThan(0, Quantidade, "Quantidade", "A quantidade deve ser maior que zero"));
        }

        public void AlterarStatus(EStatusItem status) => Status = status;
        public void AlterarImagem(string imagem) => Imagem = imagem;
        public void AlterarUnidade(Unidade unidade) => Unidade = unidade;

        protected override void Validar()
        {
            AddNotifications(Categoria);
            AddNotifications(Unidade);
            AddNotifications(new Contract()
                .IsNullOrEmpty(Nome, "Nome", "O nome do item é obrigatório")
                .IsLowerThan(4, Nome.Length, "Nome", "O nome do item deve ter mais que 4 caracteres")
                .IsNullOrEmpty(Marca, "Marca", "A marca do item é obrigatória")
                .IsLowerThan(2, Marca.Length, "marca", "A marca do item deve ter mais que 2 caracteres")
                .IsLowerOrEqualsThan(0, Quantidade, "Quantidade", "A quantidade deve ser maior que zero"));
        }

        #endregion
    }
}