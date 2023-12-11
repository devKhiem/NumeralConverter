using System.Numerics;

namespace khiemnguyen.dev.utility
{
    public static class NumeralConverter
    {
        public static string Convert(BigInteger input, IEnumerable<char> numeralSystem)
        {
            Stack<char> stack = new();

            BigInteger count = numeralSystem.GetCount();

            do
            {
                input = BigInteger.DivRem(input, count, out BigInteger remainder);

                stack.Push(numeralSystem.GetElementAt(remainder));
            }
            while (input != 0);

            return string.Join(null, stack);
        }
        public static BigInteger Convert(string input, IEnumerable<char> numeralSystem)
        {
            BigInteger result = 0;

            BigInteger count = numeralSystem.GetCount();

            for (int i = 0; i < input.Length; ++i)
            {
                result += BigInteger.Pow(count, input.Length - i - 1) * numeralSystem.GetIndex(input[i]);
            }

            return result;
        }

        private static T? GetElementAt<T>(this IEnumerable<T?> enumerable, BigInteger index)
        {
            if (enumerable.TryGetNonEnumeratedCount(out int _))
            {
                if (index <= int.MaxValue)
                {
                    return enumerable.ElementAt((int)index);
                }
            }
            else
            {
                BigInteger i = -1;

                foreach (T? t in enumerable)
                {
                    if (++i == index)
                    {
                        return t;
                    }
                }
            }

            throw new ArgumentOutOfRangeException($"Can not find item with index '{index}'");
        }
        private static BigInteger GetCount<T>(this IEnumerable<T?> enumerable)
        {
            {
                if (enumerable.TryGetNonEnumeratedCount(out int count))
                {
                    return count;
                }
            }

            {
                BigInteger count = 0;

                foreach (T? _ in enumerable)
                {
                    ++count;
                }

                return count;
            }
        }
        private static BigInteger GetIndex<T>(this IEnumerable<T?> enumerable, T? value)
        {
            BigInteger i = -1;

            foreach (T? t in enumerable)
            {
                ++i;

                if (t is null ^ value is null)
                {
                    continue;
                }

                if (t is null && value is null)
                {
                    return i;
                }

                if (t!.Equals(value))
                {
                    return i;
                }
            }

            throw new ArgumentOutOfRangeException($"Can not find item with value '{value}'");
        }
    }
}