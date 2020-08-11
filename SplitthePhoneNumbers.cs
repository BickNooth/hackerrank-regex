using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var numberRegex = new Regex(@"^(\d{1,3})[ -](\d{1,3})[ -](\d{4,10})$");
        var nNumbers = Int32.Parse(Console.ReadLine());
        for(var i = 0; i < nNumbers; i++)
        {
            var matchCollection = numberRegex.Match(Console.ReadLine()).Groups;
            Console.WriteLine($"CountryCode={matchCollection[1]},LocalAreaCode={matchCollection[2]},Number={matchCollection[3]}");
        }
       
    }
}