namespace AniversarioGibran;
public class Program
{
    static void Main() => Utils.ObterMensagensAniversario().ForEach(Utils.MostrarMensagem);
}
