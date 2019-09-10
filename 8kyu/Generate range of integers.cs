/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/55eca815d0d20962e1000106
Description: mplement a function named generateRange(min, max, step), which takes three arguments and generates a range of integers from min to max, with the step. The first integer is the minimum value, the second is the maximum of the range and the third is the step. (min < max)

Task
Implement a function named

GenerateRange(2, 10, 2) == new int[]{ 2, 4, 6, 8, 10 }
GenerateRange(1, 10, 3) == new int[]{ 1, 4, 7, 10 }
which takes three arguments and generates a range of integers from min to max, with given step. The first is minimum value, second is maximum of range and the third is step.

Note
min < max
step > 0
the range does not HAVE to include max (depending on the step)
*/
public int[] GenerateRange(int min, int max, int step)
{
	if(min > max || step < 1)
		return new int[0];

	return Enumerable.Range(0, (max - min) / step + 1)
		.Select(i => min + step * i).ToArray();
}
	