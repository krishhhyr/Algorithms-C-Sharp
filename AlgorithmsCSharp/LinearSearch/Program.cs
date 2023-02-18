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
    }
}        