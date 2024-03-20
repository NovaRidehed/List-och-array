namespace List_och_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testTal = { 1, 2, 3 };

            // Summan
            Console.WriteLine("Demonstration av Summan:");
            Console.WriteLine("Summan av "+ string.Join(", ", testTal) +" är: " + Summan(testTal));

            // Största talet
            Console.WriteLine();
            Console.WriteLine("Demonstration av Största talet:");
            Console.WriteLine("Största talet av " + string.Join(", ", testTal) + " är: " + Största(testTal)); // TODO
        }

        public static int Summan(int[] listOfNumbers)
        {
            int sum = 0; 
            for(int i = 0; i < listOfNumbers.Length; i++)
            {
                sum = sum + listOfNumbers[i];
            }
            // TODO gör beräkningen här

            return sum;
        }
        public static int Största(int[] listOfNumbers)
        {
            int största = 0;
            for (int i = 0; i < (listOfNumbers.Length -1); i++)
            {
                if (listOfNumbers[i] > listOfNumbers[i + 1])
                {
                    största = listOfNumbers[i];
                }
                else
                {
                    största = listOfNumbers[(i + 1)];
                }

            }
            return största;
        }
    }

}