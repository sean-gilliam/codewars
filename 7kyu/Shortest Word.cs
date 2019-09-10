/*
Difficulty: 7kyu 
URL: https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9
Description: Simple, given a string of words, return the length of the shortest word(s).

String will never be empty and you do not need to account for different data types.
*/
public int FindShort(string s)
{
	if(string.IsNullOrWhiteSpace(s))
		return 0;

	var arr = s.Split(" ");
	return arr.Min(x => x.Length);
}
