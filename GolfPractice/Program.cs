using System;

namespace GolfPractice
{
    class Program
    {   //these vars are for number spelling
        static string w;
        static int u;

        //lyric and day vars for twelfth day of xmas
        static int d = 12;
        static int da;
        static string[] lyr = new string[]
            {

                "Twelve Drummers Drumming,",
                "Eleven Pipers Piping,",
                "Ten Lords-a-Leaping,",
                "Nine Ladies Dancing,",
                "Eight Maids-a-Milking,",
                "Seven Swans-a-Swimming,",
                "Six Geese-a-Laying,",
                "Five Gold Rings,",
                "Four Calling Birds",
                "Three French Hens,",
                "Two Turtle Doves, and",
                "A Partridge in a Pear Tree."
            };
        static string[] day = new string[]
        {
                "First","Second","Third","Fourth","Fifth","Sixth", "Seventh",
                "Eighth", "Nineth","Tenth", "Eleventh","Twelfth"
        };

        //cube vars
        static int c;
        static void Main(string[] args)
        {
            //FizzBizzGolf();

            //Spell the numbers. THis one needs a string[] of args to work
            //for (int t = 0; t < args.Length; t++)
            //{
            //    long num = Int64.Parse(args[t]);
            //    u = Convert.ToInt32(num);
            //    n2w(u);
            //    Console.WriteLine(w);
            //}


            //twelve days of christmas
            //TwelveDaysXmas();

            //Cube Drawing
            for (c = 0; c < 7; c++) {
                char[] space = new char[] { ' ', };
                char corner = '█';
                char diag = '╱';
                char horiz = '─';
                char vert = '|';
                //output first line
                Console.WriteLine((space[0] * c+1) , corner, 4 * horiz * c + 1, corner);
            }
            
             







        }
        public static string n2w (int i)
        {
            w = "";
            var on = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var ten = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (i == 1000)
                w = "one thousand";
            if (i == 0)
                w = "zero";
            else if ((i / 100) > 0 && i != 1000)
            {
                w += n2w(i / 100) + " hundred ";
                i %= 100;
            }

                if (i > 0 && i != 1000)
                {
                    if (w != "")
                        w += "and ";
                    if (i < 20)
                        w += on[i];
                    else
                    {
                        w += ten[i / 10];
                        if ((i % 10) > 0)
                            w += "-" + on[i % 10];
                    }
                }
            
            
           
            return w;
            

            

        }
        static void cw (string s )
        {
            Console.WriteLine(s);
        }
        static void FizzBizzGolf()
        {
            for (int i = 1; i < 101; i++)
            {
                string b = "Buzz";
                string f = "Fizz";
                if (i % 15 == 0)
                    cw(f + b);
                else if (i % 5 == 0)
                    cw(b);
                else if (i % 3 == 0)
                    cw(f);
                else
                    cw(i.ToString());
            }
        }
        static void TwelveDaysXmas()
        {
            do
            {
                Console.WriteLine($"On the {day[da]} day of Christmas \nMy true love sent to me");


                for (int t = da; t >= 0; t--)
                {


                    Console.WriteLine(lyr[11 - t]);


                }
                
                d--;
                da++;
                Console.WriteLine("\n");
            } while (d > 0);
        }
    }
}
