/*
 * Author: Derek Leung
 * Description: http://www.reddit.com/r/dailyprogrammer/comments/2ftcb8/9082014_challenge_179_easy_you_make_me_happy_when/
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Collections;
using System.Drawing;

namespace reddit_challenge_179
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(File.Exists("//psf/Home/Desktop/1 - Motorcycles.png"));

            String input = "";

            Console.WriteLine("Please enter the valid path to the file you wish to convert to grayscale: ");
            input = Console.ReadLine();

            while (!File.Exists(input)){
                Console.WriteLine("The path you entered does not exist.\n");
                Console.WriteLine("Please enter the valid path to the file you wish to convert to grayscale: ");
                input = Console.ReadLine();
            }

            //Directory exists
            Bitmap bmp = new Bitmap(input);
            
            Grayscaler gs = new Grayscaler(bmp);

            gs.ConvertGrayScale();
            bmp = gs.getImage();

            int i = input.LastIndexOf(".");
            if (i > 0)
            {
                input = input.Substring(0, i);
            }
            bmp.Save(input + "-grayscale.png");
            Console.Write("\nGrayscale conversion complete.\n\n The converted image has been saved to the following path: ");
            Console.WriteLine(input);

            
            //prompt the user to close the program 
            Console.Write("\nPress Enter to exit the program.");
            Console.Read();
           
        }
    }
}
