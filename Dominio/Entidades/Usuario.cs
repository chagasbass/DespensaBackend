using Despensa.Compartilhados.Entidades;
using Dominio.ObjetosDeValor;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominio.Entidades
{
    public class Usuario:Entidade
    {
        public Usuario(Nome  nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;

            Validar();
        }

        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public IReadOnlyCollection<Item> Items { get; private set; }
        private IList<Item> _Items { get { return Items.ToArray(); } }

        protected override void Validar()
        {
            AddNotifications(Email);
            AddNotifications(Nome);
            AddNotifications(new Contract()
                .IsNullOrEmpty(Senha, "Senha", "A senha é obrigatória"));
        }

        #region Métodos

        public void AlterarEmail(Email email)
        {
            Email = email;

            AddNotifications(Email);
        }

        public void AlterarSenha(string senha, string confirmacaoDeSenha)
        {
            Senha = senha;

            AddNotifications(new Contract()
                .IsNullOrEmpty(Senha, "Senha", "A senha deve ser preenchida")
                .IsNullOrEmpty(confirmacaoDeSenha, "confirmacaoDeSenha", "A confirmacao de senha deve ser preenchida")
                .AreNotEquals(Senha, confirmacaoDeSenha, "Erro de confirmacao", "As senhas devem ser iguais"));
        }

        public void InserirItems(Item item)
        {
            AddNotifications(item);

            _Items.Add(item);
        }

        public string GerarCodigoParaTrocaDeSenha()
        {
            return Guid.NewGuid().ToString().Substring(0, 5).Replace('-', ' ');
        }

        #endregion
    }
}