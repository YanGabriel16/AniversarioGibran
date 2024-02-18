namespace AniversarioGibran;
public class Mensagem(string remetenteNome, string texto)
{
    public string RemetenteNome { get; private set; } = remetenteNome;
    public string Texto { get; private set; } = texto;
}