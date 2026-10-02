using System;

namespace encoder_decoder.Classes
{
    public static class InputHelper
    {
        public static string InputValidation(string text)
        {
            while (true)
            {
                Console.Write(text);
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input)) // lägg märke till operatorn ! innan string som betyder INTE
                {
                    return input;
                }

                ErrorMessage("Invalid input. Try again.");
            }
        }

        public static void ErrorMessage(string text) // generiskt felmeddelande med färgformatering
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
