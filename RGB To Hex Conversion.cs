/*
The rgb() method is incomplete. Complete the method so that passing in RGB decimal values will result in a hexadecimal representation being returned. The valid decimal values for RGB are 0 - 255. Any (r,g,b) argument values that fall out of that range should be rounded to the closest valid value.

The following are examples of expected output values:

rgb(255, 255, 255) // returns FFFFFF
rgb(255, 255, 300) // returns FFFFFF
rgb(0,0,0) // returns 000000
rgb(148, 0, 211) // returns 9400D3
*/

public string rgb(int r, int g, int b)
{
	var validRange = Enumerable.Range(0, 256);
	Func<int, string> getHex = x => (!validRange.Any(y => y == x) ? "00" : x.ToString("X2"));
	
	return getHex(r) + getHex(g) + getHex(b);
}

