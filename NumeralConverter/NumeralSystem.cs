namespace khiemnguyen.dev.utility
{
    public static class NumeralSystem
    {
        //[0-1]
        public static readonly IEnumerable<char> Binary;

        //[0-7]
        public static readonly IEnumerable<char> Octal;

        //[0-9]
        public static readonly IEnumerable<char> Decimal;

        //[0-9A-F]
        public static readonly IEnumerable<char> Hexadecimal;

        static NumeralSystem()
        {
            {
                static IEnumerable<char> Generator()
                {
                    foreach (int i in Enumerable.Range(0, 2))
                    {
                        yield return i.ToString()[0];
                    }
                }

                Binary = Generator();
            }

            {
                static IEnumerable<char> Generator()
                {
                    foreach (int i in Enumerable.Range(0, 8))
                    {
                        yield return i.ToString()[0];
                    }
                }

                Octal = Generator();
            }

            {
                static IEnumerable<char> Generator()
                {
                    foreach (int i in Enumerable.Range(0, 10))
                    {
                        yield return i.ToString()[0];
                    }
                }

                Decimal = Generator();
            }

            {
                static IEnumerable<char> Generator()
                {
                    foreach (int i in Enumerable.Range(0, 10))
                    {
                        yield return i.ToString()[0];
                    }
                    for (char c = 'A'; c <= 'F'; c++)
                    {
                        yield return c;
                    }
                }

                Hexadecimal = Generator();
            }
        }
    }
}