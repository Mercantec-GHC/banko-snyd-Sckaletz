namespace BankoCheater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary to hold all players' rows
            Dictionary<string, Dictionary<string, int[]>> playersRows = new Dictionary<string, Dictionary<string, int[]>>();

            // Initialize counters for all rows on each plate
            int row1CounterRasmus = 0;
            int row2CounterRasmus = 0;
            int row3CounterRasmus = 0;

            int row1CounterAllan = 0;
            int row2CounterAllan = 0;
            int row3CounterAllan = 0;

            bool fullPlate = false;
            bool rasmusFullPlate = false;
            bool allanFullPlate = false;

            // Collect Rasmus's rows
            playersRows.Add("Rasmus", new Dictionary<string, int[]>
            {
                { "Row1Rasmus", CollectRowInput("Rasmus") },
                { "Row2Rasmus", CollectRowInput("Rasmus") },
                { "Row3Rasmus", CollectRowInput("Rasmus") }
            });

            // Collect Allan's rows
            playersRows.Add("Allan", new Dictionary<string, int[]>
            {
                { "Row1Allan", CollectRowInput("Allan") },
                { "Row2Allan", CollectRowInput("Allan") },
                { "Row3Allan", CollectRowInput("Allan") }
            });

            HashSet<int> drawnNumbers = new HashSet<int>();

            do
            {
                Console.Write("Enter the pulled number: ");
                try
                {
                    int selectedNumber = int.Parse(Console.ReadLine());
                    if (selectedNumber < 1 || selectedNumber > 90)
                    {
                        Console.WriteLine("Only numbers between 1 and 90 are valid");
                    }

                    if (drawnNumbers.Contains(selectedNumber))
                    {
                        Console.WriteLine("You have already drawn this number. Please select a different one.");
                        continue; // Restart the loop if the number has already been drawn
                    }

                    drawnNumbers.Add(selectedNumber); // Add the selected number to the set of drawn numbers
                    
                    foreach (var player in playersRows)
                    {
                        foreach (var row in player.Value)
                        {
                            if (row.Value.Contains(selectedNumber))
                            {
                                // If the numbers are found on Rasmus' plate
                                if (row.Key == "Row1Rasmus")
                                {
                                    row1CounterRasmus++;
                                }
                                else if (row.Key == "Row2Rasmus")
                                {
                                    row2CounterRasmus++;
                                }
                                else if (row.Key == "Row3Rasmus")
                                {
                                    row3CounterRasmus++;
                                }

                                // if the numbers are found on Allan's plate
                                if (row.Key == "Row1Allan")
                                {
                                    row1CounterAllan++;
                                }
                                else if (row.Key == "Row2Allan")
                                {
                                    row2CounterAllan++;
                                }
                                else if (row.Key == "Row3Allan")
                                {
                                    row3CounterAllan++;
                                }
                            }
                        }
                    }

                    // Check Rasmus' row count
                    if (row1CounterRasmus == 5)
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("BANKO! Row1 Rasmus");
                        Console.WriteLine("------------------");
                        row1CounterRasmus++;
                    }

                    if (row2CounterRasmus == 5)
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("BANKO! Row2 Rasmus");
                        Console.WriteLine("------------------");
                        row2CounterRasmus++;
                    }

                    if (row3CounterRasmus == 5)
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("BANKO! Row3 Rasmus");
                        Console.WriteLine("------------------");
                        row3CounterRasmus++;
                    }

                    // Check Allan's row count
                    if (row1CounterAllan == 5)
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("BANKO! Row1 Allan");
                        Console.WriteLine("------------------");
                        row1CounterAllan++;
                    }

                    if (row2CounterAllan == 5)
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("BANKO! Row2 Allan");
                        Console.WriteLine("------------------");
                        row2CounterAllan++;
                    }

                    if (row3CounterAllan == 5)
                    {
                        Console.WriteLine("------------------");
                        Console.WriteLine("BANKO! Row3 Allan");
                        Console.WriteLine("------------------");
                        row3CounterAllan++;
                    }

                    // Check for full plate on each plate
                    if (row1CounterRasmus == 6 && row2CounterRasmus == 6 && row3CounterRasmus == 6 && !rasmusFullPlate)
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine("RASMUS FIK FULD PLADE!");
                        Console.WriteLine("----------------------");
                        rasmusFullPlate = true;
                    }
                    if (row1CounterAllan == 6 && row2CounterAllan == 6 && row3CounterAllan == 6 && !allanFullPlate)
                    {
                        Console.WriteLine("---------------------");
                        Console.WriteLine("ALLAN FIK FULD PLADE!");
                        Console.WriteLine("---------------------");
                        allanFullPlate = true;
                    }
                    if (rasmusFullPlate && allanFullPlate)
                    {
                        fullPlate = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numbers only!");
                }
            } while (fullPlate == false);

            // Announce if either has a full plate
            Console.WriteLine("GAME OVER!");
        }

        static int[] CollectRowInput(string playerName)
        {
            Console.WriteLine($"Please type the numbers for the next row for {playerName}:");
            int[] rowNumbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                rowNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return rowNumbers;
        }
    }
}
