namespace Biblioteca
{
    public interface ILocal
    {
        string ArquivoMidia { get; set; }

        bool validaCaminho(string path);
    }
}
