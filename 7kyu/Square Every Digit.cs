/*
Difficulty: 7kyu 
URL: https://www.codewars.com/kata/546e2562b03326a88e000020
Description: Welcome. In this kata, you are asked to square every digit of a number.

For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

Note: The function accepts an integer and returns an integer
*/
public int SquareDigits(int n)
{
	var digits = n.ToString().Select(x => 
	{
		var d = int.Parse(x.ToString());
		return d * d;
	});
	
	return int.Parse(string.Join(string.Empty, digits));
}
