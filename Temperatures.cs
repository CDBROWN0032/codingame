using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

class Solution
{
    
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        if (n == 0) {
            Console.WriteLine(0);
            } else {
        string[] inputs = Console.ReadLine().Split(' ');
        int a = 0;                          // int to check for all negative values
        int x = 5526;                       // smallest positive value
        int y = -273;                       // smallest negative value
        int z = 0;                          // output
        for (int i = 0; i < n; i++)         
        {
            int t = int.Parse(inputs[i]);   // a temperature expressed as an integer ranging from -273 to 5526
            bool neg = false;
            if (t < 0) {                    // if temp is neg, convert to positive and flag
                t = t * -1;
                neg = true;
                }
            if (t == 0) {                   // if temp is 0, break loop since 0 is perfect answer
                z = 0;
                break;
                }
            else if (t < x ) {              // if temp is less than current lowest temp, set new lowest temp
                x = t;
                if (neg == true) {          // if flagged negative, use Y placeholder for later compare
                    y = x;
                    a++;                    // increment all negative check
                }
            }
        }
        y = y * -1;                         // convert Y placeholder back to negative
        if (a == n-1) {                     // check if all numbers were negative to prevent comparing same number to itself
            z = y;
        }
        else if (x == y * -1) {             // if neg and pos are same int value, positive is correct answer
            z = x;
        }
        else if (y < x) {                   // if Y is less than X, Y is correct answer
            z = y;
        } else {
            z = x;                          // else X is correct answer (last comparison check)
        }
        
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(z);               // answer output
        }
    }
}
