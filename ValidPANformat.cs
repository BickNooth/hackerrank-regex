using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        var lines = Int32.Parse(Console.ReadLine());

        for (var i = 0; i < lines; i++)
        {
            var stringToCheck = Console.ReadLine();
            var matches = Regex.Match(stringToCheck, @"^[A-Z]{5}\d{4}[A-Z]$");

            if (matches.Success)
            {
                Console.WriteLine("YES");
                continue;
            }
            Console.WriteLine("NO");
        }
    }
}