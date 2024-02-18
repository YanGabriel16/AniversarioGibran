namespace AniversarioGibran;

public static class Utils
{
    public static readonly int WindowWidth = Console.WindowWidth;
    public static List<Mensagem> ObterMensagensAniversario()
        => [
            new("Alencar", "Parabéns, Gibran. \nMuitas felicidades, paz, bençãos e realizações."),

            new("Bote", "Feliz aniversário Gibran, te desejo muito sucesso, saúde e felicidade."),

            new("Carlos", "Feliz aniversário professor, tudo de bom pra ti."),

            new("Fer", "Feliz aniversário, Gibran! \nDesejo tudo de bom para você, feliz vida!"),

            new("Gih", "Feliz aniversário, Gibran! Que este dia seja celebrado com alegria e cercado de boas energias. \nDesejo-lhe todo o sucesso e felicidade neste novo ciclo que se inicia. Parabéns!"),

            new("Gil", "Eae meu caro, mais um ano aqui contigo, vim deixar um parabéns pra ti, como pessoa, como profissional e como mentor, obrigado por tudo. \nEspero que aproveite bem seu dia, você merece"),

            new("Guh", "Fala meu! espero que tu consiga curtir muito o teu dia! \nVocê merece só do bom e do melhor. Tmj!"),

            new("Molina", "Feliz aniversário! Deus abençoe e desejo muita saúde e felicidades!"),

            new("Nana", "Feliz aniversario! Que Deus te abençoes muito Gibran!"),

            new("Pedro", "Feliz aniversário Gibran! Tudo de bom pra você hoje e sempre. \nMuito obrigado por todos os ensinamentos. Aproveite muito o seu dia =D"),

            new("Thigas", "Feliz aniversário chefe."),

            new("Tiago", ""),

            new("Yan", "Feliz aniversário Gibran! Tudo de bom, felicidades!! obg por todos os conselhos e ensinamentos, pd conta cmg sempre!"),

            new("Wences", "Feliz aniversário professor!! Muita saúde e felicidade 🥳, que Deus abençoe você e toda sua família 🙏"),
        ];

    public static void MostrarMensagem(Mensagem mensagem)
    {
        WriteSeparator();
        Console.WriteLine();
        Console.WriteLine($"{mensagem.RemetenteNome}: {mensagem.Texto}");
        Console.WriteLine();
    }

    public static void WriteSeparator() => Console.WriteLine(new string('-', WindowWidth));
}