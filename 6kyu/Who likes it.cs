/*
Difficulty: 6kyu 
URL: https://www.codewars.com/kata/5266876b8f4bf2da9b000362
Description: You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.

Implement a function likes :: [String] -> String, which must take in input array, containing the names of people who like an item. It must return the display text as shown in the examples:

Kata.Likes(new string[0]) => "no one likes this"
Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
Kata.Likes(new string[] {"Max", "John", "Mark"}) => "Max, John and Mark like this"
Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"
For 4 or more names, the number in and 2 others simply increases.
*/
public string Likes(string[] name)
{
	var likes = "likes this";

	if(name == null || name.Length == 0)
		return "no one " + likes;

	name = name.Length > 3
		? new[] { name[0], name[1], (name.Length - 2).ToString() + " others" }
		: name;

	var s = string.Join(", ", name);
	if(s.Contains(","))
	{
		var i = s.LastIndexOf(",");
		s = s.Remove(i, 1).Insert(i, " and");
	}

	likes = name.Length > 1 ? likes.Replace("likes", "like") : likes;
	return $"{s} {likes}";
}
