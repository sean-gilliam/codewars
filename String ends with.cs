/*
Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

Examples:

solution('abc', 'bc') // returns true
solution('abc', 'd') // returns false
 */
public bool solution(string arg1, string arg2)
{
    return Regex.Match(arg1, $"{arg2}$").Success;
}


//expanded version
public static bool solution(string arg1, string arg2)
{
    // sanity check.
    // if the first string is null, then theres nothing to check against.
    // if the second string is null, then there's nothing to verify.
    if(arg1 == null || arg2 == null)
        return false;

    // sanity check.
    // if the second string is longer than the first string,
    // then the first string cant contain the second.
    if(arg2.Length > arg1.Length)
        return false;

    // compute the difference in length between the two strings.
    // this value will be used when iterating over the second string.
    var diff = arg1.Length - arg2.Length;

    // since strings are character arrays underneath,
    // we'll iterate backwards over the array to
    // verify there aren't any mismatches
    //
    // i        = current index of first string
    // i - diff = current index of the second string
    for(var i = arg1.Length - 1; i >= 0; i--)
    {
        // sanity check.
        // arrays can't have negative indices (arr[-1] == ArrayOutOfBoundsException),
        // and since the first string can be longer than the second string, we
        // need to check the current index of the second string is not out of bounds.
        if(i - diff < 0)
            break;

        // if we encounter a mismatching character, then abort early
        if(arg1[i] != arg2[i - diff])
            return false;
    }

    return true;
}