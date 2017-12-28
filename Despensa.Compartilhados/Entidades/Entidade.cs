using Flunt.Notifications;
using MongoDB.Bson;

namespace Despensa.Compartilhados.Entidades
{
    public abstract class Entidade:Notifiable
    {
        public Entidade()
        {
           
        }

        public ObjectId  Id { get; private set; }

        protected abstract void Validar();
    }
}