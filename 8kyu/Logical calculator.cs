/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/57096af70dad013aa200007b
Description: Your task is to calculate logical value of boolean array. Test arrays are one-dimensional and their size is in the range 1-50.

Links referring to logical operations: AND, OR and XOR.

You should begin at the first value, and repeatedly apply the logical operation across the remaining elements in the array sequentially.

First Example:

Input: true, true, false, operator: AND

Steps: true AND true -> true, true AND false -> false

Output: false

Second Example:

Input: true, true, false, operator: OR

Steps: true OR true -> true, true OR false -> true

Output: true

Third Example:

Input: true, true, false, operator: XOR

Steps: true XOR true -> false, false XOR false -> false

Output: false

Input:

boolean array, string with operator' s name: 'AND', 'OR', 'XOR'.

Output:

calculated boolean
*/
public bool LogicalCalc(bool[] array, string op)
{
	  if(array == null || array.Length == 0 || string.IsNullOrWhiteSpace(op))
		return false;
	
	op = op.ToUpperInvariant();
	var func = new Dictionary<string, Func<bool, bool, bool>>
	{
		{ "AND", (x, y) => x && y },
		{ "OR", (x, y) => x || y }, 
		{ "XOR", (x, y) => x ^ y }
	};
	
	if(!func.TryGetValue(op, out var f))
		return false;

	return array.Skip(1).Aggregate(array[0], (t, n) => f(t, n));
}