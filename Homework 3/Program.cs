//using Microsoft.VisualBasic;
//using System.Dynamic;

//namespace Homework_3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter a a 4 digit year: ");
//            string fourDigitYear = Console.ReadLine();

//            if (int.TryParse(fourDigitYear, out int year) && year >= 0)
//            {
//                int sum = 0;

//                while (year > 0)
//                {
//                    sum += year % 10;
//                    year /= 10;
//                }
//                Console.WriteLine("The total of the digits in the year is: " + sum);
//            }
//        }
//    }
//}

//using Microsoft.VisualBasic;
//using System.Dynamic;

//namespace Homework_3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a sentance to check if they are pangrams: ");
//            while (true)
//            {
//                Console.Write("Enter a sentance: ");
//                string input = Console.ReadLine();

//                if (string.IsNullOrWhiteSpace(input))
//                    break;

//                bool isPangram = IsPangram(input);
//                Console.WriteLine(isPangram ? "True" : "False");
//            }
//        }

//        static bool IsPangram(string input)
//        {
//            input = input.ToUpper();

//            var letterSet = new HashSet<char>();

//            foreach (char c in input)
//            {
//                if (char.IsLetter(c))
//                {
//                    letterSet.Add(c);
//                }
//            }

//            return letterSet.Count == 26;
//        }
//    }
//}

//using Microsoft.VisualBasic;
//using System.Dynamic;

//namespace Homework_3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter a word: ");
//            string input = Console.ReadLine();

//            if (IsPalindrome(input))
//            {
//                Console.WriteLine("the word is a palidrome");
//            }
//            else
//            {
//                Console.WriteLine("the word is not a palidrome");
//            }
//        }

//        static bool IsPalindrome(string Pali)
//        {
//            Pali = Pali.Replace(" ", "").ToLower();

//            int left = 0;
//            int right = Pali.Length - 1;

//            while (left < right)
//            {
//                if (Pali[left] != Pali[right])
//                {
//                    return false;
//                }

//                left++;
//                right--;
//            }

//            return true;
//        }
//    }
//}

//using Microsoft.VisualBasic;
//using System.Dynamic;

//namespace Homework_3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("welcom to my caesar cipher tool");
//            Console.WriteLine("press 1 to encrypt");
//            Console.WriteLine("press 2 to decrypt");           

//            if (int.TryParse(Console.ReadLine(), out int option) && (option == 1 || option == 2))
//            {
//                Console.Write("enter the message you want to encrypt or decrypt ");
//                string input = Console.ReadLine().ToUpper(); 

//                Console.Write("enter a encrytion key ");
//                if (int.TryParse(Console.ReadLine(), out int key) && key >= 1 && key <= 25)
//                {
//                    if (option == 1)
//                    {
//                        string encryptedMessage = Encrypt(input, key);
//                        Console.WriteLine("encrypted message " + encryptedMessage);
//                    }
//                    else
//                    {
//                        string decryptedMessage = Decrypt(input, key);
//                        Console.WriteLine("decrypted message " + decryptedMessage);
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("key must be within 1-25 !");
//                }
//            }
//            else
//            {
//                Console.WriteLine("answer must be either 1 or 2");
//            }
//        }

//        static string Encrypt(string message, int key)
//        {
//            string encrypted = "";
//            foreach (char letter in message)
//            {
//                if (char.IsLetter(letter))
//                {
//                    char shifted = (char)(letter + key);
//                    if (shifted > 'Z')
//                    {
//                        shifted = (char)(shifted - 26); 
//                    }
//                    encrypted += shifted;
//                }
//                else
//                {
//                    encrypted += letter; 
//                }
//            }
//            return encrypted;
//        }

//        static string Decrypt(string message, int key)
//        {
//            string decrypted = "";
//            foreach (char letter in message)
//            {
//                if (char.IsLetter(letter))
//                {
//                    char shifted = (char)(letter - key);
//                    if (shifted < 'A')
//                    {
//                        shifted = (char)(shifted + 26); 
//                    }
//                    decrypted += shifted;
//                }
//                else
//                {
//                    decrypted += letter; 
//                }
//            }
//            return decrypted;
//        }
//    }
//}