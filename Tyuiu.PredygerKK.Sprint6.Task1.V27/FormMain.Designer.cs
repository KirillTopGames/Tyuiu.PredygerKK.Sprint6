namespace Tyuiu.PredygerKK.Sprint6.Task1.V27
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBox1 = new PictureBox();
            StartField_PKK = new TextBox();
            StopField_PKK = new TextBox();
            SolveButton_PKK = new Button();
            label1 = new Label();
            label2 = new Label();
            ResultBox_PKK = new TextBox();
            label3 = new Label();
            ButtonHelp_PKK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 154);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // StartField_PKK
            // 
            StartField_PKK.BackColor = Color.FromArgb(255, 255, 192);
            StartField_PKK.Font = new Font("Segoe UI", 24F);
            StartField_PKK.Location = new Point(10, 281);
            StartField_PKK.Margin = new Padding(3, 2, 3, 2);
            StartField_PKK.Multiline = true;
            StartField_PKK.Name = "StartField_PKK";
            StartField_PKK.Size = new Size(135, 39);
            StartField_PKK.TabIndex = 1;
            StartField_PKK.TextAlign = HorizontalAlignment.Center;
            StartField_PKK.TextChanged += StartField_PKK_TextChanged;
            // 
            // StopField_PKK
            // 
            StopField_PKK.BackColor = Color.FromArgb(255, 255, 192);
            StopField_PKK.Font = new Font("Segoe UI", 24F);
            StopField_PKK.ImeMode = ImeMode.NoControl;
            StopField_PKK.Location = new Point(192, 281);
            StopField_PKK.Margin = new Padding(3, 2, 3, 2);
            StopField_PKK.Multiline = true;
            StopField_PKK.Name = "StopField_PKK";
            StopField_PKK.Size = new Size(135, 39);
            StopField_PKK.TabIndex = 2;
            StopField_PKK.TextAlign = HorizontalAlignment.Center;
            StopField_PKK.TextChanged += StopField_PKK_TextChanged;
            // 
            // SolveButton_PKK
            // 
            SolveButton_PKK.BackColor = Color.FromArgb(192, 255, 192);
            SolveButton_PKK.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            SolveButton_PKK.Location = new Point(505, 263);
            SolveButton_PKK.Margin = new Padding(3, 2, 3, 2);
            SolveButton_PKK.Name = "SolveButton_PKK";
            SolveButton_PKK.Size = new Size(66, 56);
            SolveButton_PKK.TabIndex = 4;
            SolveButton_PKK.Text = "Пуск";
            SolveButton_PKK.UseVisualStyleBackColor = false;
            SolveButton_PKK.Click += SolveButton_PKK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 266);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 3;
            label1.Text = "Начальное значение";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(192, 266);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 6;
            label2.Text = "Конечное значение";
            // 
            // ResultBox_PKK
            // 
            ResultBox_PKK.Font = new Font("Segoe UI", 14F);
            ResultBox_PKK.Location = new Point(576, 9);
            ResultBox_PKK.Margin = new Padding(3, 2, 3, 2);
            ResultBox_PKK.Multiline = true;
            ResultBox_PKK.Name = "ResultBox_PKK";
            ResultBox_PKK.ReadOnly = true;
            ResultBox_PKK.ScrollBars = ScrollBars.Vertical;
            ResultBox_PKK.Size = new Size(322, 312);
            ResultBox_PKK.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(589, 2);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 8;
            label3.Text = "Результат";
            // 
            // ButtonHelp_PKK
            // 
            ButtonHelp_PKK.BackColor = SystemColors.ActiveCaption;
            ButtonHelp_PKK.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            ButtonHelp_PKK.Location = new Point(903, 2);
            ButtonHelp_PKK.Margin = new Padding(3, 2, 3, 2);
            ButtonHelp_PKK.Name = "ButtonHelp_PKK";
            ButtonHelp_PKK.Size = new Size(35, 35);
            ButtonHelp_PKK.TabIndex = 9;
            ButtonHelp_PKK.Text = "?";
            ButtonHelp_PKK.UseVisualStyleBackColor = false;
            ButtonHelp_PKK.Click += ButtonHelp_PKK_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 338);
            Controls.Add(ButtonHelp_PKK);
            Controls.Add(label3);
            Controls.Add(ResultBox_PKK);
            Controls.Add(label2);
            Controls.Add(SolveButton_PKK);
            Controls.Add(label1);
            Controls.Add(StopField_PKK);
            Controls.Add(StartField_PKK);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 27 | Предыгер К.К.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox StartField_PKK;
        private TextBox StopField_PKK;
        private Label label1;
        private Button SolveButton_PKK;
        private Button HelpButton_PKK;
        private Label label2;
        private TextBox ResultBox_PKK;
        private Label label3;
        private Button ButtonHelp_PKK;
    }
}
