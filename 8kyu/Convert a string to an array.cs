/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/57e76bc428d6fbc2d500036d
Description: Write a function to split a string and convert it into an array of words. For example:

"Robin Singh" ==> ["Robin", "Singh"]

"I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
*/
public string[] StringToArray(string str)
{
	if(string.IsNullOrWhiteSpace(str))
		return new[] { string.Empty };
  
	return str.Split(" ");
}
