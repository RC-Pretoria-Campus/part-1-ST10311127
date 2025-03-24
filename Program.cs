using System;
using System.Speech.Synthesis;
using System.Threading.Tasks;

class Program
{
    private static SpeechSynthesizer synthesizer = new SpeechSynthesizer();
    private static string userName;

    static async Task Main()
    {
        // Initialize the SpeechSynthesizer
        synthesizer.SelectVoice("Microsoft David Desktop");
        synthesizer.Rate = 1;

        // Asynchronously speak the text
        await SpeakAsync("Hey there! Welcome to the Cybersecurity Awareness Bot. I'm Kenneth, here to help you stay safe online. Can you please tell me your name?");

        DisplayASCIIArt();
        await InteractWithUser();
    }

    static void DisplayASCIIArt()
    {
        string asciiArt = @"
_______ _____ ____ _ _ ______ _ _
|__ __|/ ____| / __ \| \ | |/ ____| \ | |
| | | (___ | | | | \| | (___ | \| |
| | \___ \ | | | | . ` |\___ \| . ` |
| | ____) | | |__| | |\ | ____) | |\ |
|_| |_____/ \____/|_| \_|_____/|_| \_|
";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(asciiArt);
        Console.ResetColor();
    }

    static async Task InteractWithUser()
    {
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();

        if (!string.IsNullOrEmpty(userName))
        {
            Console.WriteLine($"Hello, {userName}!");
        }
        else
        {
            Console.WriteLine("Sorry, I didn't catch your name.");
        }
    }

    static async Task SpeakAsync(string message)
    {
        await Task.Run(() => synthesizer.SpeakAsync(message));
    }
}
