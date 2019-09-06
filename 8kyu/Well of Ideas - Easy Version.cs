/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/57f222ce69e09c3630000212
Description: For every good kata idea there seem to be quite a few bad ones!

In this kata you need to check the provided array (x) for good ideas 'good' and bad ideas 'bad'. If there are one or two good ideas, return 'Publish!', if there are more than 2 return 'I smell a series!'. If there are no good ideas, as is often the case, return 'Fail!'.
*/
public string Well(string[] x)
{
	if(x == null || x.Length == 0) return "Fail!";
	
	var goodies = x.Where(s => s == "good").Count();
	if(goodies == 0) return "Fail!";
	if(goodies > 2) return "I smell a series!";
	return "Publish!";
}