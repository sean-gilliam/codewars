/*
Difficulty: 6kyu 
URL: https://www.codewars.com/kata/5d23d89906f92a00267bb83d
Description: Some new cashiers started to work at your restaurant.

They are good at taking orders, but they don't know how to capitalize words, or use a space bar!

All the orders they create look something like this:

"milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza"

The kitchen staff are threatening to quit, because of how difficult it is to read the orders.

Their preference is to get the orders as a nice clean string with spaces and capitals like so:

"Burger Fries Chicken Pizza Pizza Pizza Sandwich Milkshake Milkshake Coke"

The kitchen staff expect the items to be in the same order as they appear in the menu.

The menu items are fairly simple, there is no overlap in the names of the items:

1. Burger
2. Fries
3. Chicken
4. Pizza
5. Sandwich
6. Onionrings
7. Milkshake
8. Coke
*/
public string GetOrder(string input)
{	
	if(string.IsNullOrEmpty(input)) return string.Empty;

	var menu = new Dictionary<string, int>
	{ 
		{ "Burger", 0 },
		{ "Fries", 1 },
		{ "Chicken", 2},
		{ "Pizza", 3},
		{ "Sandwich", 4 },
		{ "Onionrings", 5 }, 
		{ "Milkshake", 6 },
		{ "Coke", 7 }
	};

	var menuItems = menu.Keys;
	var current = string.Empty;
	var result = new List<string>();
	
	for(var i = 0; i < input.Length; i++)
	{
		current += input[i];
		if(menuItems.FirstOrDefault(x => current.IndexOf(x,StringComparison.OrdinalIgnoreCase) == 0) != null)
		{
			result.Add(char.ToUpper(current[0]) + current.Substring(1));
			current = string.Empty;
		}
	}

	var order = from r in result
		join m in menu on r equals m.Key
		orderby m.Value
		select r;

	return string.Join(" ", order);
}
	