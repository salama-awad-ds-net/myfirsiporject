using System;
//ExceptionExercis small version
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using  System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;



class WordsFile // file class
{
    public string[] Words {get; set;} = new string[0]; //words
    public bool Success {get; set;} //susess?
    public string Message {get; set;} = ""; // Message

}

class Chatbot // Bot
{
    public List<int> ParseNumbers(string input) // input-> text
    {
        List<int> numbers = new List<int>(); //List
        foreach(string part in input.Split(",")) // spilt 
        {
            try
            {
                numbers.Add(int.Parse(part.Trim()));}
                catch (FormatException) {Console.WriteLine("Entery discarded");}
            }
            // sort high to low
            return numbers.OrderByDescending(n  => n).ToList(); 
           
        }

    // Part 2 file
    public WordsFile ReadFile(string path) // path
    {
        WordsFile f = new WordsFile(); // creae new file
        try
        {
            string text = ""; //test
            using (StreamReader r = new StreamReader(path)) {text = r.ReadToEnd(); }
            f.Words = text.Split(','); //split
            f.Success = true; // success
            f.Message = "Success";  // message
        }
        // if not found
        catch (FileNotFoundException)
        {
            f.Success = false; // if failed
            f.Message = "File not fund"; // give me message
        }
        return f; // return

    }
    
    // Start
    static void Main(string[] args)
    {
        // create Bot
        Chatbot bot  = new Chatbot();
         // test 1
        Console.Write("Numbers:  "); //Ask
        var nums = bot.ParseNumbers(Console.ReadLine() ?? "");  // run
        Console.WriteLine("Sorted:  " + string.Join(",", nums)); // print


        // test 2 
        Console.Write("File:  "); // ask
        var file = bot.ReadFile(Console.ReadLine() ?? ""); // run chbot
        Console.WriteLine($"{file.Success} - {file.Message}"); // print
        Console.WriteLine(string.Join("|", file.Words)); // print text or worrds
    }
}

// test in my words.txt is  --> [Hello,chatbot,help,bye]
/*
I tried the code
-------------------
Numbers:  10,abs,8
Entery discarded
Sorted:  10,8
File:  words.txt
True - Success
Hello|chatbot|help|bye
*/