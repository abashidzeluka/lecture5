namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, -4, 8, 11, 1, -1, 6 };

            int targetSum = 7;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        Console.WriteLine($"[{array[i]}, {array[j]}]");
                    }
                }
            }
        }
    }
}