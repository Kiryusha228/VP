using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Common;

namespace ImageEditor
{
    public static class ImageProcess
    {
        static byte[] BmpToArray(Bitmap source)
        {
            var result = new byte[source.Width * source.Height * 3];
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color pixel = source.GetPixel(i, j);
                    result[3 * (j * source.Width + i) + 0] = pixel.R;
                    result[3 * (j * source.Width + i) + 1] = pixel.G;
                    result[3 * (j * source.Width + i) + 2] = pixel.B;
                }
            }

            return result;
        }

        static Bitmap ArrayToBmp(byte[] source, int width, int height)
        {
            var result = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int position = 3 * (j * width + i);
                    result.SetPixel(i,j, Color.FromArgb(source[position + 0], source[position + 1], source[position + 2]));
                }
            }

            return result;
        }

        static int RgbRange(int value)
        {
            if (value < 0)
            {
                value = 0;
            }
            else
            {
                if (value > 255)
                {
                    value = 255;
                }
            }
            return value;
        }

        public static Bitmap FilterImage(Bitmap source, double[,] matrix)
        {
            byte[] src = BmpToArray(source);
            byte[] res = new byte[src.Length];
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    double r = 0;
                    double g = 0;
                    double b = 0;
                    for (int n = 0; n < matrix.GetLength(0); n++)
                    {
                        for (int m = 0; m < matrix.GetLength(1); m++)
                        {
                            if (((j - 1 + m) < 0) || ((j - 1 + m) == source.Height)
                            || ((i - 1 + n) < 0) || ((i - 1 + n) == source.Width))
                            {
                                continue;
                            }
                            int position = 3 * (source.Width * (j - 1 + m) + (i - 1 +
                           n));
                            double matrixValue = matrix[n, m];
                            r += src[position + 0] * matrixValue;
                            g += src[position + 1] * matrixValue;
                            b += src[position + 2] * matrixValue;
                        }
                    }
                    r = RgbRange((int)r);
                    g = RgbRange((int)g);
                    b = RgbRange((int)b);
                    int pixelPosition = 3 * (source.Width * j + i);
                    res[pixelPosition + 0] = (byte)r;
                    res[pixelPosition + 1] = (byte)g;
                    res[pixelPosition + 2] = (byte)b;
                }
            }
            return ArrayToBmp(res, source.Width, source.Height);
        }

    }
}
