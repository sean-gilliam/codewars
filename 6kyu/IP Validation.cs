/*
Difficulty: 6kyu 
URL: https://www.codewars.com/kata/515decfd9dcfc23bb6000006
Description: Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.

Input to the function is guaranteed to be a single string.

Examples
Valid inputs:

1.2.3.4
123.45.67.89
Invalid inputs:

1.2.3
1.2.3.4.5
123.456.78.90
123.045.067.089
Note that leading zeros (e.g. 01.02.03.04) are considered invalid.
*/
public static bool is_valid_IP(string ipAddres)
{
	if(string.IsNullOrWhiteSpace(ipAddres) || ipAddres.Count(x => x == '.') != 3)
		return false;

	var segments = ipAddres.Split(new[] {'.'});
	if(segments.Any(x => string.IsNullOrWhiteSpace(x) || (x.StartsWith("0") && x.Length > 1)) || !segments.SelectMany(x => x).All(c => char.IsDigit(c)))
	   return false;

	return segments.Select(x =>	int.Parse(x)).All(x => x >= 0 && x <= 255);
}
