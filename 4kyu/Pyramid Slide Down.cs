/*
Difficulty: 4kyu 
URL: https://www.codewars.com/kata/551f23362ff852e2ab000037
Description: ###Lyrics... Pyramids are amazing! Both in architectural and mathematical sense. If you have a computer, you can mess with pyramids even if you are not in Egypt at the time. For example, let's consider the following problem. Imagine that you have a plane pyramid built of numbers, like this one here:

   /3/
  \7\ 4 
 2 \4\ 6 
8 5 \9\ 3
Here comes the task...
Let's say that the 'slide down' is a sum of consecutive numbers from the top to the bottom of the pyramid. As you can see, the longest 'slide down' is 3 + 7 + 4 + 9 = 23

Your task is to write a function longestSlideDown (in ruby: longest_slide_down) that takes a pyramid representation as argument and returns its' longest 'slide down'. For example,

LongestSlideDown(new[] { new[] {3}, new[] {7, 4}, new[] {2, 4, 6}, new[] {8, 5, 9, 3} }); => 23
###By the way... My tests include some extraordinarily high pyramides so as you can guess, brute-force method is a bad idea unless you have a few centuries to waste. You must come up with something more clever than that.

(c) This task is a lyrical version of the Problem 18 and/or Problem 67 on ProjectEuler.
*/
public int LongestSlideDown(int[][] pyramid)
{
	if(pyramid == null)
		return 0;

	var py = To2D(pyramid);
	var lines = py.GetLength(0);
	
	for (int i = lines - 2; i >= 0; i--)
	for (int j = 0; j <= i; j++)
		py[i, j] += Math.Max(py[i+1,j], py[i+1, j+1]);
			
	return py[0, 0];
}

public int[,] To2D(int[][] source)
{
	return new[] { new int[source.Length, source[source.Length - 1].Length] }
		.Select(_ => new { x = _, y = source.Select((x, i) => x.Select((y, j) => _[i, j] = y).Count()).Count() })
		.Select(_ => _.x)
		.First();
}
