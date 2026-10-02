using System;

namespace encoder_decoder.Classes
{
    public static class MessageDecoder
    {
        public static string Decode(string decoderInput)
        {
            string decoded = string.Empty;

            foreach (char character in decoderInput)
            {
                switch (char.ToUpper(character))
                {
                    default:
                        decoded += character;
                        break;

                    case '@':
                        decoded += 'A';
                        break;

                    case '3':
                        decoded += 'E';
                        break;

                    case '!':
                        decoded += 'I';
                        break;

                    case '0':
                        decoded += 'O';
                        break;

                    case '$':
                        decoded += "S";
                        break;
                }
            }
            return decoded;
        }
    }
}
