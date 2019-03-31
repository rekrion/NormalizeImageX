using ShaniSoft.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

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
                if (openFileDialog1.FilterIndex == 6)
                    using (Webp webp = new Webp())
                        InputPicture.Image = webp.Load(openFileDialog1.FileName);
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


    }
}
