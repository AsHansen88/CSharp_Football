/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using CSV_Generator;

namespace FOOTBALL{


class Program
{
    public static void Main()
    {
        StandingsDisplay standingsDisplay = new StandingsDisplay();
          standingsDisplay.DisplayStandings();

      CSV_Generator csv_generator = new CSV_Generator();
           csv_generator.generator();
           
                
}
}
}
