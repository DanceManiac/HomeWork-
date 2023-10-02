using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_
{
    internal class Program
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public void PrintUpperCase(string input)
        {
            Console.WriteLine(input.ToUpper());
        }

        public List<int> GetEvenNumbers(List<int> numbers)
        {
            return numbers.Where(num => num % 2 == 0).ToList();
        }

        public int TotalLength(List<string> strings)
        {
            return strings.Sum(str => str.Length);
        }

        public double Average(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return 0.0;
            }
            return (double)numbers.Sum() / numbers.Count;
        }

        public List<string> ChangeCase(List<string> strings)
        {
            return strings.Select(str => char.ToUpper(str[0]) + str.Substring(1).ToLower()).ToList();
        }

        public List<string> UppercaseWords(List<string> words)
        {
            return words.Where(word => word.All(char.IsUpper)).ToList();
        }

        static void Main(string[] args)
        {
        }
    }
}
