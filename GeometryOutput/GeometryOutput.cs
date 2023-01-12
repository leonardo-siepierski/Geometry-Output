namespace Geometry_Output;

public class GeometryOutput
{
    public static void AskForLetter()
    {
        char letter;
        do
        {
            Console.Write("Escolha uma letra: ");
            string? input = Console.ReadLine();

            if(!char.TryParse(input, out letter))   
                Console.WriteLine("Por favor, selecione uma letra");
            else
                letter = char.ToUpper(letter);

            if (letter < 'C')
                Console.WriteLine("Por favor, selecione a letra \"C\" ou maior");
        } while (letter < 'C');

        GenerateDiamond(letter);
    }

    public static string GenerateDiamond(char letter)
    {
        int lines = (letter - 'A') * 2 + 1;
        var output = new StringWriter();

        for (int i = 0; i <= letter - 'A'; i++)
        {
            for (int j = 0; j < lines; j++)
            {
                int mid = lines / 2;
                int left = mid - i;
                int right = mid + i;

                if (j >= left && j <= right)
                {
                    if (i == 0)
                    {
                        Console.Write('A');
                        output.Write('A');
                    }
                    else if (j == left)
                    {
                        Console.Write((char)('A' + i));
                        output.Write((char)('A' + i));
                    }
                    else if (j == right)
                    {
                        Console.Write((char)('A' + i));
                        output.Write((char)('A' + i));
                    }
                    else
                    {
                        Console.Write(" ");
                        output.Write(" ");
                    }
                }
                else
                {
                    Console.Write(" ");
                    output.Write(" ");
                }
            }
            Console.WriteLine();
        }

        for (int i = letter - 'A' - 1; i >= 0; i--)
        {
            for (int j = 0; j < lines; j++)
            {
                int mid = lines / 2;
                int left = mid - i;
                int right = mid + i;

                if (j >= left && j <= right)
                {
                    if (i == 0)
                    {
                        Console.Write('A');
                        output.Write('A');
                    }
                    else if (j == left)
                    {
                        Console.Write((char)('A' + i));
                        output.Write((char)('A' + i));
                    }
                    else if (j == right)
                    {
                        Console.Write((char)('A' + i));
                        output.Write((char)('A' + i));
                    }
                    else
                    {
                        Console.Write(" ");
                        output.Write(" ");
                    }
                }
                else
                {
                    Console.Write(" ");
                    output.Write(" ");
                }
            }
            Console.WriteLine();
            output.WriteLine();
        }
        return output.ToString();
    }

    public static void SendEmail(string? email)
    {
        Console.WriteLine("Email enviado para " + email);
    }
}