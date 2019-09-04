/*
Difficulty: 4kyu 
URL: https://www.codewars.com/kata/5426d7a2c2c7784365000783
Description: Write a function which makes a list of strings representing all of the ways you can balance n pairs of parentheses

Examples
BalancedParens(0) returns List<string> with element:  ""
BalancedParens(1) returns List<string> with element:  "()"
BalancedParens(2) returns List<string> with elements: "()()","(())"
BalancedParens(3) returns List<string> with elements: "()()()","(())()","()(())","(()())","((()))"
*/
public static List<string> BalancedParens(int n)
{
    var combo = new List<string>();
    
    void compute(int left, int right, string str)
    {
        if (left == 0 && right == 0)
        {
            combo.Add(str);
            return;
        }
        
        if (left > 0) compute(left-1, right+1, str+"(");
        if (right > 0) compute(left, right-1, str+")"); 
    }
    
    compute(n, 0 , string.Empty);
    return combo;
}
