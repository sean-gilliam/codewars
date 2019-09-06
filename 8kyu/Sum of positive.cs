/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/5715eaedb436cf5606000381
Description: You get an array of numbers, return the sum of all of the positives ones.

Example [1,-4,7,12] => 1 + 7 + 12 = 20

Note: if there is nothing to sum, the sum is default to 0.
*/
public int PositiveSum(int[] arr)
{
	if(arr == null || arr.Length == 0)
		return 0;
	
	return arr.Where(x => x > 0).Sum();
}    