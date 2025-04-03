using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;

namespace Cybersecurity_bot
{
    public class logo
    {
        //constructor
        public logo()
        {
            string path_project = AppDomain.CurrentDomain.BaseDirectory;
            string new_path_project = path_project.Replace("bin\\Debug\\", "");
            string full_path = Path.Combine(new_path_project, "logo.jpeg");
            Bitmap image = new Bitmap(full_path);
            image = new Bitmap(image, new Size(150, 200) );
            for (int height = 0; height < image.Height; height++)
            {
                for (int width = 0; width < image.Width; width++)
                {
                    Color pixelColor = image.GetPixel(width, height);
                    int color = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char ascii_design = color > 200 ? '.' : color > 160 ? '*' : color > 90 ? '0' : color > 60 ? '#' : '@';
                     Console.Write(ascii_design);

                }//end of inner loop
                Console.WriteLine();
            }//end of outter loop
        }
    }
}
