using iTextSharp.text;
using iTextSharp.text.pdf;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Geometry_Output;

public class GeometryOutput
{
    public static string? Diamond { get; set; }
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

    public static void GenerateDiamond(char letter)
    {
        int lines = (letter - 'A') * 2 + 1;

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
                        Diamond += 'A';
                    }
                    else if (j == left)
                    {
                        Console.Write((char)('A' + i));
                        Diamond += (char)('A' + i);
                    }
                    else if (j == right)
                    {
                        Console.Write((char)('A' + i));
                        Diamond += (char)('A' + i);
                    }
                    else
                    {
                        Console.Write(" ");
                        Diamond += "  ";
                    }
                }
                else
                {
                    Console.Write(" ");
                    Diamond += "  ";
                }
            }
            Console.WriteLine();
            Diamond += "\n";
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
                        Diamond += 'A';
                    }
                    else if (j == left)
                    {
                        Console.Write((char)('A' + i));
                        Diamond += (char)('A' + i);
                    }
                    else if (j == right)
                    {
                        Console.Write((char)('A' + i));
                        Diamond += (char)('A' + i);
                    }
                    else
                    {
                        Console.Write(" ");
                        Diamond += "  ";
                    }
                }
                else
                {
                    Console.Write(" ");
                    Diamond += "  ";
                }
            }
            Console.WriteLine();
            Diamond += "\n";
        }
    }

    public async static Task SendEmail(string? email)
    {
        string apiKey = Keys.ApiKey;
        var client = new SendGridClient(apiKey);  
        var senderEmail = new EmailAddress("leonardo.siepierski@gmail.com"); 

        var receiverEmail = new EmailAddress(email);  
        string emailSubject = "Diamante";
        string? textContent = Diamond;
        string htmlContent = "";

        var msg = MailHelper.CreateSingleEmail(senderEmail, receiverEmail, emailSubject, textContent, htmlContent);
        await client.SendEmailAsync(msg);

        Console.WriteLine($"\nEmail enviado para {email}!\nPressione qualquer tecla para sair");
        Console.ReadKey();
    }

    public static void GeneratePdf()
    {
        using var fileStream = new FileStream("Diamond.pdf", FileMode.Create);
        using var document = new Document();

        PdfWriter.GetInstance(document, fileStream);
        document.Open();

        var diamondContent = new Paragraph(Diamond);
        document.Add(diamondContent);
    }
}