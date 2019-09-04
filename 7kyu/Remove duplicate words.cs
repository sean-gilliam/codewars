/*
Difficulty: 7kyu 
URL: https://www.codewars.com/kata/5b39e3772ae7545f650000fc
Description: Your task is to remove all duplicate words from a string, leaving only single (first) words entries.

Example:

Input:

'alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta'

Output:

'alpha beta gamma delta'
*/
public string RemoveDuplicateWords(string s)
{
    return string.Join(' ', s.ToLowerInvariant().Split(' ').Distinct());
}
