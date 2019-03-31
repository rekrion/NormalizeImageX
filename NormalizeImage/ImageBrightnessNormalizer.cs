using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalizeImage
{
    //Класс для нормализация яркости изображения
    class ImageBrightnessNormalizer
    {
        //Константы
        private const float MIN_BRIGHTNESS = 0;
        private const float MAX_BRIGHTNESS = 1;

        public static Bitmap NormalizeImageBrightness(Bitmap image)
        {
            float minBrightness = MAX_BRIGHTNESS;
            float maxBrightness = MIN_BRIGHTNESS;

            //Получение значение яркости с изображения
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    float pixelBrightness = image.GetPixel(x, y).GetBrightness();
                    minBrightness = Math.Min(minBrightness, pixelBrightness);
                    maxBrightness = Math.Max(maxBrightness, pixelBrightness);
                }
            }

            //Процесс нормализация изображения
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    float normalizedPixelBrightness = (pixelColor.GetBrightness() - minBrightness) / (maxBrightness - minBrightness);
                    Color normalizedPixelColor = ColorFromAhsb(pixelColor.A, pixelColor.GetHue(),
                    pixelColor.GetSaturation(), normalizedPixelBrightness);
                    image.SetPixel(x, y, normalizedPixelColor);
                }
            }
            return image;
        }
        //Конвертация цвета с изображения
        private static Color ColorFromAhsb(int a, float h, float s, float b)
        {
            if (0 > a || 255 < a)
            {
                throw new Exception("a");
            }
            if (0f > h || 360f < h)
            {
                throw new Exception("h");
            }
            if (0f > s || 1f < s)
            {
                throw new Exception("s");
            }
            if (0f > b || 1f < b)
            {
                throw new Exception("b");
            }

            if (0 == s)
            {
                return Color.FromArgb(a, Convert.ToInt32(b * 255),
                  Convert.ToInt32(b * 255), Convert.ToInt32(b * 255));
            }

            float fMax, fMid, fMin;
            int iSextant, iMax, iMid, iMin;

            if (0.5 < b)
            {
                fMax = b - (b * s) + s;
                fMin = b + (b * s) - s;
            }
            else
            {
                fMax = b + (b * s);
                fMin = b - (b * s);
            }

            iSextant = (int)Math.Floor(h / 60f);
            if (300f <= h)
            {
                h -= 360f;
            }
            h /= 60f;
            h -= 2f * (float)Math.Floor(((iSextant + 1f) % 6f) / 2f);
            if (0 == iSextant % 2)
            {
                fMid = h * (fMax - fMin) + fMin;
            }
            else
            {
                fMid = fMin - h * (fMax - fMin);
            }

            iMax = Convert.ToInt32(fMax * 255);
            iMid = Convert.ToInt32(fMid * 255);
            iMin = Convert.ToInt32(fMin * 255);

            switch (iSextant)
            {
                case 1:
                    return Color.FromArgb(a, iMid, iMax, iMin);
                case 2:
                    return Color.FromArgb(a, iMin, iMax, iMid);
                case 3:
                    return Color.FromArgb(a, iMin, iMid, iMax);
                case 4:
                    return Color.FromArgb(a, iMid, iMin, iMax);
                case 5:
                    return Color.FromArgb(a, iMax, iMin, iMid);
                default:
                    return Color.FromArgb(a, iMax, iMid, iMin);
            }
        }
    }
}
