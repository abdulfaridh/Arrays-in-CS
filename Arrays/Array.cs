// See https://aka.ms/new-console-template for more information
namespace Arrays_Concept
{
    public class Array
    {
        public void GetValue(int index)
        {
            int[] array = new int[index];
            Console.WriteLine("enter the values in your array:");
            for (int i = 0;i<index;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("your array is");
            for(int i = 0;i<index;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    
}