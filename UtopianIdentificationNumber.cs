using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Solution {
    static void Main(String[] args) {
        var lines = Int32.Parse(Console.ReadLine());

        for(var i = 0; i < lines; i++){
            var stringToCheck = Console.ReadLine();
            var matches = Regex.Match(stringToCheck, @"^[a-z]{0,3}\d{2,8}[A-Z]{3,}");

            if(matches.Success){
                Console.WriteLine("VALID"); 
                continue;      
            }
            Console.WriteLine("INVALID");
        }
    }
}