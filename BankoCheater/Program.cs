namespace BankoCheater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize Rasmus's rows
            int[] rasmus1Row1 = new int[] { 1, 20, 32, 71, 80 };
            int[] rasmus1Row2 = new int[] { 3, 11, 21, 38, 44 };
            int[] rasmus1Row3 = new int[] { 15, 29, 49, 58, 68 };

            // Initialize Allan's rows
            int[] allan1Row1 = new int[] { 2, 19, 31, 70, 81 };
            int[] allan1Row2 = new int[] { 4, 12, 22, 37, 43 };
            int[] allan1Row3 = new int[] { 16, 28, 48, 57, 67 };

            // Create a dictionary to hold all players' rows
            Dictionary<string, Dictionary<string, int[]>> playersRows = new Dictionary<string, Dictionary<string, int[]>>();

            // Add Rasmus's rows
            playersRows.Add("Rasmus", new Dictionary<string, int[]>
            {
                { "Row1Rasmus", rasmus1Row1 },
                { "Row2Rasmus", rasmus1Row2 },
                { "Row3Rasmus", rasmus1Row3 }
            });

            // Add Allan's rows
            playersRows.Add("Allan", new Dictionary<string, int[]>
            {
                { "Row1Allan", allan1Row1 },
                { "Row2Allan", allan1Row2 },
                { "Row3Allan", allan1Row3 }
            });

            // Initialize counters for all rows on each plate
            int row1CounterRasmus = 0;
            int row2CounterRasmus = 0;
            int row3CounterRasmus = 0;
            int row1CounterAllan = 0;
            int row2CounterAllan = 0;
            int row3CounterAllan = 0;

            bool fullPlate = false;

            do
            {
                Console.Write("Enter the pulled number: ");
                try
                {
                    int selectedNumber = int.Parse(Console.ReadLine());

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
                        Console.WriteLine("BANKO! Row1 Rasmus");
                        row1CounterRasmus++;
                    }

                    if (row2CounterRasmus == 5)
                    {
                        Console.WriteLine("BANKO! Row2 Rasmus");
                        row2CounterRasmus++;
                    }

                    if (row3CounterRasmus == 5)
                    {
                        Console.WriteLine("BANKO! Row3 Rasmus");
                        row3CounterRasmus++;
                    }

                    // Check Allan's row count
                    if (row1CounterAllan == 5)
                    {
                        Console.WriteLine("BANKO! Row1 Allan");
                        row1CounterAllan++;
                    }

                    if (row2CounterAllan == 5)
                    {
                        Console.WriteLine("BANKO! Row2 Allan");
                        row2CounterAllan++;
                    }

                    if (row3CounterAllan == 5)
                    {
                        Console.WriteLine("BANKO! Row3 Allan");
                        row3CounterAllan++;
                    }

                    // Check for full plate on each plate
                    if (row1CounterRasmus == 6 && row2CounterRasmus == 6 && row3CounterRasmus == 6)
                    {
                        fullPlate = true;
                    }
                    if (row1CounterAllan == 6 && row2CounterAllan == 6 && row3CounterAllan == 6)
                    {
                        fullPlate = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numbers only.");
                }
            } while (fullPlate == false);

            // Announce if either has a full plate
            Console.WriteLine("FULL PLATE!");
        }
    }
}