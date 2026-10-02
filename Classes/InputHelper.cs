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

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }

                ErrorMessage("Try again!");
            }
        }

        public static void ErrorMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
