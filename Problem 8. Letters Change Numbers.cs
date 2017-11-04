//using System;
//using System.Collections.Generic;

//namespace _08.__Letters_Change_Numbers
//{
//    public class LettersChangeNumbers
//    {
//        public static void Main()
//        {
//            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//            var separatedInput = new List<string>();
//            for (int i = 0; i < input.Length; i++)
//            {
//                separatedInput.Add(input[i]);
//            }
//            var sum = 0.0;
//            foreach (var line in separatedInput)
//            {
//                sum += GetLettersAsNumbers(line);
//            }
//            Console.WriteLine($"{sum:f2}");
//        }

//        private static double GetLettersAsNumbers(string line)
//        {

//            var firstLetter = line[0];
//            var lastLetter = line[line.Length - 1];

//            line = line.Trim(lastLetter);
//            line = line.Trim(firstLetter);

//            var number = double.Parse(line);
//            var firstLetterPos = GetLetterPositon(firstLetter);
//            var lastLetterPos = GetLetterPositon(lastLetter);
//            var sum = 0.0;

//            if (char.IsUpper(firstLetter))
//            {
//                sum = number / firstLetterPos;
//            }
//            else
//            {
//                sum = number * firstLetterPos;
//            }

//            if (char.IsUpper(lastLetter))
//            {
//                sum = sum - lastLetterPos;
//            }
//            else
//            {
//                sum = sum + lastLetterPos;
//            }

//            return sum;
//        }

//        private static int GetLetterPositon(char letter)
//        {
//            var position = 0;
//            if (char.IsUpper(letter))
//            {
//                position = letter - 'A';
//            }
//            else
//            {
//                position = letter - 'a';
//            }
//            return position + 1;
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()    
    {
        decimal sum = 0;
        List<string> input = Console.ReadLine().Split(new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToList();

        for (int i = 0; i < input.Count; i++)
        {
            char[] curent = input[i].ToCharArray();

            decimal curentSum = 0;

            char first = curent[0];
            char last = curent[curent.Length - 1];

            int firstToNumber = char.ToUpper(first) - 64;
            int secoundToNumber = char.ToUpper(last) - 64;

            string number = string.Empty;
            for (int j = 1; j < curent.Length - 1; j++)
            {
                number += curent[j];
            }
            decimal num = decimal.Parse(number);

            if (char.ToUpper(first) == first)
            {
                curentSum += num / firstToNumber;
            }
            else
            {
                curentSum += num * firstToNumber;
            }
            if (char.ToUpper(last) == last)
            {
                curentSum -= secoundToNumber;
            }
            else
            {
                curentSum += secoundToNumber;
            }
            sum += curentSum;
        }
        Console.WriteLine("{0:f2}", sum);
    }
}