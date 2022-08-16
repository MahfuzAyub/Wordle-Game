using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine();

            string filePath = @"F:\5_letter_words.txt";
            List<string> Words = new List<string>();
            Words = File.ReadAllLines(filePath).ToList();            

            Console.WriteLine("Please Enter a Guess :");
            string guess = next_guess(Words);
            string actual_word = random_word(Words);

            for (int i = 0; i < 6; i++)
            {
                if (guess == "")
                {
                    Console.WriteLine("Please Enter a Guess :");
                    guess = Console.ReadLine();
                }
                string res = check_guess(guess, actual_word);//    test "taunt", "train"
                if (res == "XXXXX")
                {
                    Console.WriteLine(res+"   You Win!!");
                    break;
                }
                else
                {
                    Console.WriteLine(res +Environment.NewLine);
                    if (i<5)
                    {
                        Console.WriteLine("Please Enter a Guess :");
                        guess = Console.ReadLine();
                    }
                    if (i==5)
                    {
                        Console.WriteLine("You Lost!!. The Word was :  "+ actual_word);
                    }
                }                
            }
            Console.ReadKey();
        }

        private static string random_word(List<string> lst)
        {
            Random numberGen = new Random();
            int random = 0;
            for (int i = 0; i < 1; i++)
            {
                random = numberGen.Next(0, 5749);  //start from begining to 5750.
            }
            string theWord = (lst[random]);
            return theWord;
        }
        private static bool is_real_world(string guess, List<string> lst)
        {
            //will return the true only when it machtes any of the list.
            if (lst.Contains(guess))
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
        private static string check_guess(string guess,string theWord)
        {
            string resuilt = "";
            for (int i = 0; i < 1; i++)
            {
                //Win
                if (guess.ToLower() == theWord)
                {
                    resuilt = "XXXXX";
                    break;
                }
                else
                if (!isUniqueLetter(theWord) &&isUniqueLetter(guess))       //target can have same character multiple times but the guess has unique characters.
                {
                    {
                        char a = theWord[0];
                        char b = theWord[1];
                        char c = theWord[2];
                        char d = theWord[3];
                        char e = theWord[4];

                        char _a = guess[0];
                        char _b = guess[1];
                        char _c = guess[2];
                        char _d = guess[3];
                        char _e = guess[4];

                        //First Letter Guess
                        if (a == _a)
                        {
                            resuilt += "X";
                        }
                        else if (b == _a)
                        {
                            resuilt += "0";
                        }
                        else if (c == _a)
                        {
                            resuilt += "0";
                        }
                        else if (d == _a)
                        {
                            resuilt += "0";
                        }
                        else if (e == _a)
                        {
                            resuilt += "0";
                        }
                        else
                        {
                            resuilt += "_";
                        }
                        //Second Letter
                        if (b == _b)
                        {
                            resuilt += "X";
                        }
                        else if (a == _b)
                        {
                            resuilt += "0";
                        }
                        else if (c == _b)
                        {
                            resuilt += "0";
                        }
                        else if (d == _b)
                        {
                            resuilt += "0";
                        }
                        else if (e == _b)
                        {
                            resuilt += "0";
                        }
                        else
                        {
                            resuilt += "_";
                        }

                        //Third Letter
                        if (c == _c)
                        {
                            resuilt += "X";
                        }
                        else if (b == _c)
                        {
                            resuilt += "0";
                        }
                        else if (a == _c)
                        {
                            resuilt += "0";
                        }
                        else if (d == _c)
                        {
                            resuilt += "0";
                        }
                        else if (e == _c)
                        {
                            resuilt += "0";
                        }
                        else
                        {
                            resuilt += "_";
                        }

                        //Fourth Letter
                        if (d == _d)
                        {
                            resuilt += "X";
                        }
                        else if (b == _d)
                        {
                            resuilt += "0";
                        }
                        else if (c == _d)
                        {
                            resuilt += "0";
                        }
                        else if (a == _d)
                        {
                            resuilt += "0";
                        }
                        else if (e == _d)
                        {
                            resuilt += "0";
                        }
                        else
                        {
                            resuilt += "_";
                        }

                        //Fifth Letter
                        if (e == _e)
                        {
                            resuilt += "X";
                        }
                        else if (b == _e)
                        {
                            resuilt += "0";
                        }
                        else if (c == _e)
                        {
                            resuilt += "0";
                        }
                        else if (d == _e)
                        {
                            resuilt += "0";
                        }
                        else if (a == _e)
                        {
                            resuilt += "0";
                        }
                        else
                        {
                            resuilt += "_";
                        }
                    }
                }
                else   // if the target word has uniqe characters and the guess duplicate characters .
                {
                    char a = theWord[0];
                    char b = theWord[1];
                    char c = theWord[2];
                    char d = theWord[3];
                    char e = theWord[4];

                    char _a = guess[0];
                    char _b = guess[1];
                    char _c = guess[2];
                    char _d = guess[3];
                    char _e = guess[4];

                    //First Letter Guess
                    if (a == _a)
                    {
                        resuilt += "X";
                    }
                    else if (b == _a)
                    {
                        resuilt += "0";
                    }
                    else if (c == _a )
                    {
                        resuilt += "0";
                    }
                    else if (d == _a )
                    {
                        resuilt += "0";
                    }
                    else if (e == _a )
                    {
                        resuilt += "0";
                    }
                    else
                    {
                        resuilt += "_";
                    }
                    //Second Letter
                    if (b == _b)
                    {
                        resuilt += "X";
                    }
                    else if (a == _b )
                    {
                        resuilt += "0";
                    }
                    else if (c == _b && (_a != _b))
                    {
                        resuilt += "0";
                    }
                    else if (d == _b && (_a != _b))
                    {
                        resuilt += "0";
                    }
                    else if (e == _b && (_a != _b) )
                    {
                        resuilt += "0";
                    }
                    else
                    {
                        resuilt += "_";
                    }

                    //Third Letter
                    if (c == _c)
                    {
                        resuilt += "X";
                    }
                    else if (b == _c && (_c != _b) && (_c != _a))
                    {
                        resuilt += "0";
                    }
                    else if (a == _c && (_c != _b) && (_c != _a))
                    {
                        resuilt += "0";
                    }
                    else if (d == _c && (_c != _b) && (_c != _a))
                    {
                        resuilt += "0";
                    }
                    else if (e == _c && (_c != _b) && (_c != _a))
                    {
                        resuilt += "0";
                    }
                    else
                    {
                        resuilt += "_";
                    }

                    //Fourth Letter
                    if (d == _d)
                    {
                        resuilt += "X";
                    }
                    else if (b == _d && (_d != _a) && (_d != _b) && (_d != _c) )
                    {
                        resuilt += "0";
                    }
                    else if (c == _d && (_d != _a) && (_d != _b) && (_d != _c) )
                    {
                        resuilt += "0";
                    }
                    else if (a == _d && (_d != _a) && (_d != _b) && (_d != _c) )
                    {
                        resuilt += "0";
                    }
                    else if (e == _d && (_d != _a) && (_d != _b) && (_d != _c) )
                    {
                        resuilt += "0";
                    }
                    else
                    {
                        resuilt += "_";
                    }

                    //Fifth Letter
                    if (e == _e)
                    {
                        resuilt += "X";
                    }
                    else if (b == _e && (_e != _a) && (_e != _b) && (_e != _c) && (_e != _d))
                    {
                        resuilt += "0";
                    }
                    else if (c == _e && (_e != _a) && (_e != _b) && (_e != _c) && (_e != _d))
                    {
                        resuilt += "0";
                    }
                    else if (d == _e && (_e != _a) && (_e != _b) && (_e != _c) && (_e != _d))
                    {
                        resuilt += "0";
                    }
                    else if (a == _e && (_e != _a) && (_e != _b) && (_e != _c) && (_e != _d))
                    {
                        resuilt += "0";
                    }
                    else
                    {
                        resuilt += "_";
                    }
                }
                //Console.WriteLine("The Word Was: " + theWord);                                      
            }
            return resuilt;
        }
        private static string next_guess(List<string>lst)
        {
            //will return the guess only when it machtes any of the list.
            string guess = "";            
            guess = Console.ReadLine();
            while (!lst.Contains(guess.ToLower()))
            {
                Console.WriteLine("That's not a real word!");
                guess = Console.ReadLine();
            }
            return guess;
        }
        private static bool isUniqueLetter(string str)
        {
            for (int i = 0; i < str.Length; i++)
                for (int j = i + 1; j < str.Length; j++)
                    if (str[i] == str[j])
                        return false;
            return true;
        }
    }    
}
