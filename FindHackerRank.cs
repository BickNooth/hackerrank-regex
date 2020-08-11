using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

class Solution {
    static void Main(String[] args) {
        var startsAndEndsWithRegex = new Regex(@"^(?:hackerrank)$");
        var startsWithRegex = new Regex(@"^(?:hackerrank)");
        var endsWithRegex = new Regex(@"(?:hackerrank)$");

        var lineNumber = Int32.Parse(Console.ReadLine());

        for(var i = 0; i < lineNumber; i++)
        {
            var str = Console.ReadLine();
            if (startsAndEndsWithRegex.IsMatch(str))
            {
                Console.WriteLine(0);
            }
            else if(startsWithRegex.IsMatch(str))
            {
                Console.WriteLine(1);                
            }
            else if(endsWithRegex.IsMatch(str))
            {
                Console.WriteLine(2);                
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}