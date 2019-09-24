/*
Difficulty: 6kyu 
URL: https://www.codewars.com/kata/54da5a58ea159efa38000836
Description: Given an array, find the int that appears an odd number of times.

There will always be only one integer that appears an odd number of times.
*/
public int find_it(int[] seq) 
{
	if(seq == null || seq.Length == 0)
		return 0;
		
	var q =  seq.GroupBy(x => x).Select(x => new { key = x.Key, count = x.Count()}).FirstOrDefault(x => x.count % 2 == 1);
		return q?.key ?? 0;
}
