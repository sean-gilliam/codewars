/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/57a5c31ce298a7e6b7000334
Description: Complete the function which converts a binary number (given as a string) to a decimal number.
*/
public int binToDec(string s)
{
	if(string.IsNullOrWhiteSpace(s)) return 0;
  	return Convert.ToInt32(s, 2);
}