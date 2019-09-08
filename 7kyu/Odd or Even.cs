/*
Difficulty: 7kyu 
URL: https://www.codewars.com/kata/5949481f86420f59480000e7
Description: Task:
Given an array of numbers (a list in groovy), determine whether the sum of all of the numbers is odd or even.

Give your answer in string format as 'odd' or 'even'.

If the input array is empty consider it as: [0] (array with a zero).

Example:
odd_or_even({0}, 1) returns "even"
odd_or_even({2, 5, 34, 6}, 4) returns "odd"
odd_or_even({0, -1, -5}, 3) returns "even"
Have fun!
*/
public string OddOrEven(int[] array)
{
	if(array == null || array.Length == 0)
		return "even";
	
	return array.Sum() % 2 == 0 ? "even" : "odd";
}
	