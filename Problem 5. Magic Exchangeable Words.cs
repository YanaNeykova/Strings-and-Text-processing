using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            List<char> firstInput = input[0].ToCharArray().Distinct().ToList();
            List<char> secondInput = input[1].ToCharArray().Distinct().ToList();

            bool exchangeable = firstInput.Count == secondInput.Count;

            Console.WriteLine(exchangeable.ToString().ToLower());
        }
    }
}
