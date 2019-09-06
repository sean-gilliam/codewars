/*
Difficulty: 7kyu 
URL: https://www.codewars.com/kata/5556282156230d0e5e000089
Description: Yor task is to write function factorial

https://en.wikipedia.org/wiki/Factorial
*/
public int factorial(int n)
{
	if(n == 0) return 1;
	return Enumerable.Range(1, n).Reverse().Aggregate((t, i) => t * i);
}