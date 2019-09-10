/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/5a2be17aee1aaefe2a000151
Description: I'm new to coding and now I want to get the sum of two arrays...actually the sum of all their elements. I'll appreciate for your help.

P.S. Each array includes only integer numbers. Output is a number too.
*/
public int ArrayPlusArray(int[] arr1, int[] arr2)
{
	int sum = 0;
	
	sum += !(arr1 == null || arr1.Length == 0) ? arr1.Sum() : 0;
	sum += !(arr2 == null || arr2.Length == 0) ? arr2.Sum() : 0;
	
	return sum;
}
