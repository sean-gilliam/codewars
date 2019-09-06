/*
Difficulty: 7kyu 
URL: https://www.codewars.com/kata/5c50a0e8cdc6aa29703f6805
Description: Scenario
A construction master applies specific rules when creating walls. But the construction master cannot calculate the exact number of bricks to be spent on the walls.

For this reason, you are expected to write a method that calculates the number of bricks that need to be spent for the wall whose width and height are clear.

Rules
Only 3 kinds of bricks can be used. Large Brick(60 cm), Medium Brick(40 cm) and Small Brick(20cm)
The height of all bricks is 5 cm and wall height is always 5 cm and multiples.
The Wall width is always 60 cm and multiples.
The lowest row should be composed of only large bricks.
After that, the first brick from the right of the next row must be the middle brick, the first brick from the left is the small brick.
Finally, The first brick from the right of the next row must be the small brick, the first brick from the left is the medium brick.
The first row after the series is completed again consists of large bricks and the cycle continues.
The number of bricks used should return to the following format. "21L6M6S"
If number of medium and small bricks is 0, then answer should be the following format. "21L"
Example Wall
|  40  |   60   |   60   | 20 |
| 20 |   60   |   60   |  40  |
|    60   |    60   |    60   |
|  40  |   60   |   60   | 20 |
| 20 |   60   |   60   |  40  |
|    60   |    60   |    60   |
|  40  |   60   |   60   | 20 |
| 20 |   60   |   60   |  40  |
|    60   |    60   |    60   |

Wall height is 45 cm and wall width is 180 cm. There are 21 large bricks. (Yellow bricks) There are 6 medium bricks. (Green bricks) There are 6 small bricks. (Pink bricks)

So answer is "21L6M6S"
*/
public string CalculateBricksCount(int width, int height)
{
	(int large, int medium, int small) layout = (0, 0, 0);

	if(width % 60 < 0 || height % 5 < 0) return string.Empty;
	var bricks = Enumerable.Range(0, height / 5).Aggregate(layout, (t, n) =>
	{
		if(n % 3 == 0) { t.large += width/60; }
		else { t.medium++; t.small++; t.large += (width-20-40)/60; }
		return t;
	});

	Func<int, string, string> format = (x, s) => x > 0 ? x + s : string.Empty;
	var large =  format(bricks.large, "L");
	var medium = format(bricks.medium, "M");
	var small = format(bricks.small, "S");

	return $"{large}{medium}{small}";
}
