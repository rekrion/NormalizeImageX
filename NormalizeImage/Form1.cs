using ShaniSoft.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalizeImage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Кнопка Открыть
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        //Кнопка Сохранить
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }


        //Открытие файла
        public void OpenFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (InputPicture.Image != null) InputPicture.Image.Dispose();

                if (openFileDialog1.FilterIndex == 1)
                    InputPicture.Image = ShaniSoft.Drawing.PNM.ReadPNM(openFileDialog1.FileName);
                else if (openFileDialog1.FilterIndex == 6)
                {
                    using (Webp webp = new Webp())
                        InputPicture.Image = webp.Load(openFileDialog1.FileName);
                }
                else
                    InputPicture.Image = new Bitmap(openFileDialog1.FileName);
                InputPicture.Refresh();
            }
        }
        //Сохранение файла
        public void SaveFile()
        {
            if (OutputPicture.Image == null) return;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex < 4)
                {
                    ShaniSoft.Drawing.PNM.WritePNM(saveFileDialog1.FileName, OutputPicture.Image, PNMEncoding.BinaryEncoding, PNMType.PPM);
                }
                else
                {
                    OutputPicture.Image.Save(saveFileDialog1.FileName);
                }
            }
        }
        //Нормализация изображения
        public Image NormalizeImage(Image image)
        {
            Image imageReturn = ImageBrightnessNormalizer.NormalizeImageBrightness(new Bitmap(image));
            return imageReturn;
        }
        //Получение байтового массива из изображения
        private byte[] GetByteArrayImage(Image a)
        {
            byte[] byteImage;
            using (MemoryStream ms = new MemoryStream())
            {
                a.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byteImage = ms.ToArray();
            }
            return byteImage;
        }
        //Получение Хэш кода (Стрибог) из изображения
        public string GetHashCode_Stribog(Image picture, SizeHash sizeHash)
        {
            if (picture != null)
            {
                byte[] imagetobyte = GetByteArrayImage(picture);
                Stribog G = new Stribog(sizeHash);
                return BitConverter.ToString(G.GetHash(imagetobyte));
            }
            else
                return "Empty";
        }


        //Кнопка "Нормализация изображения"
        private void buttonNormalize_Click(object sender, EventArgs e)
        {
             OutputPicture.Image = NormalizeImage(InputPicture.Image);
        }
        //Кнопка "256" для входного изображения
        private void buttonInputHash256_Click(object sender, EventArgs e)
        {
            labelInputHash.Text=GetHashCode_Stribog(InputPicture.Image, SizeHash.Size256);
        }
        //Кнопка "512" для входного изображения
        private void buttonInputHash512_Click(object sender, EventArgs e)
        {
            labelInputHash.Text = GetHashCode_Stribog(InputPicture.Image, SizeHash.Size512);
        }
        //Кнопка "256" для выходного изображения
        private void buttonOutputHash256_Click(object sender, EventArgs e)
        {
            labelOutputHash.Text = GetHashCode_Stribog(OutputPicture.Image, SizeHash.Size256);
        }
        //Кнопка "512" для выходного изображения
        private void buttonOutputHash512_Click(object sender, EventArgs e)
        {
            labelOutputHash.Text = GetHashCode_Stribog(OutputPicture.Image, SizeHash.Size512);
        }
    }
}
