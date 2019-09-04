/*
Difficulty: 4kyu 
URL: https://www.codewars.com/kata/permutations/csharp
Description: In this kata you have to create all permutations of an input string and remove duplicates, if present. This means, you have to shuffle all letters from the input in all possible orders.

Examples:

Permutations.SinglePermutations("a"); // => new List {"a"}
Permutations.SinglePermutations("ab"); // => new List {"ab", "ba"}
Permutations.SinglePermutations("aabb"); // => new List {"aabb", "abab", "abba", "baab", "baba", "bbaa"}
The order of the permutations doesn't matter.
*/
public List<string> SinglePermutations(string s)
{
	List<string> perms = new List<String>();
	Permute(perms, s, 0, s.Length - 1);
    return perms.Distinct().ToList();
}

public void Permute(List<string> perms, string str, int l, int r) 
{ 
    if (l == r)
	{
        perms.Add(str); 
		return;
	}
    else
	{ 
        for (int i = l; i <= r; i++)
		{ 
            str = Swap(str, l, i); 
            Permute(perms, str, l + 1, r); 
            str = Swap(str, l, i); 
        } 
    } 
} 
  
public string Swap(string a, int i, int j) 
{ 
	if(i == j) return a;
		
    var charArray = a.ToCharArray(); 
    charArray[i] ^= charArray[j]; 
    charArray[j] ^= charArray[i]; 
    charArray[i] ^= charArray[j]; 
	
    return new string(charArray); 
} 