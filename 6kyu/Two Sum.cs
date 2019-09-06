/*
Difficulty: 6kyu 
URL: https://www.codewars.com/kata/52c31f8e6605bcc646000082
Description: DWrite a function that takes an array of numbers (integers for the tests) and a target number. It should find two different items in the array that, when added together, give the target value. The indices of these items should then be returned in a tuple like so: (index1, index2).

For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.

The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers; target will always be the sum of two different items from that array).

Based on: http://oj.leetcode.com/problems/two-sum/

twoSum [1, 2, 3] 4 === (0, 2)
*/
public int[] TwoSum(int[] numbers, int target)
{
    var sorted = numbers.Select((x, i) => new { idx = i, key = x} ).OrderBy(x => x.key).ToList();

	(int left, int right) current = (0, sorted.Count - 1);
    while (current.left < current.right)
	{ 
        if (sorted[current.left].key + sorted[current.right].key == target) 
            return new[] { sorted[current.left].idx, sorted[current.right].idx}.OrderBy(x => x).ToArray(); 
        else if (sorted[current.left].key + sorted[current.right].key < target) 
            current.left++; 
        else
            current.right--; 
		
    } 
	
    return new[] {0, 0};
}
