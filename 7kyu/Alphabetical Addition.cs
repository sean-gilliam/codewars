/*
Difficulty: 7kyu 
URL: https://www.codewars.com/kata/5d50e3914861a500121e1958
Description: Your task is to add up letters to one letter.

The function will be given an array of letters (chars), each one being a letter to add. Return a char.

Notes:
Letters will always be lowercase.
Letters can overflow (see second to last example of the description)
If no letters are given, the function should return 'z'
Examples:
add_letters(new char[] {'a', 'b', 'c'}) = 'f'
add_letters(new char[] {'a', 'b'}) = 'c'
add_letters(new char[] {'z'}) = 'z'
add_letters(new char[] {'z', 'a'}) = 'a'
add_letters(new char[] {'y', 'c', 'b'}) = 'd' // notice the letters overflowing
add_letters(new char[] {}) = 'z'
*/
public char AddLetters(char[] letters)
{
	if(letters == null || letters.Length == 0)
		return 'z';
	
	var sum = letters.Sum(x => x - 96);
	  var ret = (char)((sum % 26) + 96);
	
	return ret == 96 ? 'z' : ret;
}