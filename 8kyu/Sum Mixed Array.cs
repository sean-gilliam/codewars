/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/57eaeb9578748ff92a000009
Description: Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.

Return your answer as a number.
*/
public int SumMix(object[] x)
{
	if(x == null || x.Length == 0)
		return 0;
		
	return x.Sum(y => int.Parse(y.ToString()));
}