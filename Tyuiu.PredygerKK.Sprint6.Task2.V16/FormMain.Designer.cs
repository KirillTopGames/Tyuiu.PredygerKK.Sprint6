namespace Tyuiu.PredygerKK.Sprint6.Task2.V16
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
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            InPutFieldStart_PKK = new TextBox();
            InPutFieldStop_PKK = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            SolveButton_PKK = new Button();
            HelpButton_PKK = new Button();
            DataGridViewFunction_PKK = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            ResultColumn = new DataGridViewTextBoxColumn();
            label5 = new Label();
            ChartFunction_PKK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFunction_PKK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartFunction_PKK).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(667, 229);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(643, 209);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(12, 302);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(667, 215);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 291);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Ввод данных";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(35, 364);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 100);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(208, 364);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 100);
            textBox4.TabIndex = 6;
            // 
            // InPutFieldStart_PKK
            // 
            InPutFieldStart_PKK.BackColor = Color.FromArgb(255, 255, 192);
            InPutFieldStart_PKK.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic);
            InPutFieldStart_PKK.Location = new Point(54, 385);
            InPutFieldStart_PKK.Name = "InPutFieldStart_PKK";
            InPutFieldStart_PKK.Size = new Size(61, 61);
            InPutFieldStart_PKK.TabIndex = 7;
            InPutFieldStart_PKK.TextAlign = HorizontalAlignment.Center;
            // 
            // InPutFieldStop_PKK
            // 
            InPutFieldStop_PKK.BackColor = Color.FromArgb(255, 255, 192);
            InPutFieldStop_PKK.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic);
            InPutFieldStop_PKK.Location = new Point(229, 385);
            InPutFieldStop_PKK.Name = "InPutFieldStop_PKK";
            InPutFieldStop_PKK.Size = new Size(61, 61);
            InPutFieldStop_PKK.TabIndex = 8;
            InPutFieldStop_PKK.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 352);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 9;
            label3.Text = "Начало шага";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 352);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 10;
            label4.Text = "Конец шага";
            label4.Click += label4_Click;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(685, 12);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(799, 505);
            textBox5.TabIndex = 11;
            // 
            // SolveButton_PKK
            // 
            SolveButton_PKK.AutoSize = true;
            SolveButton_PKK.BackColor = Color.FromArgb(192, 255, 192);
            SolveButton_PKK.Font = new Font("Segoe UI", 18F);
            SolveButton_PKK.Location = new Point(464, 364);
            SolveButton_PKK.Name = "SolveButton_PKK";
            SolveButton_PKK.Size = new Size(94, 94);
            SolveButton_PKK.TabIndex = 12;
            SolveButton_PKK.Text = "Пуск";
            SolveButton_PKK.UseVisualStyleBackColor = false;
            SolveButton_PKK.Click += SolveButton_PKK_Click;
            // 
            // HelpButton_PKK
            // 
            HelpButton_PKK.AutoSize = true;
            HelpButton_PKK.BackColor = Color.FromArgb(192, 192, 255);
            HelpButton_PKK.Font = new Font("Segoe UI", 20F);
            HelpButton_PKK.Location = new Point(1417, 23);
            HelpButton_PKK.Name = "HelpButton_PKK";
            HelpButton_PKK.Size = new Size(56, 56);
            HelpButton_PKK.TabIndex = 13;
            HelpButton_PKK.Text = "?";
            HelpButton_PKK.UseVisualStyleBackColor = false;
            HelpButton_PKK.Click += HelpButton_PKK_Click_1;
            // 
            // DataGridViewFunction_PKK
            // 
            DataGridViewFunction_PKK.BackgroundColor = Color.Silver;
            DataGridViewFunction_PKK.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewFunction_PKK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewFunction_PKK.Columns.AddRange(new DataGridViewColumn[] { X, ResultColumn });
            DataGridViewFunction_PKK.Location = new Point(696, 23);
            DataGridViewFunction_PKK.Name = "DataGridViewFunction_PKK";
            DataGridViewFunction_PKK.ReadOnly = true;
            DataGridViewFunction_PKK.RowHeadersVisible = false;
            DataGridViewFunction_PKK.RowHeadersWidth = 51;
            DataGridViewFunction_PKK.Size = new Size(183, 483);
            DataGridViewFunction_PKK.TabIndex = 14;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 75;
            // 
            // ResultColumn
            // 
            ResultColumn.HeaderText = "f(x)";
            ResultColumn.MinimumWidth = 6;
            ResultColumn.Name = "ResultColumn";
            ResultColumn.ReadOnly = true;
            ResultColumn.Width = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(696, -3);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 15;
            label5.Text = "Вывод данных";
            // 
            // ChartFunction_PKK
            // 
            chartArea1.Name = "ChartArea1";
            ChartFunction_PKK.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartFunction_PKK.Legends.Add(legend1);
            ChartFunction_PKK.Location = new Point(885, 85);
            ChartFunction_PKK.Name = "ChartFunction_PKK";
            ChartFunction_PKK.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartFunction_PKK.Series.Add(series1);
            ChartFunction_PKK.Size = new Size(588, 421);
            ChartFunction_PKK.TabIndex = 16;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 533);
            Controls.Add(ChartFunction_PKK);
            Controls.Add(label5);
            Controls.Add(DataGridViewFunction_PKK);
            Controls.Add(HelpButton_PKK);
            Controls.Add(SolveButton_PKK);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(InPutFieldStop_PKK);
            Controls.Add(InPutFieldStart_PKK);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 16 | Предыгер К.К.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFunction_PKK).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartFunction_PKK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox InPutFieldStart_PKK;
        private TextBox InPutFieldStop_PKK;
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private Button SolveButton_PKK;
        private Button HelpButton_PKK;
        private DataGridView DataGridViewFunction_PKK;
        private Label label5;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn ResultColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFunction_PKK;
    }
}
