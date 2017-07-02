using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculusCoursework
{
    class Program
    {
        static void Main(string[] args)
        {
            double limit = 20;
            //This variable is for how many integers the program checks
            double difference = 1;
            //The gain of said integer for each pass
            int count = 0;
            //This variable is here to count how many values the program outputs
            for (double a = 0; a <= limit; a = a + difference)
            { //This loop is generating the values for a in y=ax^2+bx+c
                for (double b = 0; b <= limit; b = b + difference)
                { //This loop is generating the values for b in y=ax^2+bx+c
                    for (double m = 0; m <= limit; m = m + difference)
                    { //This loop is generating the values for m in y=mx+c
                        for (double c1 = 0; c1 <= limit; c1 = c1 + difference)
                        { //This loop is generating the values for c in y=mx+c
                            for (double c2 = 0; c2 <= limit; c2 = c2 + difference)
                            { //This loop is generating the values for c in y=ax^2+bx+c
                                for (double x2 = 1; x2 <= limit; x2 = x2 + difference)
                                { //This loop is generating the values for the higher x co-ordinate
                                    for (double x1 = 0; x1 <= limit; x1 = x1 + difference)
                                    { //This loop is generating the values for the lower x co-ordinate
                                        if (x2 > x1)
                                        { //This if statement is for efficiency, there is no need to do any calculations if x1 is >= to x2
                                            double answer1 = (a * x1 * x1) + (b * x1) + c2;
                                            //Calculating y1
                                            double answer2 = (a * x2 * x2) + (b * x2) + c2;
                                            //Calculating y2
                                            double answer3 = (m * x1) + c1;
                                            //Calculating y1
                                            double answer4 = (m * x2) + c1;
                                            //Calculating y2
                                            double answer5 = 0.5 * (answer3 + answer4) * (x2 - x1);
                                            //Calculating the area of the trapezium formed by the line, the x axis and the two x co-ordinates
                                            double answer6 = ((a / 3) * (x2 * x2 * x2)) + ((b / 2) * (x2 * x2)) + (c2 * x2) - ((a / 3) * (x1 * x1 * x1)) - ((b / 2) * (x1 * x1)) - (c2 * x1);
                                            //Calculating the area under the curve via intergration, using x2 as the higher limit and x1 as the lower limit
                                            if (answer5 - answer6 == 1 && answer1 == answer3 && answer2 == answer4)
                                            { //Three checks, does the area of the trapezium minus the area under the curve equal 1? Does y1=y1 in both equations? Does y2=y2 in both equations? If so then the program outputs the answer to the console
                                                Console.WriteLine("y = " + m + "x + " + c1 + " and y = " + a + "x^2 + " + b + "x + " + c2 + " at (" + x1 + ", " + answer3 + ") and (" + x2 + ", " + answer4 + ").");
                                                count++; //increases count by 1
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Done: " + count);
            //Lets the user know the program is done and how many results it found
            Console.ReadLine();
            //Stops the program from instantly closing when it finishes by waiting for an input
        }
    }
}
