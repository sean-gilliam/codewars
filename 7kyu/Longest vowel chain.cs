/*
Difficulty: 7kyu 
URL: https://www.codewars.com/kata/59c5f4e9d751df43cf000035
Description: The vowel substrings in the word codewarriors are o,e,a,io. The longest of these has a length of 2. Given a lowercase string that has alphabetic characters only and no spaces, return the length of the longest vowel substring. Vowels are any of aeiou.

Documentation:
Kata.Solve Method (String)
Returns the length of the greatest continuous vowel substring in a string.

Syntax

public static int Solve(
string str
)
Parameters
str
Type: System.String
The string to be processed.

Return Value
Type: System.Int32
The length of the greatest continuous vowel substring in str, or 0 if str contains no vowels.


Exceptions
Exception	Condition
ArgumentNullException	str is null.

Good luck!

If you like substring Katas, please try:

Non-even substrings

Vowel-consonant lexicon
*/
public int Solve(string str)
{
	if(string.IsNullOrWhiteSpace(str))
		return 0;
		
	 var m = Regex.Matches(str, @"[aeiou]+")
		 .Cast<Match>()
		 .GroupBy(x => x.Value.Length);
		 
	return m.Any() ? m.Max(x => x.Key) : 0;
}
