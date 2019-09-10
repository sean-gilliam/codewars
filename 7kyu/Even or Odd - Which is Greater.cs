/*
Difficulty: 7kyu 
URL: https://www.codewars.com/kata/even-or-odd-which-is-greater
Description: Given a string of numbers confirm whether the total of all the individual even numbers are greater than the total of all the indiviudal odd numbers. Always a string of numbers will be given.

If the sum of even numbers is greater than the odd numbers return:

'Even is greater than Odd'

If the sum of odd numbers is greater than the sum of even numbers return:

'Odd is greater than Even'

If the total of both even and odd numbers are identical return:

'Even and Odd are the same'
*/
public string EvenOrOdd(string str)
{
	if(string.IsNullOrWhiteSpace(str))
		return "Even and Odd are the same";
	
	(int even, int odd) tally = (0, 0);
	var totals = str.ToCharArray().Aggregate(tally, (t, n) =>
	{
		var c = int.Parse(n.ToString());
		if(c % 2 == 0) t.even += c;
		else t.odd += c;
		return t;
	});

	if( totals.even == totals.odd)
		return "Even and Odd are the same";

	return totals.even > totals.odd
		? "Even is greater than Odd"
		: "Odd is greater than Even";
}