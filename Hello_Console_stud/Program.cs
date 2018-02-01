using System;
using System.Linq;
using System.Threading;

namespace Hello_Console_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int) uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                My_strings();
                                Console.WriteLine("");
                                break;
                            case 2:
                                My_Binary();
                                Console.WriteLine("");
                                break;
                            case 3:
                                My_music();
                                Console.WriteLine("");
                                break;
                            case 4:
                                Morse_code();
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message);
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                } while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region ToFromBinary

        static void My_Binary()
        {
            //Implement positive integer variable input

            Console.WriteLine("Enter some nuber to convert it to binary representation");
            //Present it like binary string
            //   For example, 4 as 100
            int x = 0;
            try
            {
                x = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Oooops somes going wrong");
                My_Binary();
            }

            string result = DecToBinConvertation(x);
            
            Console.WriteLine("You enter {0} and it binary value is - {1}", x, result);
            //Use modulus operator to obtain the remainder  (n % 2) 
            //and divide variable by 2 in the loop
            char[] ch = result.ToCharArray();
            //Use the ToCharArray() method to transform string to chararray
            //and Array.Reverse() method
            ch.Reverse();
            Console.WriteLine(ch);
        }

        #endregion

        static string DecToBinConvertation(int num)
        {
            int remainder;
            string result = string.Empty;
            while (num > 0)
            {
                remainder = num % 2;
                num /= 2;
                result = remainder.ToString() + result;
            }
            
            return result;
        }

        #region ToFromUnary

        static void My_strings()
        {
            //Declare int and string variables for decimal and binary presentations

            //Implement two positive integer variables input

            //To present each of them in the form of unary string use for loop

            //Use concatenation of these two strings 
            //Note it is necessary to use some symbol ( for example “#”) to separate

            //Check the numbers on the equality 0
            //Realize the  algorithm for replacing '1#1' to '#' by using the for loop 
            //Delete the '#' from algorithm result

            //Output the result 
        }

        #endregion

        #region My_music

        static void My_music()
        {
            //HappyBirthday
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }

        #endregion

        #region Morse

        static void Morse_code()
        {
            Console.WriteLine("Type some word to hear it in Morse");
            //Create string variable for 'sos'      
            string sos = Console.ReadLine();
            if (sos == "" || sos == " ")
            {
                Morse_code();
            }

            //Use string array for Morse code
            string[,] Dictionary_arr = new string[,]
            {
                {
                    "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                    "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
                },
                {
                    ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ",
                    ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ",
                    ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....",
                    "--...", "---..", "----."
                }
            };
            //Use ToCharArray() method for string to copy charecters to Unicode character array
            char[] ch = sos.ToLower().ToCharArray();
            //Use foreach loop for character array in which
            string musicString = "";
            foreach (var c in ch)
            {
                for (int i = 0; i < Dictionary_arr.GetLength(1); i++)
                {
                    if (Dictionary_arr[0, i] == c.ToString())
                    {
                        musicString += Dictionary_arr[1, i];
                    }
                }
            }

            //Implement Console.Beep(1000, 250) for '.'
            // and Console.Beep(1000, 750) for '-'
            char[] muasicArray = musicString.ToCharArray();
            foreach (var m in muasicArray)
            {
                if (m == '.')
                {
                    Console.Beep(1000, 250);
                }
                else if (m == '-')
                {
                    Console.Beep(1000, 750);
                }

                Thread.Sleep(50);
            }

            //Use Thread.Sleep(50) to separate sounds
            //  
        }

        #endregion
    }
}