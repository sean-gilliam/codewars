/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/56f6919a6b88de18ff000b36
Description: Your friend has been out shopping for puppies (what a time to be alive!)... He arrives back with multiple dogs, and you simply do not know how to respond!

By repairing the function provided, you will find out exactly how you should respond, depending on the number of dogs he has.

The number of dogs will always be a number and there will always be at least 1 dog.
*/
public string HowManyDalmatians(int n)
{
	var dogs = new List<string>()
	{
		"Hardly any",
		"More than a handful!",
		"Woah that's a lot of dogs!",
		"101 DALMATIONS!!!"
	};
	
	return (n <= 10) ? dogs[0] : (n <= 50) ? dogs[1] : (n == 101) ? dogs[3] : dogs[2];
}