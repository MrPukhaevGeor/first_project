using System.Linq.Expressions;

namespace sueta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string word = Console.ReadLine();
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = [1, 2, 3, 4, 7];
            //double s = Convert.ToDouble(Console.ReadLine());
            char s = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(TranslationCapitalLetter(s));
        }
        static bool CheckParity(int num)//1
        {
            bool check = false;
            if (num % 2 == 0)
            {
                check = true;

            }
            return check;

        }
        static int Factorial(int num)//2
        {
            int factorial = 1;
            for (int i = 1; i<=num; i++)
            {
                factorial = i * factorial;
            }
            return factorial;
        }
        static int CountVowels(string word)//3
        {
            string vowels = "aeiouy";
            int countVowels = 0;
            foreach (char c in word)
            {
				if (vowels.Contains(c))
				{
					countVowels++;
				}
			}
            return countVowels;
        }
        static bool FindPolindrom(string word)//4
        {
            bool polindrom = false;
            string newString = "";
            for (int i = word.Length - 1;i >= 0; i--)
            {
                newString.Append(word[i]);
            }
            if (newString == word)
            {
                polindrom = true;
            }
            Console.Write(newString + " ");
            return polindrom;
        }
        static int FindMax(int[] numbers)//5
        {
			int max = numbers[1];
			for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            return max;
        }
        static bool FindPrimeNum(int num)//6
        {
            bool primeNum = false;
            if (num < 2)
                return primeNum;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return primeNum;
                }
            }
            primeNum = true;
            return primeNum;
        }
        static char TranslationCapitalLetter(char s)//7
        {
            char[] Letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];

			for (int i = 0; i < Letters.Length - 1; i++)
            {
                if (s == Letters[i])
                {
                    s = char.ToUpper(s);
                }
            }
            return s;
        }
        static string MakeCamelCase(string word)//8
        {
            string[] words = word.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 1)
                return words[0].ToLower();
            string result = words[0].ToLower();
            for (int i = 1; i < words.Length; i++)
            {
                string wordy = words[i];
                if (!string.IsNullOrEmpty(wordy))
                {
                    result += char.ToUpper(wordy[0]) + wordy.Substring(1).ToLower();
                }
            }

            return result;
        }
        static bool ValidPhoneNumber(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;
            string[] parts = word.Split('-');
            if (parts.Length != 5)
                return false;
            if (parts[0] != "+7")
                return false;

            if (parts[1].Length != 3 || !IsAllDigits(parts[1])) return false;
            if (parts[2].Length != 3 || !IsAllDigits(parts[2])) return false;
            if (parts[3].Length != 2 || !IsAllDigits(parts[3])) return false;
            if (parts[4].Length != 2 || !IsAllDigits(parts[4])) return false;

            return true;
        }
        static bool IsAllDigits(string word)//9
        {
            foreach (char c in word)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
        static string FormatMoney(double s)//10
        {
            return s.ToString("N2").Replace(",", " ");
        }
        static int[] WithdrawMoneySimple(int num, int[] numbers)//11
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            int[] counts = new int[numbers.Length];
            int remaining = num;

            for (int i = 0; i < numbers.Length; i++)
            {
                counts[i] = remaining / numbers[i];
                remaining %= numbers[i];
            }
            if (remaining != 0)
                return new int[0];

            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < counts[i]; j++)
                {
                    result.Add(numbers[i]);
                }
            }
            return result.ToArray();
        }
    }
}
