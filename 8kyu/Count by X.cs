/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/5513795bd3fafb56c200049e
Description: Create a function with two arguments that will return an array of length (n) with multiples of (x).

Assume both the given number and the number of times to count will be positive numbers greater than 0.

Return the results as an array (or list in Python, Haskell or Elixir).

Examples:

countBy(1,10)  should return  {1,2,3,4,5,6,7,8,9,10}
countBy(2,5)  should return {2,4,6,8,10}
*/
public int[] CountBy(int x, int n)
{
	if(x < 0 || n < 0)
		return new int[0];

	return Enumerable.Range(1, n).Select(c => c * x).ToArray();
}