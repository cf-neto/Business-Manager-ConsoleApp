namespace BusinessManager.Interfaces
{
    public interface IFuncionarioService
    {
        void AdicionarFuncionario();
        void ListarFuncionario();
        void RemoverFuncionario(string nome = null);
        void ExibirInformacoes(string nome = null);
        void PagarFuncionario(string nome = null);
    }
}
