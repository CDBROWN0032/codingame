using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTX = int.Parse(inputs[2]); // Thor's starting X position
        int initialTY = int.Parse(inputs[3]); // Thor's starting Y position
        int thorX = initialTX;
        int thorY = initialTY;
        // game loop
        while (true)
        {
            do {
                int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.
                    //N NE E SE S SW W or NW
                    //Console.WriteLine("SE");
                    if (lightX < thorX && lightY < thorY) {
                        Console.WriteLine("NW");
                        thorX -=1;
                        thorY -=1;
   
                        }
                    else if (lightX > thorX && lightY < thorY) {
                        Console.WriteLine("NE");
                        thorX -=1;
                        thorY +=1;

                        }
                    else if (lightX > thorX && lightY > thorY) {
                        Console.WriteLine("SE");
                        thorX +=1;
                        thorY +=1;
                
                        }
                    else if (lightX < thorX && lightY > thorY) {
                        Console.WriteLine("SW");
                        thorX -=1;
                        thorY +=1;

                    } else {
                    if (lightX < thorX) {
                        Console.WriteLine("W");
                        thorX -=1;
                       
                        }
                    else if (lightX > thorX) {
                        Console.WriteLine("E");
                        thorX +=1;
                       
                        }
                        
                    if (lightY < thorY) {
                        Console.WriteLine("N");
                        thorY -=1;
                        }
                    else if (lightY > thorY) {
                        Console.WriteLine("S");
                        thorY +=1;
                    }
                }
                    
            } while (lightX != thorX && lightY != thorY);
        }
    }
}
