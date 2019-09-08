/*
Difficulty: 6kyu 
URL: https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1
Description: Count the number of Duplicates
Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

Example
"abcde" -> 0 # no characters repeats more than once
"aabbcde" -> 2 # 'a' and 'b'
"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
"indivisibility" -> 1 # 'i' occurs six times
"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
"aA11" -> 2 # 'a' and '1'
"ABBA" -> 2 # 'A' and 'B' each occur twice
*/
public int DuplicateCount(string str)
{
	if(string.IsNullOrEmpty(str))
		return 0;
	
	var counts = new Dictionary<string, int>();
	str.ToCharArray().ToList().ForEach(x =>
	{
		var key = x.ToString().ToUpperInvariant();
		if(counts.ContainsKey(key)) counts[key]++;
		else counts.Add(key, 1);
	});
	
	return counts.Count(x => x.Value > 1);
}
