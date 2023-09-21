using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FOOTBALL;

public class CSV_Generator
{
    public void generator()
    {
        // List of CSV files to combine
        List<string> csvFiles = new List<string>
        {
            "Round 1.csv",
            "Round 2.csv",
            "Round 3.csv",
            "Round 4.csv",
            "Round 5.csv",
            "Round 6.csv",
            "Round 7.csv",
            "Round 8.csv",
            "Round 9.csv",
            "Round 10.csv",
            "Round 11.csv",
            "Round 12.csv",
            "Round 13.csv",
            "Round 14.csv",
            "Round 15.csv",
            "Round 16.csv",
            "Round 17.csv",
            "Round 18.csv",
            "Round 19.csv",
            "Round 20.csv",
            "Round 21.csv",
            "Round 22.csv",
        };

        // List to store combined data
        List<string[]> combinedData = new List<string[]>();

        // Random number generator
        Random random = new Random();

        // Read data from CSV files and shuffle
        foreach (string csvFile in csvFiles)
        {
            string[] lines = File.ReadAllLines(csvFile);
            List<string[]> data = lines.Select(line => line.Split(',')).ToList();
            Shuffle(data, random);
            combinedData.AddRange(data);
        }

        // Shuffle the combined data
        Shuffle(combinedData, random);

        // Write mixed data to a new CSV file
        using (StreamWriter writer = new StreamWriter(@"CSV_Files\Setup.csv"))
        {
            foreach (string[] row in combinedData)
            {
                writer.WriteLine(string.Join(",", row));
            }
        }

        Console.WriteLine($"Data from {csvFiles.Count} CSV files mixed and saved to Setup.csv");
    }

    // Fisher-Yates shuffle algorithm to shuffle a list
    static void Shuffle<T>(List<T> list, Random random)
    {
        int n = list.Count;
        for (int i = n - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
