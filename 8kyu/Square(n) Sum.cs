/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/515e271a311df0350d00000f
Description: Complete the square sum function so that it squares each number passed into it and then sums the results together.

For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.
*/
public int SquareSum(int[] n)
{ 
	if(n == null || n.Length == 0)
		return 0;
	
	return n.Sum(x => x * x);
}