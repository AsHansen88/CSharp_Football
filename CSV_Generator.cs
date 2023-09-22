class CSV_Generator
{
    public void generator()
    {
        // List of CSV files to combine
        List<string> csvFiles = new List<string>
        {
            @"CSV_Files\Rounds\Round-1.csv",
            @"CSV_Files\Rounds\Round-2.csv",
            @"CSV_Files\Rounds\Round-3.csv",
            @"CSV_Files\Rounds\Round-4.csv",
            @"CSV_Files\Rounds\Round-5.csv",
            @"CSV_Files\Rounds\Round-6.csv",
            @"CSV_Files\Rounds\Round-7.csv",
            @"CSV_Files\Rounds\Round-8.csv",
            @"CSV_Files\Rounds\Round-9.csv",
            @"CSV_Files\Rounds\Round-10.csv",
            @"CSV_Files\Rounds\Round-11.csv",
            @"CSV_Files\Rounds\Round-12.csv",
            @"CSV_Files\Rounds\Round-13.csv",
            @"CSV_Files\Rounds\Round-14.csv",
            @"CSV_Files\Rounds\Round-15.csv",
            @"CSV_Files\Rounds\Round-16.csv",
            @"CSV_Files\Rounds\Round-17.csv",
            @"CSV_Files\Rounds\Round-18.csv",
            @"CSV_Files\Rounds\Round-19.csv",
            @"CSV_Files\Rounds\Round-20.csv",
            @"CSV_Files\Rounds\Round-21.csv",
            @"CSV_Files\Rounds\Round-22.csv",
        
        };

        // List to store combined data
        List<string[]> combinedData = new List<string[]>();

        // Random number generator
        Random random = new Random();

        try
{
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

    // Print mixed data to the console
    foreach (string[] row in combinedData)
    {
        Console.WriteLine(string.Join(",", row));
    }


    // Write mixed data to a new CSV file
    using (StreamWriter writer = new StreamWriter(@"CSV_Files\MixedTeam.csv"))
    {
        foreach (string[] row in combinedData)
        {
            writer.WriteLine(string.Join(",", row));
        }
    }

    Console.WriteLine($"Data from {csvFiles.Count} CSV files mixed and saved to MixedTeam.csv");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
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
}

