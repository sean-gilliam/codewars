/*
Difficulty: 8kyu 
URL: https://www.codewars.com/kata/5324945e2ece5e1f32000370
Description: Write a function called repeatString which repeats the given String src exactly count times.

repeatStr(6, "I") // "IIIIII"
repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"
*/
public string repeatStr(int n, string s)
{
	if(string.IsNullOrEmpty(s)) return string.Empty;
	return string.Join(string.Empty, Enumerable.Range(0,n).Select(_ => s));
}
