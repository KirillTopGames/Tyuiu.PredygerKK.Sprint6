namespace Tyuiu.PredygerKK.Sprint6.Task4.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            HelpButton_PKK = new Button();
            InputTextBoxStart_PKK = new TextBox();
            InputTextBoxStop_PKK = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SolveButton_PKK = new Button();
            SaveButton_PKK = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            ResultTextBox_PKK = new TextBox();
            ChartFunctionResult_PKK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartFunctionResult_PKK).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(770, 174);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(831, 12);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(639, 174);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(24, -2);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 2;
            label1.Text = "Условие";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(842, -2);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 3;
            label2.Text = "Ввод данных";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 42);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F);
            textBox3.Location = new Point(24, 77);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(721, 96);
            textBox3.TabIndex = 5;
            textBox3.Text = "Произвести табулирование функции на заданном диапазоне.\r\n\r\nРезультат вывести в textBox, построить график функции и сохранить в файл OutPutFileTask4V13.txt по нажатию кнопки.";
            // 
            // HelpButton_PKK
            // 
            HelpButton_PKK.AutoSize = true;
            HelpButton_PKK.BackColor = Color.FromArgb(192, 192, 255);
            HelpButton_PKK.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            HelpButton_PKK.Location = new Point(1410, 20);
            HelpButton_PKK.Name = "HelpButton_PKK";
            HelpButton_PKK.Size = new Size(51, 51);
            HelpButton_PKK.TabIndex = 6;
            HelpButton_PKK.Text = "?";
            HelpButton_PKK.UseVisualStyleBackColor = false;
            HelpButton_PKK.Click += HelpButton_PKK_Click;
            // 
            // InputTextBoxStart_PKK
            // 
            InputTextBoxStart_PKK.BackColor = Color.FromArgb(255, 255, 192);
            InputTextBoxStart_PKK.Font = new Font("Segoe UI", 12F);
            InputTextBoxStart_PKK.Location = new Point(842, 54);
            InputTextBoxStart_PKK.Name = "InputTextBoxStart_PKK";
            InputTextBoxStart_PKK.Size = new Size(125, 34);
            InputTextBoxStart_PKK.TabIndex = 7;
            // 
            // InputTextBoxStop_PKK
            // 
            InputTextBoxStop_PKK.BackColor = Color.FromArgb(255, 255, 192);
            InputTextBoxStop_PKK.Font = new Font("Segoe UI", 12F);
            InputTextBoxStop_PKK.Location = new Point(842, 139);
            InputTextBoxStop_PKK.Name = "InputTextBoxStop_PKK";
            InputTextBoxStop_PKK.Size = new Size(125, 34);
            InputTextBoxStop_PKK.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(842, 29);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 9;
            label3.Text = "Начало шага:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(842, 116);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 10;
            label4.Text = "Конец шага:";
            // 
            // SolveButton_PKK
            // 
            SolveButton_PKK.BackColor = Color.FromArgb(192, 255, 192);
            SolveButton_PKK.Font = new Font("Segoe UI", 13F);
            SolveButton_PKK.Location = new Point(1082, 21);
            SolveButton_PKK.Name = "SolveButton_PKK";
            SolveButton_PKK.Size = new Size(137, 67);
            SolveButton_PKK.TabIndex = 11;
            SolveButton_PKK.Text = "Запустить";
            SolveButton_PKK.UseVisualStyleBackColor = false;
            SolveButton_PKK.Click += SolveButton_PKK_Click;
            // 
            // SaveButton_PKK
            // 
            SaveButton_PKK.BackColor = Color.FromArgb(128, 128, 255);
            SaveButton_PKK.Font = new Font("Segoe UI", 13F);
            SaveButton_PKK.Location = new Point(1082, 106);
            SaveButton_PKK.Name = "SaveButton_PKK";
            SaveButton_PKK.Size = new Size(137, 67);
            SaveButton_PKK.TabIndex = 12;
            SaveButton_PKK.Text = "Сохранить";
            SaveButton_PKK.UseVisualStyleBackColor = false;
            SaveButton_PKK.Click += SaveButton_PKK_Click;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(12, 212);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(258, 315);
            textBox4.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(24, 200);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 14;
            label5.Text = "Вывод данных";
            // 
            // ResultTextBox_PKK
            // 
            ResultTextBox_PKK.BackColor = Color.White;
            ResultTextBox_PKK.Location = new Point(24, 228);
            ResultTextBox_PKK.Multiline = true;
            ResultTextBox_PKK.Name = "ResultTextBox_PKK";
            ResultTextBox_PKK.ReadOnly = true;
            ResultTextBox_PKK.ScrollBars = ScrollBars.Vertical;
            ResultTextBox_PKK.Size = new Size(233, 285);
            ResultTextBox_PKK.TabIndex = 15;
            // 
            // ChartFunctionResult_PKK
            // 
            chartArea1.Name = "ChartArea1";
            ChartFunctionResult_PKK.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartFunctionResult_PKK.Legends.Add(legend1);
            ChartFunctionResult_PKK.Location = new Point(319, 212);
            ChartFunctionResult_PKK.Name = "ChartFunctionResult_PKK";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartFunctionResult_PKK.Series.Add(series1);
            ChartFunctionResult_PKK.Size = new Size(1151, 315);
            ChartFunctionResult_PKK.TabIndex = 16;
            title1.Name = "Title1";
            title1.Text = "График функции";
            ChartFunctionResult_PKK.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 539);
            Controls.Add(ChartFunctionResult_PKK);
            Controls.Add(ResultTextBox_PKK);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(SaveButton_PKK);
            Controls.Add(SolveButton_PKK);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(InputTextBoxStop_PKK);
            Controls.Add(InputTextBoxStart_PKK);
            Controls.Add(HelpButton_PKK);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1500, 586);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 13 | Предыгер К.К.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartFunctionResult_PKK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Button HelpButton_PKK;
        private TextBox InputTextBoxStart_PKK;
        private TextBox InputTextBoxStop_PKK;
        private Label label3;
        private Label label4;
        private Button SolveButton_PKK;
        private Button SaveButton_PKK;
        private TextBox textBox4;
        private Label label5;
        private TextBox ResultTextBox_PKK;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFunctionResult_PKK;
    }
}
