using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "resources", "words.txt");
        List<string> words = ReadFile(filePath);

        Console.Write("Your random word is: ");
        Console.WriteLine(GetRandomWord(words));




    }

  public static List<string> ReadFile(string path)
    {
        List<string> words = new List<string>();

        try
        {
            // Open the file for reading
            using (StreamReader sr = new StreamReader(path))
            {
                string? line;
                // Read each line until the end of the file
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line);
                }
                sr.Close(); 
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred while reading the file: " + e.Message);
        }

        return words;
    }

public static string GetRandomWord(List<string> words)
{
    Random random = new Random();
    int index = random.Next(words.Count);
    return words[index];
}


}

