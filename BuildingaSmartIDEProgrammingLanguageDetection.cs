using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution {
    static void Main(String[] args) {
        var inputString = String.Empty;

        for(var i = 0; i < 15; i++){
            inputString += Console.ReadLine();
        }

        var cMatch = Regex.Match(inputString, @"(#include)");

        if(cMatch.Length > 0){
            Console.WriteLine("C");
            return;
        }  

        var javaMatch = Regex.Match(inputString, @"(import java)");

        if(javaMatch.Length > 0){
            Console.WriteLine("Java");
            return;
        }
        
        Console.WriteLine("Python");        
    }
}