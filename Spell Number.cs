/*
    Not an actual Code Wars kata. Just a suggestion from the #code-kata-dojo channel from CodeEveryday discord.
 */
public string spellNumber(int number)
{
    if(number == 0) return "zero";
        
    var negative = string.Empty;
    var str = number.ToString();
    if(str.StartsWith("-"))
    {
        negative += "negative ";
        str = str.Substring(1);
    }
    
    var padding = (3 - str.Length % 3) % 3;
    str = str.PadLeft(padding + str.Length, '0');

    var groupNumbers = new[] { "", "", "thousand", "million", "billion" };
    var basicNumbers = new[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    var deciNumbers = new[] { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
    var numbers = new string[][] { basicNumbers, deciNumbers, basicNumbers };
    
    var chunks = Enumerable.Range(0, str.Length / 3).Select(x => 
    {
        var input = str.Substring(x * 3, 3);
        var range = Enumerable.Range(0, input.Length).Select((_, i) => 
        {
            var triplet = numbers[i][int.Parse(input[i].ToString())];
            if(i == 0 && input[0] != '0') triplet += " hundred ";
            if(i == 1 && (input[1] != '0' && input[2] != '0')) triplet += "-";
            return triplet;
        }).ToArray();
        
        if(range[1] == "ten-" && !string.IsNullOrWhiteSpace(range[2]))
        {
            switch(range[2])
            {
                case "one": range[1] = "eleven"; break;
                case "two": range[1] = "twelve"; break;
                case "three": range[2] = "thir"; goto default;
                case "five": range[2] = "fif"; goto default;
                default: range[1] = range[2] + "teen"; break;
            }
            range[2] = string.Empty;
        }
        
        var chunk = string.Join(string.Empty, range);
        return chunk;
    }).ToArray();
    
    var nn = Enumerable.Range(0, chunks.Length).Reverse().Select((x, i) => chunks[i] + " " + groupNumbers[x+1]);
    return negative + string.Join(" ", nn).Trim();
}