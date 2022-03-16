using System;
using System.IO;
namespace DESAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {            
            string input = File.ReadAllText(@"G:\Прогроммирование\Programm\C#\DESAlgorithm\Text.txt");
            
            string key = "asdfqwer";
            Des Efk1 = new Des(input, key);
            string a = Efk1.Encription();
            Console.WriteLine(a);
            File.WriteAllText(@"G:\Прогроммирование\Programm\C#\DESAlgorithm\Shifr.txt", a);
            string input1 = File.ReadAllText(@"G:\Прогроммирование\Programm\C#\DESAlgorithm\Shifr.txt");
            Des Efk2 = new Des(input1, key);
            string b = Efk2.Dencription();
            File.WriteAllText(@"G:\Прогроммирование\Programm\C#\DESAlgorithm\Deshifr.txt", b);

        }

    }
}
