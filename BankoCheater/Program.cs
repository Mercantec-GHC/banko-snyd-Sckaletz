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
                { "Row1", rasmus1Row1 },
                { "Row2", rasmus1Row2 },
                { "Row3", rasmus1Row3 }
            });

            // Add Allan's rows
            playersRows.Add("Allan", new Dictionary<string, int[]>
            {
                { "Row1", allan1Row1 },
                { "Row2", allan1Row2 },
                { "Row3", allan1Row3 }
            });

            int row1Counter = 0;
            int row2Counter = 0;
            int row3Counter = 0;
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
                                if (row.Key == "Row1")
                                {
                                    row1Counter++;
                                }
                                else if (row.Key == "Row2")
                                {
                                    row2Counter++;
                                }
                                else if (row.Key == "Row3")
                                {
                                    row3Counter++;
                                }
                            }
                        }
                        
                    }

                    if (row1Counter == 5)
                    {
                        Console.WriteLine("BANKO! Row1");
                        row1Counter++;
                    }

                    if (row2Counter == 5)
                    {
                        Console.WriteLine("BANKO! Row2");
                        row2Counter++;
                    }

                    if (row3Counter == 5)
                    {
                        Console.WriteLine("BANKO! Row3");
                        row3Counter++;
                    }

                    if (row1Counter == 6 && row2Counter == 6 && row3Counter == 6)
                    {
                        fullPlate = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numbers only.");
                }


            } while (fullPlate == false);

            Console.WriteLine("FULL PLATE!");
        }
    }
}