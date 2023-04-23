namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Alternative();
        }
        static void Alternative() 
        {
            int[] dataset = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int item = 8;
            int midpoint = 0;
            int lowerbound = 0;
            int upperbound = dataset.Length - 1;
            bool found = false;

            while ((found == false) && (lowerbound <= upperbound)) 
            {
                midpoint = Convert.ToInt16(Math.Round((lowerbound + (upperbound - lowerbound) / 2d)));

                if (dataset[midpoint] == item)
                {
                    found = true;
                }
                else if (dataset[midpoint] < item)
                {
                    lowerbound = midpoint + 1;
                }
                else 
                {
                    upperbound = midpoint - 1;
                }
            }
            if (found == true)
            {
                Console.WriteLine("Item found at " + midpoint);
            }
            else 
            {
                Console.WriteLine("Item not found");
            }
        }
    }
}