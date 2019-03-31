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

            /* Get the brightness range of the image. */
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    float pixelBrightness = image.GetPixel(x, y).GetBrightness();
                    minBrightness = Math.Min(minBrightness, pixelBrightness);
                    maxBrightness = Math.Max(maxBrightness, pixelBrightness);
                }
            }

            /* Normalize the image brightness. */
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

        private static Color ColorFromAhsb(byte a, float v1, float v2, float normalizedPixelBrightness)
        {
            throw new NotImplementedException();
        }
    }
}
