/*
Difficulty: 6kyu 
URL: https://www.codewars.com/kata/52b757663a95b11b3d00062d
Description: Write a function toWeirdCase (weirdcase in Ruby) that accepts a string, and returns the same string with all even indexed characters in each word upper cased, and all odd indexed characters in each word lower cased. The indexing just explained is zero based, so the zero-ith index is even, therefore that character should be upper cased.

The passed in string will only consist of alphabetical characters and spaces(' '). Spaces will only be present if there are multiple words. Words will be separated by a single space(' ').

Examples:
toWeirdCase( "String" );//=> returns "StRiNg"
toWeirdCase( "Weird string case" );//=> returns "WeIrD StRiNg CaSe"
*/
public string ToWeirdCase(string s)
{
	if(string.IsNullOrWhiteSpace(s))
		return s;

	var weird = s.Split(new[] { ' '}).Select(x => x.Select((y, i) => i % 2 == 0 ? char.ToUpper(y) : char.ToLower(y)));
	return string.Join(" ", weird.Select(x => string.Join(string.Empty, x)));
}