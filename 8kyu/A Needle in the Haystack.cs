/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/56676e8fabd2d1ff3000000c
Description: Can you find the needle in the haystack?

Write a function findNeedle() that takes an array full of junk but containing one "needle"

After your function finds the needle it should return a message (as a string) that says:

"found the needle at position " plus the index it found the needle, so:

find_needle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
should return "found the needle at position 5"
*/
public string FindNeedle(object[] haystack)
{
	if(haystack == null || haystack.Length == 0)
		return string.Empty;
	
	var h = haystack.Select(x => x ?? "null".ToString()).ToArray();
	var idx = Array.IndexOf(h, "needle");
	return idx > -1 ? $"found the needle at position {idx}" : string.Empty;
}
    