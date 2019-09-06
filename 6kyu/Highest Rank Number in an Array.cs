/*
Difficulty: 6kyu 
URL: https://www.codewars.com/kata/5420fc9bb5b2c7fd57000004
Description: Write a method highestRank(arr) (or highest-rank in clojure) which returns the number which is most frequent in the given input array (or ISeq). If there is a tie for most frequent number, return the largest number of which is most frequent.

Example:

var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
Kata.HighestRank(arr) //=> returns 12

arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 };
Kata.HighestRank(arr) //=> returns 12

var arr = new int[] { 12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10 };
Kata.HighestRank(arr) //=> returns 3
*/
public int HighestRank(int[] arr)
{
	if(arr == null || arr.Length == 0) return 0;
	
	var freq = arr.GroupBy(x => x)
		.Select(x => new { k = x.Key, c = x.Count() })
		.OrderByDescending(x => x.c)
		.ThenByDescending(x => x.k)
		.FirstOrDefault();
	return freq?.k ?? 0;
}