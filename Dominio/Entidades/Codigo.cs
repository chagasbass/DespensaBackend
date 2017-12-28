using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace Dominio.Entidades
{
    public class Codigo:Notifiable
    {
        public Codigo(string idUsuario)
        {
            IdUsuario = idUsuario;
            CodigoGerado = GerarCodigo();
        }

        public string IdUsuario { get; private set; }
        public string CodigoGerado { get; private set; }

        public void Validar()
        {
            AddNotifications(new Contract()
                .IsNullOrEmpty(IdUsuario, "usuario", "O usuário é inválido"));
        }

        private string GerarCodigo()
        {
            return Guid.NewGuid().ToString().Substring(0, 6).Replace('-', ' ');
        }
    }
}