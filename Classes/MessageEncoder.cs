using System;

namespace encoder_decoder.Classes
{
    public static class MessageEncoder
    {
        public static string Encode(string encoderInput)
        {
            string encoded = string.Empty; // initialiserar encoded med ett tomt värde

            foreach (char character in encoderInput) // loopar igenom varje tecken (char) i stringen encoderInput
            {
                encoded += char.ToUpper(character) switch // byter ut valda tecken och hoppar över resten // se klassen MessageDecoder för en alternativ lösning
                {
                    'A' => '@',
                    'E' => '3',
                    'I' => '!',
                    'O' => '0',
                    'S' => "$",
                    _ => character,
                };
            }
            return encoded; // encoded är den string som "lämnar" metoden och blir tillgänglig att använda i huvudprogrammet
        }
    }
}
