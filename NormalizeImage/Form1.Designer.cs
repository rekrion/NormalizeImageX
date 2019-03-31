namespace NormalizeImage
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInput = new System.Windows.Forms.Panel();
            this.InputPicture = new System.Windows.Forms.PictureBox();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.OutputPicture = new System.Windows.Forms.PictureBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.buttonNormalize = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInputHash = new System.Windows.Forms.Label();
            this.groupBoxInputHash = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInputHash512 = new System.Windows.Forms.Button();
            this.buttonInputHash256 = new System.Windows.Forms.Button();
            this.groupBoxOutputHash = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOutputHash512 = new System.Windows.Forms.Button();
            this.buttonOutputHash256 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOutputHash = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputPicture)).BeginInit();
            this.panelOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPicture)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxInputHash.SuspendLayout();
            this.groupBoxOutputHash.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.InputPicture);
            this.panelInput.Location = new System.Drawing.Point(180, 12);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(160, 160);
            this.panelInput.TabIndex = 5;
            // 
            // InputPicture
            // 
            this.InputPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPicture.Location = new System.Drawing.Point(0, 0);
            this.InputPicture.Name = "InputPicture";
            this.InputPicture.Size = new System.Drawing.Size(160, 160);
            this.InputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InputPicture.TabIndex = 1;
            this.InputPicture.TabStop = false;
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.OutputPicture);
            this.panelOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelOutput.Location = new System.Drawing.Point(180, 178);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(160, 160);
            this.panelOutput.TabIndex = 9;
            // 
            // OutputPicture
            // 
            this.OutputPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputPicture.Location = new System.Drawing.Point(0, 0);
            this.OutputPicture.Name = "OutputPicture";
            this.OutputPicture.Size = new System.Drawing.Size(160, 160);
            this.OutputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutputPicture.TabIndex = 1;
            this.OutputPicture.TabStop = false;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.buttonNormalize);
            this.groupBoxMenu.Controls.Add(this.buttonSave);
            this.groupBoxMenu.Controls.Add(this.buttonOpen);
            this.groupBoxMenu.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(162, 326);
            this.groupBoxMenu.TabIndex = 10;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Меню";
            // 
            // buttonNormalize
            // 
            this.buttonNormalize.Location = new System.Drawing.Point(35, 139);
            this.buttonNormalize.Name = "buttonNormalize";
            this.buttonNormalize.Size = new System.Drawing.Size(91, 48);
            this.buttonNormalize.TabIndex = 13;
            this.buttonNormalize.Text = "Нормализация изображения";
            this.buttonNormalize.UseVisualStyleBackColor = true;
            this.buttonNormalize.Click += new System.EventHandler(this.buttonNormalize_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(35, 223);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 48);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(35, 54);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(91, 48);
            this.buttonOpen.TabIndex = 11;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hash:";
            // 
            // labelInputHash
            // 
            this.labelInputHash.AutoSize = true;
            this.labelInputHash.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelInputHash.Location = new System.Drawing.Point(6, 54);
            this.labelInputHash.Name = "labelInputHash";
            this.labelInputHash.Size = new System.Drawing.Size(36, 13);
            this.labelInputHash.TabIndex = 12;
            this.labelInputHash.Text = "Empty";
            // 
            // groupBoxInputHash
            // 
            this.groupBoxInputHash.Controls.Add(this.label3);
            this.groupBoxInputHash.Controls.Add(this.buttonInputHash512);
            this.groupBoxInputHash.Controls.Add(this.buttonInputHash256);
            this.groupBoxInputHash.Controls.Add(this.label1);
            this.groupBoxInputHash.Controls.Add(this.labelInputHash);
            this.groupBoxInputHash.Location = new System.Drawing.Point(349, 12);
            this.groupBoxInputHash.Name = "groupBoxInputHash";
            this.groupBoxInputHash.Size = new System.Drawing.Size(537, 160);
            this.groupBoxInputHash.TabIndex = 13;
            this.groupBoxInputHash.TabStop = false;
            this.groupBoxInputHash.Text = "Входное изображение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Выберите размер получаемого хэша";
            // 
            // buttonInputHash512
            // 
            this.buttonInputHash512.Location = new System.Drawing.Point(456, 131);
            this.buttonInputHash512.Name = "buttonInputHash512";
            this.buttonInputHash512.Size = new System.Drawing.Size(75, 23);
            this.buttonInputHash512.TabIndex = 14;
            this.buttonInputHash512.Text = "512";
            this.buttonInputHash512.UseVisualStyleBackColor = true;
            this.buttonInputHash512.Click += new System.EventHandler(this.buttonInputHash512_Click);
            // 
            // buttonInputHash256
            // 
            this.buttonInputHash256.Location = new System.Drawing.Point(375, 131);
            this.buttonInputHash256.Name = "buttonInputHash256";
            this.buttonInputHash256.Size = new System.Drawing.Size(75, 23);
            this.buttonInputHash256.TabIndex = 13;
            this.buttonInputHash256.Text = "256";
            this.buttonInputHash256.UseVisualStyleBackColor = true;
            this.buttonInputHash256.Click += new System.EventHandler(this.buttonInputHash256_Click);
            // 
            // groupBoxOutputHash
            // 
            this.groupBoxOutputHash.Controls.Add(this.label2);
            this.groupBoxOutputHash.Controls.Add(this.buttonOutputHash512);
            this.groupBoxOutputHash.Controls.Add(this.buttonOutputHash256);
            this.groupBoxOutputHash.Controls.Add(this.label4);
            this.groupBoxOutputHash.Controls.Add(this.labelOutputHash);
            this.groupBoxOutputHash.Location = new System.Drawing.Point(349, 178);
            this.groupBoxOutputHash.Name = "groupBoxOutputHash";
            this.groupBoxOutputHash.Size = new System.Drawing.Size(537, 160);
            this.groupBoxOutputHash.TabIndex = 16;
            this.groupBoxOutputHash.TabStop = false;
            this.groupBoxOutputHash.Text = "Входное изображение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Выберите размер получаемого хэша";
            // 
            // buttonOutputHash512
            // 
            this.buttonOutputHash512.Location = new System.Drawing.Point(456, 131);
            this.buttonOutputHash512.Name = "buttonOutputHash512";
            this.buttonOutputHash512.Size = new System.Drawing.Size(75, 23);
            this.buttonOutputHash512.TabIndex = 14;
            this.buttonOutputHash512.Text = "512";
            this.buttonOutputHash512.UseVisualStyleBackColor = true;
            this.buttonOutputHash512.Click += new System.EventHandler(this.buttonOutputHash512_Click);
            // 
            // buttonOutputHash256
            // 
            this.buttonOutputHash256.Location = new System.Drawing.Point(375, 131);
            this.buttonOutputHash256.Name = "buttonOutputHash256";
            this.buttonOutputHash256.Size = new System.Drawing.Size(75, 23);
            this.buttonOutputHash256.TabIndex = 13;
            this.buttonOutputHash256.Text = "256";
            this.buttonOutputHash256.UseVisualStyleBackColor = true;
            this.buttonOutputHash256.Click += new System.EventHandler(this.buttonOutputHash256_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hash:";
            // 
            // labelOutputHash
            // 
            this.labelOutputHash.AutoSize = true;
            this.labelOutputHash.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOutputHash.Location = new System.Drawing.Point(6, 54);
            this.labelOutputHash.Name = "labelOutputHash";
            this.labelOutputHash.Size = new System.Drawing.Size(36, 13);
            this.labelOutputHash.TabIndex = 12;
            this.labelOutputHash.Text = "Empty";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNM Files|*.pnm|Windows Bitmap|*.bmp|Graphics Interchange Format|*.gif|JPEG|*.jp*" +
    "|Portable Network Graphics|*.png|Webp|*.webp";
            this.openFileDialog1.FilterIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bmp";
            this.saveFileDialog1.Filter = "PNM Files|*.pnm|Windows Bitmap|*.bmp|Graphics Interchange Format|*.gif|JPEG|*.jp*" +
    "|Portable Network Graphics|*. png";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 368);
            this.Controls.Add(this.groupBoxOutputHash);
            this.Controls.Add(this.groupBoxInputHash);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Name = "MainForm";
            this.Text = "Нормализация изображения";
            this.panelInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InputPicture)).EndInit();
            this.panelOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OutputPicture)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxInputHash.ResumeLayout(false);
            this.groupBoxInputHash.PerformLayout();
            this.groupBoxOutputHash.ResumeLayout(false);
            this.groupBoxOutputHash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.PictureBox InputPicture;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.PictureBox OutputPicture;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button buttonNormalize;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInputHash;
        private System.Windows.Forms.GroupBox groupBoxInputHash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInputHash512;
        private System.Windows.Forms.Button buttonInputHash256;
        private System.Windows.Forms.GroupBox groupBoxOutputHash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOutputHash512;
        private System.Windows.Forms.Button buttonOutputHash256;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOutputHash;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

