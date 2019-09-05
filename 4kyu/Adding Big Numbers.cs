/*
Difficulty: 4kyu 
URL: https://www.codewars.com/kata/adding-big-numbers/csharp
Description: We need to sum big numbers and we require your help.

Write a function that returns the sum of two numbers. The input numbers are strings and the function must return a string.

Example
add("123", "321"); -> "444"
add("11", "99"); -> "110"
Notes
The input numbers are big.
The input is a string of only digits
The numbers are positives
*/

public string Add(string a, string b)
{
	if(a.Length < b.Length) a = a.PadLeft(b.Length, '0');
	if(b.Length < a.Length) b = b.PadLeft(a.Length, '0');

	var arr1 = a.Select(x => int.Parse(x.ToString())).Reverse().ToArray();
	var arr2 = b.Select(x => int.Parse(x.ToString())).Reverse().ToArray();

	var carry = 0;
	List<int> sum = new List<int>();
	for(var i = 0; i < arr1.Length; i++)
	{
		var s = arr1[i] + arr2[i] + carry;
		sum.Add(s % 10);
		carry = s/10;
	}
	if(carry > 0) sum.Add(carry);
	return string.Join("", sum.Select(x => x).Reverse());
}
