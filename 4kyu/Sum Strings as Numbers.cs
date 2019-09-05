/*
Difficulty: 4kyu 
URL: https://www.codewars.com/kata/5324945e2ece5e1f32000370
Description: Given the string representations of two integers, return the string representation of the sum of those integers.

For example:

sumStrings('1','2') // => '3'
A string representation of an integer will contain no characters besides the ten numerals "0" to "9".
*/
public string sumStrings(string a, string b)
{
    BigInteger.TryParse(a, out var s1);
    BigInteger.TryParse(b, out var s2);
    return (s1+s2).ToString();
}