namespace Geometry_Output;

public class Program
{
    public static void Main(string[] args)
    {
        GeometryOutput.AskForLetter();
        Console.Write("Você deseja receber um email com o resultado? (S/N): ");
        var input = Console.ReadLine();

        if(input == "S")
        {
            Console.Write("Digite seu endereço de email: ");
            string? email = Console.ReadLine();

            GeometryOutput.SendEmail(email);
        }
    }
}
