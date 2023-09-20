using System;

class StandingsDisplay {

public void DisplayStandings(){


string filePath = @"CSV Files\Dummy.csv";
        StreamReader reader = null;

        if (File.Exists(filePath))
        {
            reader = new StreamReader(File.OpenRead(filePath));
            List<string[]> tableData = new List<string[]>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                tableData.Add(values);
            }

            PrintTable(tableData);
        }
        else
        {
            Console.WriteLine("File doesn't exist");
        }

        Console.ReadLine();
    }

    public static void PrintTable(List<string[]> data)
    {
        int maxLength = data.Max(row => row.Length);
        int[] columnWidths = new int[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            columnWidths[i] = data.Max(row => i < row.Length ? row[i].Length : 0);
        }

        foreach (var row in data)
        {
            for (int i = 0; i < row.Length; i++)
            {
                Console.Write(row[i].PadRight(columnWidths[i] + 2));
            }
            Console.WriteLine();
        }
        }
}
