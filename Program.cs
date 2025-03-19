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

        
        await SpeakAsync("Hey there! Welcome to the Cybersecurity Awareness Bot. I'm Kenneth, here to help you stay safe online. Can you please tell me your name?");

        DisplayASCIIArt();
    }

    static void DisplayASCIIArt()
    {
        string asciiArt = @"
       _______  _____    ____  _   _  ______ _   _ 
        |__   __|/ ____|  / __ \| \ | |/ ____| \ | |
           | |  | (___   | |  | |  \| | (___ |  \| |
           | |   \___ \  | |  | | . ` |\___ \| . ` |
           | |   ____) | | |__| | |\  | ____) | |\  |
           |_|  |_____/   \____/|_| \_|_____/|_| \_|
       ";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(asciiArt);
        Console.ResetColor();
    }

    static async Task SpeakAsync(string message)
    {
        await Task.Run(() => synthesizer.SpeakAsync(message));
    }
}
