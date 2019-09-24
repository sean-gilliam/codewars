/*
Difficulty: 5kyu 
URL: https://www.codewars.com/kata/52597aa56021e91c93000cb0
Description: Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
*/
public int[] MoveZeroes(int[] arr)
{
	if(arr == null || arr.Length == 0)
	  return arr;
	
	var nonz = arr.Where(x => x != 0);
	var z = arr.Where(x => x == 0);
	
	return nonz.Concat(z).ToArray();
}