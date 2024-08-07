// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Threading.Channels;

namespace Arrays_Concept
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Array array = new Array();  
            Console.WriteLine("enter the no pf elements in array");
            int Index = int.Parse(Console.ReadLine());
            array.GetValue(Index);
        }
    }

    
}