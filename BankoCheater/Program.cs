namespace BankoCheater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rasmus1Row1 = new int[] { 1, 20, 32, 71, 80 };
            int[] rasmus1Row2 = new int[] { 3, 11, 21, 38, 44 };
            int[] rasmus1Row3 = new int[] { 15, 29, 49, 58, 68 };

            Dictionary<string, int[]> dic = new Dictionary<string, int[]>();
            dic.Add("Rasmus1-row1", rasmus1Row1);
            dic.Add("Rasmus1-row2", rasmus1Row2);
            dic.Add("Rasmus1-row3", rasmus1Row3);

            int row1Counter = 0;
            int row2Counter = 0;
            int row3Counter = 0;

            /*foreach (KeyValuePair<string, int[]> dict in dic)
            {
                string currentArrayKey = dict.Key;
                int[] currentArrayValues = dict.Value;
                int targetNumber = 11;

                if (currentArrayValues.Contains(targetNumber))
                {
                    Console.WriteLine($"{targetNumber} er i {currentArrayKey}");
                }
            }*/

            int selectedNumber;

            do
            {
                Console.Write("Enter a number: ");
                selectedNumber = int.Parse(Console.ReadLine());

                foreach (var row in dic)
                {
                    if (row.Value.Contains(selectedNumber))
                    {
                        switch (row.Key)
                        {
                            case "Rasmus1-row1":
                                row1Counter++;
                                break;
                            case "Rasmus1-row2":
                                row2Counter++;
                                break;
                            case "Rasmus1-row3":
                                row3Counter++;
                                break;
                        }
                    }
                }

                if (row1Counter == 5)
                {
                    Console.WriteLine("BANKO! Row1");
                }
                if (row2Counter == 5)
                {
                    Console.WriteLine("BANKO! Row2");
                }
                if (row3Counter == 5)
                {
                    Console.WriteLine("BANKO! Row3");
                }

            } while (row1Counter != 5 && row2Counter != 5 && row3Counter != 5);

            Console.WriteLine("FULD PLADE!");







            /*int[] rasmus1Row1 = { 1, 20, 32, 71, 80 };
            int[] rasmus1Row2 = { 3, 11, 21, 38, 44 };
            int[] rasmus1Row3 = { 15, 29, 49, 58, 68 };

            Dictionary<string, Array> dic = new Dictionary<string, Array>();
            dic.Add("Rasmus1-row1", rasmus1Row1);
            dic.Add("Rasmus1-row2", rasmus1Row2);
            dic.Add("Rasmus1-row3", rasmus1Row3);

            foreach (KeyValuePair<string, Array> dict in dic)
            {
                Array currentArray = dict.Value;
                Console.WriteLine(currentArray);
                break;
                //Console.WriteLine(rasmus1Row1[0]);

                /*if (dict.Value.Equals("68"))
                {
                    Console.WriteLine("ja");
                }

            }*/



            /*
            dic.Add("Rasmus1-row1", "1    20 32           71 80");
            dic.Add("Rasmus1-row2", "3 11 21 38 44            ");
            dic.Add("Rasmus1-row3", "  15 29    49 58 68      ");
            */

            /*
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Rasmus1-row1", "1,    20,32,          71,80");
            dic.Add("Rasmus1-row2", "3,11,21,38,44            ");
            dic.Add("Rasmus1-row3", "  15,29,    49,58,68      ");
            foreach (KeyValuePair<string, string> dict in dic)
            {
                Console.WriteLine(dict.Value.Split(","));
                if (dict.Value.Equals("68"))
                {
                    Console.WriteLine("ja");
                }
                
            }
            */
        }
    }
}
