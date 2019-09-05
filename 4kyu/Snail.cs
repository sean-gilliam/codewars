/*
Difficulty: 4kyu 
URL: https://www.codewars.com/kata/snail/csharp
Description: Snail Sort
Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

array = [[1,2,3],
         [4,5,6],
         [7,8,9]]
snail(array) #=> [1,2,3,6,9,8,7,4,5]
For better understanding, please follow the numbers of the next array consecutively:

array = [[1,2,3],
         [8,9,4],
         [7,6,5]]
snail(array) #=> [1,2,3,4,5,6,7,8,9]
This image will illustrate things more clearly:


NOTE: The idea is not sort the elements from the lowest value to the highest; the idea is to traverse the 2-d array in a clockwise snailshell pattern.

NOTE 2: The 0x0 (empty matrix) is represented as [[]]
*/
public int[] Snail(int[][] array)
{
	if(array == null || array.Length == 0)
		return new int[0];

	var list = new List<int>();	
	void spiral(int start, int end)
	{
		if(end == 0) return;
		int i = start;
		
		for(; i < end; i++) list.Add(array[start][i]);
		for(i = start;i < end; i++) list.Add(array[i][end]);
		for(i = end;i > start; i--) list.Add(array[end][i]);
		for(i = end;i > start; i--) list.Add(array[i][start]);

		spiral(start + 1, end - 1);
	}

	var length = array.GetLength(0);
	spiral(0, length - 1);
	
	int middle = (length - 1) / 2;
	if (array[0].Length > 0 && length % 2 == 1)
		list.Add(array[middle][middle]);

	return list.ToArray();
}