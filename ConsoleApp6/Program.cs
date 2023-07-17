using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> argumentsDictionary = new Dictionary<string, string>();

        for (int i = 0; i < args.Length; i++)
        {
            if (!args[i].StartsWith("-") || !args[i].Contains(":"))
            {
                Console.WriteLine($"Invalid argument format: {args[i]}. Please use the format '-Key:Value'.");
                return;
            }

            string[] keyValue = args[i].Split(':');
            string key = keyValue[0].TrimStart('-');
            string value = keyValue[1];

            argumentsDictionary[key] = value;
        }

        // Display the dictionary contents
        Console.WriteLine("Arguments Dictionary:");
        foreach (var kvp in argumentsDictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
