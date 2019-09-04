/*
Difficulty: 7kyu 
URL: https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d
Description: Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

Examples:

solution('abc', 'bc') // returns true
solution('abc', 'd') // returns false
 */
public bool solution(string str, string ending)
{
    return str.EndsWith(ending);
}


//expanded version
public static bool solution(string str, string ending)
{
    // sanity check.
    // if the first string is null, then theres nothing to check against.
    // if the second string is null, then there's nothing to verify.
    if(str == null || ending == null)
        return false;

    // sanity check.
    // if the second string is longer than the first string,
    // then the first string cant contain the second.
    if(ending.Length > str.Length)
        return false;

    // compute the difference in length between the two strings.
    // this value will be used when iterating over the second string.
    var diff = str.Length - ending.Length;

    // since strings are character arrays underneath,
    // we'll iterate backwards over the array to
    // verify there aren't any mismatches
    //
    // i        = current index of first string
    // i - diff = current index of the second string
    for(var i = str.Length - 1; i >= 0; i--)
    {
        // sanity check.
        // arrays can't have negative indices (arr[-1] == ArrayOutOfBoundsException),
        // and since the first string can be longer than the second string, we
        // need to check the current index of the second string is not out of bounds.
        if(i - diff < 0)
            break;

        // if we encounter a mismatching character, then abort early
        if(str[i] != ending[i - diff])
            return false;
    }

    return true;
}