/*
Difficulty: 7kyu 
URL: https://www.codewars.com/kata/551f37452ff852b7bd000139
Description: Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.

The binary number returned should be a string.
*/
public string AddBinary(int a, int b)
{
	var sum = a + b;
	return Convert.ToString(sum, 2);
}