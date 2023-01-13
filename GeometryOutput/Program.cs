namespace Geometry_Output;

public class Program
{
    public async static Task Main()
    {
        string? input;
        GeometryOutput.AskForLetter();

        GeometryOutput.GeneratePdf();
        do
        {
            Console.Write("Você deseja receber um email com o resultado? (S/N): ");
            input = Console.ReadLine();

            if(input == "S")
            {
                Console.Write("Digite seu endereço de email: ");
                string? email = Console.ReadLine();

                await GeometryOutput.SendEmail(email);
            }

            else if (input == "N")
            {
                Console.WriteLine("\nObrigado por utilizar o programa!\nDigite qualquer tecla para sair");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Por favor, digite S ou N");
                
            }
        } while (input != "S" && input != "N");
    }
}
