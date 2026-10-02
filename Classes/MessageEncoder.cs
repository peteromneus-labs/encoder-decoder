using System;

namespace encoder_decoder.Classes
{
    public static class MessageEncoder
    {
        public static string Encode(string encoderInput)
        {
            string encoded = string.Empty;

            foreach (char character in encoderInput)
            {
                switch (char.ToUpper(character))
                {
                    default:
                        encoded += character;
                        break;

                    case 'A':
                        encoded += '@';
                        break;

                    case 'E':
                        encoded += '3';
                        break;

                    case 'I':
                        encoded += '!';
                        break;

                    case 'O':
                        encoded += '0';
                        break;

                    case 'S':
                        encoded += "$";
                        break;
                }
            }
            return encoded;
        }
    }
}
