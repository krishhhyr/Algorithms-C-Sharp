using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 4, 6, 345, 123, 34, 12, 4, 35 };
            Console.WriteLine("Enter a value:");
            int key = Convert.ToInt32(Console.ReadLine());
            LinearSearch(array, key);

            void LinearSearch(int[] array, int key)
            {
                bool Found = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == key)
                    {
                        Found = true;
                        break;
                    }
                }
                if (Found == true)
                {
                    Console.WriteLine("Found in list.");
                }
                else
                {
                    Console.WriteLine("Not found in list.");
                }
            }

        }
        static void Alternative() 
        {
            int[] dataset = {10, 12, 928, 38, 82, 82, 892, 618, 1, 10  };
            int item = 618;
            bool found = false;
            int position = 0;

            while ((found == false) && (position <= dataset.Length - 1)) 
            {
                if (dataset[position] == item)
                {
                    found = true;
                }
                else 
                {
                    position++;
                }
            }

            if (found == true)
            {
                Console.WriteLine("Item found at " + position);
            }
            else 
            {
                Console.WriteLine("Item not found in list");
            }
        }
    }
}        