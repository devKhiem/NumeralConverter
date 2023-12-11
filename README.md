# Numeral Converter
Convert decimal to other numeral system and vice versa.
Able to use custom numeral system.
## Usage
```
//ex 1

ReadOnlyCollection<char> binary = NumeralSystem.Binary.ToList().AsReadOnly(); //cache
string s1 = NumeralConverter.Convert(1234, binary); //10011010010
BigInteger n1 = NumeralConverter.Convert("10011010010", binary); //1234


//ex 2

List<char> hexatrigesimal = new();

foreach(int i in Enumerable.Range(0, 10))
{
    hexatrigesimal.Add(i.ToString()[0]);
}

for (char c = 'A'; c <= 'Z'; c++)
{
    hexatrigesimal.Add(c);
}

string s2 = NumeralConverter.Convert(9999, hexatrigesimal); //7PR
BigInteger n2 = NumeralConverter.Convert("7PR", hexatrigesimal.ToList()); //9999
```
## Note
Don't use negative number.
Array item or List item must not be duplicated.
When converting a string sequence to decimal number, the letters in the string must exist in the array.