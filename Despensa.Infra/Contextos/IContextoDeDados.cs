namespace Despensa.Infra.Contextos
{
    public interface IContextoDeDados
    {
        string RetornarStringDeConexao();
        void AbrirConexaoComBancoDados();
        //void DesconectarComBancoDados();
    }
}