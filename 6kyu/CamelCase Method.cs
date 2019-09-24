/*
Difficulty: 6kyu 
URL: https://www.codewars.com/kata/587731fda577b3d1b0001196
Description: Write simple .camelCase method (camel_case function in PHP, CamelCase in C# or camelCase in Java) for strings. All words must have their first letter capitalized without spaces.

For instance:

camelCase("hello case"); // => "HelloCase"
camelCase("camel case word"); // => "CamelCaseWord"
Don't forget to rate this kata! Thanks :)
*/
public string CamelCase(this string str)  
{  
	  if(string.IsNullOrWhiteSpace(str))
		  return str;
		
	var words = str.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
	var strings = words.Select(x => Char.ToUpper(x[0]).ToString() + x.Substring(1));
	return string.Join(string.Empty, strings);
}
