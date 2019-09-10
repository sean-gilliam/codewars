/*
Difficulty: 7kyu 
URL:https://www.codewars.com/kata/525e5a1cb735154b320002c8
Description: Triangular numbers are so called because of the equilateral triangular shape that they occupy when laid out as dots. i.e.

1st (1)   2nd (3)    3rd (6)
*          **        ***
           *         **
                     *
You need to return the nth triangular number. You should return 0 for out of range values:

all [
  triangular 0     == 0,
  triangular 2     == 3,
  triangular 3     == 6,
  triangular (-10) == 0
] -- True
*/
public int Triangular(int n)
{
	if(n < 1) return 0;
	return (1 + n) * n / 2;
}