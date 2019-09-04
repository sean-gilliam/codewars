/*
Difficulty: 6kyu 
URL: https://www.codewars.com/kata/5264d2b162488dc400000001
Description: Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

Examples: spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" spinWords( "This is a test") => returns "This is a test" spinWords( "This is another test" )=> returns "This is rehtona test"

*/

public string spinWords(string input)
{
    if(string.IsNullOrWhiteSpace(input))
        return input;
        
    var words = input.Split(' ')
        .Select(x => x.Length >= 5 ? new string(x.Reverse().ToArray()) : x);
    return string.Join(" ", words);
}