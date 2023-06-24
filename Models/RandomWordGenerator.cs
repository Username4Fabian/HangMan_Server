using System;
using System.IO;
using System.Collections.Generic;
using  Hangman_Server.Models;

class RandomWordGenerator
{
    private string word; 

    public RandomWordGenerator()
    {
        this.word = Manager();
    }

    public static String Manager(){
        string path = Path.Combine(Directory.GetCurrentDirectory(), "resources", "words.txt");
        List<string> words = ReadFile(path);
        string word = GetRandomWord(words);
        return word;
    }
  public static List<string> ReadFile(String path)
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
    if (words.Count == 0)
    {
        // Handle the case when the list is empty
        Console.WriteLine("The list of words is empty.");
        return "null"; // or return a default value
    }
    Random random = new Random();
    int index = random.Next(words.Count);
    return words[index];
}

public string getWord(){
    return this.word;

}
}


