using Flunt.Notifications;
using System;

namespace Despensa.Compartilhados.Entidades
{
    public abstract class Entidade:Notifiable
    {
        public Entidade()
        {
            Id = Guid.NewGuid();
        }

        public Guid  Id { get; private set; }

        protected abstract void Validar();

    }
}