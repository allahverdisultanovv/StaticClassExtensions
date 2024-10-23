namespace StaticClassHelperExtensions
{
    public static class Helper
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool HasDigit(this string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsDigit(word[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckPassword(this string password)
        {
            bool lowerLetter = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'a' && password[i] <= 'z')
                {
                    lowerLetter = true;
                    break;
                }
            }
            if (!lowerLetter)
            {
                Console.WriteLine("en azi 1 kicik herf olmalidir");
                return false;
            }
            bool upperLetter = false;
            for (int i = 0; i < password.Length; i++)
            {

                if (password[i] >= 'A' && password[i] <= 'Z')
                {
                    upperLetter = true;
                    break;
                }

            }
            if (!upperLetter)
            {
                Console.WriteLine("en azi 1 boyuk herf olmalidir");
                return false;
            }
            if (!(password.Length >= 8))
            {
                Console.WriteLine("uzunluq en azi 8 olmalidir");
                return false;
            }
            bool checkDigit = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    checkDigit = true;
                    break;
                }

            }
            if (!checkDigit)
            {
                Console.WriteLine("en azi 1 reqem olmalidir!");
                return false;
            }

            return true;

        }
    }
}
