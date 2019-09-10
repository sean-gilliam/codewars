/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/5933a1f8552bc2750a0000ed
Description: Return the Nth Even Number

NthEven(1) //=> 0, the first even number is 0
NthEven(3) //=> 4, the 3rd even number is 4 (0, 2, 4)

NthEven(100) //=> 198
NthEven(1298734) //=> 2597466
The input will not be 0.
*/
public int NthEven(int n)
{
	if(n <= 0)
		return 0;
	
	return Enumerable.Range(0, n * 2).LastOrDefault(x => x % 2 == 0);
}