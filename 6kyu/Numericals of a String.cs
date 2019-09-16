/*
Difficulty: 6kyu 
URL: https://www.codewars.com/kata/5b4070144d7d8bbfe7000001
Description: You are given an input string.

For each symbol in the string if it's the first character occurence, replace it with a '1', else replace it with the amount of times you've already seen it...

But will your code be performant enough?

Examples:
input   =  "Hello, World!"
result  =  "1112111121311"

input   =  "aaaaaaaaaaaa"
result  =  "123456789101112"
*/
public string Numericals(string s)
{
	if(string.IsNullOrEmpty(s)) return "0";

	var count = new Dictionary<char, int>();
	var sb = new StringBuilder();
	for(var i = 0; i < s.Length; i++)
	{
		if(count.TryGetValue(s[i], out var value))
		{
			count[s[i]] = value + 1;
			sb.Append(value + 1);
		}
			else
		{
			count.Add(s[i], 1);
			sb.Append(1);
		}
	  }

	  return sb.ToString();
}
