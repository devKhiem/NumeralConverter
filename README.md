# Numeral Converter
Convert decimal to other numeral system and vice versa.
Able to use custom numeral system.
## Usage
```
//ex 1
string s1 = NumeralConverter.Convert(1234, NumeralConverter.NumeralSystem.Binary); //10011010010
BigInteger n1 = NumeralConverter.Convert("10011010010", NumeralConverter.NumeralSystem.Binary); //1234


//ex 2
IEnumerable<char> hexatrigesimalGenerator()
{
    for (int i = 0; i <= 9; i++)
    {
        yield return i.ToString()[0];
    }
    for (char c = 'A'; c <= 'Z'; c++)
    {
        yield return c;
    }
}

IEnumerable<char> hexatrigesimal = hexatrigesimalGenerator();

string s2 = NumeralConverter.Convert(9999, hexatrigesimal); //7PR
BigInteger n2 = NumeralConverter.Convert("7PR", hexatrigesimal.ToList()); //9999
```
## Note
Don't use negative number.
Array item or List item must not be duplicated.
When converting a string sequence to decimal number, the letters in the string must exist in the array.