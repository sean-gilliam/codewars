/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/57f780909f7e8e3183000078
Description: Given a non-empty array of integers, return the result of multiplying the values together in order. Example:

[1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
*/
public int Grow(int[] x)
{
	if(x == null || x.Length == 0)
		return 0;

	return x.Aggregate((t, n) => t * n);
}
