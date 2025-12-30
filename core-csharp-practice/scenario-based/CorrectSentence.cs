//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
//namespace bridge.Senario
//{
//    internal class CorrectSentence
//    {
//        public void StringOperationMenu(string paragraph)  //method which show us the menu and also calling the methods to perform task according to what operation we select
//        {
//            while (true)
//            {
//                Console.WriteLine();
//                Console.WriteLine("CHOOSE WHAT OPERATION YOU WANT TO DO");
//                Console.WriteLine();
//                Console.WriteLine("PRESS 1- FOR ADD SPACE AFTER PUNCTUATION");
//                Console.WriteLine("PRESS 2- FOR CAPITALIZING THE FIRST LETTER AFTER EVERY PERIOD/QUESTION/EXCLAMATION MARK");
//                Console.WriteLine("PRESS 3- FOR REMOVING EXTRA SPACES");
//                Console.WriteLine("PRESS 4- TO COUNT THE NUMBER OF WORDS");
//                Console.WriteLine("PRESS 5- TO PRINT THE LONGEST WORD");
//                Console.WriteLine("PRESS 6- REPLACE ALL OCCURRENCE OF A WORD WITH ANOTHER WORD (CASE-SENSITIVE)");
//                Console.WriteLine("PRESS 7- TO HANDLE EDGE CASES LIKE EMPTY STRING OR PARAGRAPH WITH ONLY SPACES");
//                Console.WriteLine("PRESS 8- TO EXIT");
//                Console.WriteLine();
//                int operation = int.Parse(Console.ReadLine());  //enter a int value according to the menu
//                switch (operation)  //  handles which method need to call
//                {
//                    case 1:
//                        Console.WriteLine(SpaceAfterPunctuation(paragraph));
//                        break;
//                    case 2:
//                        Console.WriteLine(CapitalLetterAfterPunctuation(paragraph));
//                        break;
//                    case 3:
//                        Console.WriteLine(RemoveSpace(paragraph));
//                        break;
//                    case 4:
//                        Console.WriteLine(NumberOfWords(paragraph));
//                        break;
//                    case 5:
//                        Console.WriteLine(PrintLongestWord(paragraph));
//                        break;
//                    case 6:
//                        Console.WriteLine(ReplaceWord(paragraph));
//                        break;
//                    case 7:
//                        HandleErrors(paragraph);
//                        break;
//                    case 8:
//                        return;
//                    default:
//                        Console.WriteLine("Invalid Operation");
//                        break;

//                }
//                Console.WriteLine();
//            }
//        }
//        //method to remove extra space
//        public static string RemoveSpace(string paragraph)
//        {
//            string res = "";
//            bool space = false;
//            for (int i = 0; i < paragraph.Length; i++)
//            {
//                if (paragraph[i] != ' ')
//                {
//                    res += paragraph[i];
//                    space = false;
//                }
//                else
//                {
//                    {
//                        if (!space)
//                        {
//                            res += paragraph[i];
//                            space = true;
//                        }
//                    }
//                }
//            }
//            return res;

//        }
//        //method add space after evry punctuation(. ! ?)
//        public static string SpaceAfterPunctuation(string paragraph)
//        {
//            string res = "";
//            bool space = false;
//            for (int i = 0; i < paragraph.Length; i++)
//            {
//                char c = paragraph[i];
//                if (c == '.' || c == '?' || c == '!')
//                {
//                    res += c;
//                    space = true;
//                }
//                else if (c == ' ')
//                {
//                    if (!space)
//                    {
//                        res += c;
//                    }
//                }
//                else
//                {
//                    if (space)
//                    {
//                        res += ' ';
//                        space = false;

//                    }
//                    res += c;
//                }

//            }
//            return res;
//        }
//        //method capatlize the nextletter after the punctuation(. ?!)
//        public static string CapitalLetterAfterPunctuation(string paragraph)
//        {
//            string res = "";
//            bool ca = true;
//            for (int i = 0; i < paragraph.Length; i++)
//            {
//                char c = paragraph[i];
//                if (c == '.' || c == '?' || c == '!')
//                {
//                    res += c;
//                    ca = true;
//                }
//                else if (c >= 'a' && c <= 'z')
//                {
//                    if (ca)
//                    {
//                        res += (char)(c - 32);
//                        ca = false;
//                    }
//                    else res += c;

//                }
//                else if (c >= 'A' && c <= 'Z')
//                {
//                    res += c;
//                    ca = false;
//                }
//                else
//                {
//                    res += c;



//                }



//            }
//            return res;
//        }
//        //thos method finds the number of words in the sentence

//        public static int NumberOfWords(string s)
//        {
//            int res = 0;
//            bool w = false;
//            for (int i = 0; i < s.Length; i++)
//            {
//                if (s[i] != ' ')
//                {
//                    if (!w)
//                    {
//                        res++;
//                        w = true;
//                    }
//                }
//                else
//                {
//                    w = false;
//                }
//            }
//            return res;
//        }

//        //method to print longest Word
//        public static string PrintLongestWord(string s)
//        {
//            string cur = "";
//            string res = "";
//            for (int i = 0; i < s.Length; i++)
//            {
//                if (s[i] != ' ') cur += s[i];
//                else
//                {
//                    if (cur.Length > res.Length) res = cur;
//                    cur = "";
//                }
//            }
//            if (cur.Length > res.Length) res = cur;
//            return res;


//        }
//        //method to replace the word with another word
//        public static string ReplaceWord(string s)
//        {
//            string res = "";
//            Console.WriteLine("Enter word that u want to replace ");
//            string w1 = Console.ReadLine();
//            Console.WriteLine("Enter word that u want to replace with");
//            string w2 = Console.ReadLine();
//            string curr = "";
//            for (int i = 0; i < s.Length; i++)
//            {
//                if (s[i] != ' ') curr += s[i];
//                else
//                {
//                    bool find = false;
//                    if (curr.Length == w1.Length)
//                    {
//                        find = true;
//                        for (int j = 0; j < curr.Length; j++)
//                        {
//                            char c1 = curr[j];
//                            char c2 = w1[j];
//                            if (c1 >= 'A' && c1 <= 'Z') c1 = (char)(c1 + 32);
//                            if (c2 >= 'A' && c2 <= 'Z') c2 = (char)(c2 + 32);
//                            if (c1 != c2)
//                            {
//                                find = false;
//                            }
//                        }
//                    }
//                    res += find ? w2 : curr;
//                    res += ' ';
//                    curr = "";
//                }
//            }
//            if (curr != "")
//            {
//                bool find = false;
//                if (curr.Length == w1.Length)
//                {
//                    find = true;
//                    for (int j = 0; j < curr.Length; j++)
//                    {
//                        char c1 = curr[j];
//                        char c2 = w1[j];
//                        if (c1 >= 'A' && c1 <= 'Z') c1 = (char)(c1 + 32);
//                        if (c2 >= 'A' && c2 <= 'Z') c2 = (char)(c2 + 32);
//                        if (c1 != c2)
//                        {
//                            find = false;
//                            break;
//                        }
//                    }
//                }
//                res += find ? w2 : curr;
//            }
//            return res;
//        }
//        //If user give invalid sentence so this method told user
//        public static void HandleErrors(string paragraph)
//        {
//            if (paragraph.Length == 0)
//            {
//                Console.WriteLine("Invalid input string is empty");
//                return;
//            }
//            bool space = true;
//            for (int i = 0; i < paragraph.Length; i++)
//            {
//                if (paragraph[i] != ' ')
//                {
//                    space = false;
//                    break;
//                }
//            }
//            if (space) Console.WriteLine("Invalid input sting just have spaces");
//            else Console.WriteLine("Valid string");
//        }
//        public static void Main(String[] args)
//        {
//            Console.WriteLine("Enter a sentence");
//            string paragraph = Console.ReadLine(); //enter a string
//            CorrectSentence cs = new CorrectSentence(); //making object of a class
//            cs.StringOperationMenu(paragraph); //calling menu function
//        }
//    }
//}


