namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrey1 = [1, 2, 3];
            int[] arrey2 = [4, 5, 6];

            int[] resultArrey = new int[arrey1.Length + arrey2.Length];

            for (int i = 0; i < arrey1.Length; i++)
            {
                resultArrey[i] = arrey1[i];
            }

            for (int i = 0; i < arrey2.Length; i++)
            {
                resultArrey[arrey1.Length + i] = arrey2[i];
            }

            foreach (int i in resultArrey)
            {
                Console.WriteLine(i);
            }
        }
    }
}