using MongoDB.Driver;
using System.Configuration;

namespace Despensa.Infra.Contextos
{
    public class DespensaContexto : IContextoDeDados
    {
        MongoClient Cliente;
        public IMongoDatabase Banco;
        const string NomeBanco = "DespensaDb";

        public DespensaContexto()
        {
            AbrirConexaoComBancoDados();
        }

        public void AbrirConexaoComBancoDados()
        {
            Cliente = new MongoClient(RetornarStringDeConexao());
            Banco = Cliente.GetDatabase(NomeBanco);
        }

        public string RetornarStringDeConexao()
        {
            return ConfigurationManager.ConnectionStrings["conexaoMongoDB"].ConnectionString;
        }
    }
}