/*
Difficulty: 4kyu 
URL: https://www.codewars.com/kata/51c8e37cee245da6b40000bd
Description: Complete the solution so that it strips all text that follows any of a set of comment markers passed in. Any whitespace at the end of the line should also be stripped out.

Example:

Given an input string of:

apples, pears # and bananas
grapes
bananas !apples
The output expected would be:

apples, pears
grapes
bananas
The code would be called like so:

string stripped = Strip.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", ["#", "!"])
// result should == "apples, pears\ngrapes\nbananas"
*/
public string StripComments(string text, string[] commentSymbols)
{
	if(string.IsNullOrWhiteSpace(text) || commentSymbols == null || commentSymbols.Length == 0)
		return string.Empty;

	var c = commentSymbols.SelectMany(x => x).ToArray();
	var filtered = text.Split(new[] { '\n' }).Select(x => x.Split(c)[0].TrimEnd());

	return string.Join("\n", filtered);
}
