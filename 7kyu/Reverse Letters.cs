/*
Difficulty: 7kyu 
URL: https://www.codewars.com/kata/58b8c94b7df3f116eb00005b
Description: Task
Given a string str, reverse it omitting all non-alphabetic characters.

Example
For str = "krishan", the output should be "nahsirk".

For str = "ultr53o?n", the output should be "nortlu".

Input/Output
[input] string str

A string consists of lowercase latin letters, digits and symbols.

[output] a string
 */
public string ReverseLetter(string str)
{
    return new string(str.Where(Char.IsLetter).Reverse().ToArray());
}