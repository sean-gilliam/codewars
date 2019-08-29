/*
If you can't sleep, just count sheep!!

Task:
Given a non-negative integer, 3 for example, return a string with a murmur: "1 sheep...2 sheep...3 sheep...". Input will always be valid, i.e. no negative integers.
 */
public string countSheep(int numberOfSheep)
{
    var sheepiness =  numberOfSheep > 0
        ? string.Join(string.Empty, Enumerable.Range(1, numberOfSheep).Select(x => $"{x} sheep..."))
        : string.Empty;
    return sheepiness;
}