using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите исходный массив строк через пробел: ");
        string[] inputArray = Console.ReadLine().Split();
        string[] outputArray = CreateOutputArray(inputArray);
        Console.WriteLine("Новый массив с элементами длиной 3 символа или меньше:");
        foreach (string s in outputArray)
        {
            Console.WriteLine(s);
        }
    }

    static string[] CreateOutputArray(string[] inputArray)
    {
        int count = 0;
        foreach (string s in inputArray)
        {
            if (s.Length <= 3)
            {
                count++;
            }
        }

        string[] outputArray = new string[count];
        int index = 0;
        foreach (string s in inputArray)
        {
            if (s.Length <= 3)
            {
                outputArray[index++] = s;
            }
        }

        return outputArray;
    }
}