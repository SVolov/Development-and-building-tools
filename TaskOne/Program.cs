using System;
using System.Formats.Asn1;
using System.Linq.Expressions;

namespace TaskOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write line, please");
            string line = Console.ReadLine();
            char[] array = new char[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                array[i] = line[i];
            }
            int count = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                var newArray = new List<char>();

                for (int j = i; j < array.Length; j++)
                {
                    if (Check(newArray, array[j]))
                    {
                        newArray.Add(array[j]);
                    }
                    else
                    {
                        break;
                    }
                }
                if (count < newArray.Count)
                {
                    count = newArray.Count;
                }
            }
            Console.WriteLine(count);
        }

        private static bool Check(List<char> list, char element)
        {
            foreach (char item in list)
            {
                if (item == element) return false;
            }
            return true;
        }
    }
}



