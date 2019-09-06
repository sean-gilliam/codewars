/*
Difficulty: 4kyu 
URL: https://www.codewars.com/kata/557f6437bf8dcdd135000010
Description: In mathematics, the factorial of integer n is written as n!. It is equal to the product of n and every integer preceding it. For example: 5! = 1 x 2 x 3 x 4 x 5 = 120

Your mission is simple: write a function that takes an integer n and returns the value of n!.

You are guaranteed an integer argument. For any values outside the non-negative range, return null, nil or None (return an empty string "" in C and C++). For non-negative numbers a full length number is expected for example, return 25! = "15511210043330985984000000" as a string.

For more on factorials, see http://en.wikipedia.org/wiki/Factorial

NOTES:

The use of BigInteger or BigNumber functions has been disabled, this requires a complex solution

I have removed the use of require in the javascript language.
*/
public string Factorial(int n)
{
	if(n == 0) return 1.ToString();
	return Enumerable.Range(1, n).Select(x => x.ToString()).Aggregate((total, next) => Multiply(total, next));
}

public string Multiply(string num1, string num2) 
{
	num1 = (num1 ?? string.Empty).Trim();
	num2 = (num2 ?? string.Empty).Trim();

	if(string.IsNullOrWhiteSpace(num1) || string.IsNullOrWhiteSpace(num2)) return "0"; 

	var result = new int[num1.Length + num2.Length]; 
	int pos1 = 0, pos2 = 0;  

	for (var i = num1.Length - 1; i >= 0; i--) 
	{ 
		var carry = 0; 
		var n1 = num1[i] - '0'; 

		pos2 = 0;  
	  
		for (var j = num2.Length - 1; j >= 0; j--) 
		{ 
			var n2 = num2[j] - '0'; 
			var sum = n1 * n2 + result[pos1 + pos2] + carry; 

			carry = sum / 10; 
			result[pos1 + pos2] = sum % 10; 

			pos2++; 
		} 

		if (carry > 0) result[pos1 + pos2] += carry;

		pos1++; 
	} 

	return string.Concat(result.Reverse().Select(x => x.ToString())).TrimStart('0');
} 