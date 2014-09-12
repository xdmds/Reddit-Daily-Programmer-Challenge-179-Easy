/*
 * Author: Derek Leung
 * Description: Encapsulates all necessary functions to Manipulate the image in 
 *              order to convert it to grayscale
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace reddit_challenge_179
{
    class Grayscaler
    {
        private Bitmap bmp;

        /*
         * Creates a Grayscaler object
         * 
         * Parameters: 
         *  bmp (Bitmap) - the image to be converted to grayscale  
         */ 
        public Grayscaler(Bitmap bmp)
        {
            this.bmp = bmp;
        }

        /*
         * Converts this Grayscaler object's image to grayscale by iterating
         * through each pixel and changing its RGB value.
         * 
         */
        public void ConvertGrayScale(){
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color px_color = bmp.GetPixel(x, y);
                    int px_converted;
                    px_converted= Formula(px_color);
                    Color new_color = Color.FromArgb(px_converted, px_converted, px_converted);        
                    bmp.SetPixel(x, y, new_color );
                }
            }
        }

        /*
         * Converts the pixel RGB value based on a formula
         * 
         * Parameters:
         *  px_color (Color) - the original pixel color
         * 
         * Return:
         *  px_converted (int) - the converted pixel color rgb values
         */ 
        public int Formula(Color px_color){
            int px_converted;

            int r_val = px_color.R;
            int g_val = px_color.G;
            int b_val = px_color.B;


            px_converted = (r_val + g_val + b_val) / 3;

            return px_converted;
        }

        /*
         * returns the image
         */ 
        public Bitmap getImage()
        {
            return this.bmp;
        }
    }
}
