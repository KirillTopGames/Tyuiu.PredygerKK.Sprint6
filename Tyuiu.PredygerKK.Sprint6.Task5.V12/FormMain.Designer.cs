namespace Tyuiu.PredygerKK.Sprint6.Task5.V12
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
            panel1 = new Panel();
            OpenFileButton_PKK = new Button();
            SolveButton_PKK = new Button();
            HelpButton_PKK = new Button();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            OutputBox_PKK = new TextBox();
            splitter1 = new Splitter();
            panel3 = new Panel();
            ChartFunctionResultVisual_PKK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChartFunctionResultVisual_PKK).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MintCream;
            panel1.Controls.Add(OpenFileButton_PKK);
            panel1.Controls.Add(SolveButton_PKK);
            panel1.Controls.Add(HelpButton_PKK);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 424);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 125);
            panel1.TabIndex = 0;
            // 
            // OpenFileButton_PKK
            // 
            OpenFileButton_PKK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OpenFileButton_PKK.BackColor = Color.MediumTurquoise;
            OpenFileButton_PKK.Cursor = Cursors.Hand;
            OpenFileButton_PKK.Font = new Font("UD Digi Kyokasho N-B", 8F, FontStyle.Bold);
            OpenFileButton_PKK.Location = new Point(784, 41);
            OpenFileButton_PKK.Name = "OpenFileButton_PKK";
            OpenFileButton_PKK.Size = new Size(118, 72);
            OpenFileButton_PKK.TabIndex = 3;
            OpenFileButton_PKK.Text = "Открыть файл";
            OpenFileButton_PKK.UseVisualStyleBackColor = false;
            OpenFileButton_PKK.Click += OpenFileButton_PKK_Click;
            // 
            // SolveButton_PKK
            // 
            SolveButton_PKK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SolveButton_PKK.BackColor = Color.PaleGreen;
            SolveButton_PKK.Cursor = Cursors.Hand;
            SolveButton_PKK.Font = new Font("UD Digi Kyokasho N-B", 8F, FontStyle.Bold);
            SolveButton_PKK.Location = new Point(530, 41);
            SolveButton_PKK.Name = "SolveButton_PKK";
            SolveButton_PKK.Size = new Size(141, 72);
            SolveButton_PKK.TabIndex = 2;
            SolveButton_PKK.Text = "Запустить";
            SolveButton_PKK.UseVisualStyleBackColor = false;
            SolveButton_PKK.Click += SolveButton_PKK_Click;
            SolveButton_PKK.MouseEnter += SolveButton_PKK_MouseEnter;
            SolveButton_PKK.MouseLeave += SolveButton_PKK_MouseLeave;
            // 
            // HelpButton_PKK
            // 
            HelpButton_PKK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            HelpButton_PKK.BackColor = Color.LightSteelBlue;
            HelpButton_PKK.Cursor = Cursors.Hand;
            HelpButton_PKK.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold);
            HelpButton_PKK.Location = new Point(908, 73);
            HelpButton_PKK.Name = "HelpButton_PKK";
            HelpButton_PKK.Size = new Size(40, 40);
            HelpButton_PKK.TabIndex = 1;
            HelpButton_PKK.Text = "?";
            HelpButton_PKK.UseVisualStyleBackColor = false;
            HelpButton_PKK.Click += HelpButton_PKK_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(512, 107);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Simplified Arabic Fixed", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 21);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(506, 83);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(250, 424);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OutputBox_PKK);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 400);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // OutputBox_PKK
            // 
            OutputBox_PKK.BackColor = Color.White;
            OutputBox_PKK.Dock = DockStyle.Fill;
            OutputBox_PKK.Font = new Font("Segoe UI", 12F);
            OutputBox_PKK.Location = new Point(3, 21);
            OutputBox_PKK.Multiline = true;
            OutputBox_PKK.Name = "OutputBox_PKK";
            OutputBox_PKK.ReadOnly = true;
            OutputBox_PKK.ScrollBars = ScrollBars.Vertical;
            OutputBox_PKK.Size = new Size(220, 376);
            OutputBox_PKK.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(250, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 424);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Honeydew;
            panel3.Controls.Add(ChartFunctionResultVisual_PKK);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(254, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(706, 424);
            panel3.TabIndex = 3;
            // 
            // ChartFunctionResultVisual_PKK
            // 
            chartArea1.Name = "ChartArea1";
            ChartFunctionResultVisual_PKK.ChartAreas.Add(chartArea1);
            ChartFunctionResultVisual_PKK.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            ChartFunctionResultVisual_PKK.Legends.Add(legend1);
            ChartFunctionResultVisual_PKK.Location = new Point(0, 0);
            ChartFunctionResultVisual_PKK.Name = "ChartFunctionResultVisual_PKK";
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.LightGreen;
            series1.Font = new Font("Microsoft Sans Serif", 10F);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartFunctionResultVisual_PKK.Series.Add(series1);
            ChartFunctionResultVisual_PKK.Size = new Size(706, 424);
            ChartFunctionResultVisual_PKK.TabIndex = 0;
            ChartFunctionResultVisual_PKK.Text = "chart1";
            title1.Font = new Font("UD Digi Kyokasho N-B", 9F, FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "График вывода данных";
            ChartFunctionResultVisual_PKK.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 549);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(978, 596);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 12 | Предыгер К.К.";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ChartFunctionResultVisual_PKK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Splitter splitter1;
        private Panel panel3;
        private TextBox OutputBox_PKK;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button SolveButton_PKK;
        private Button HelpButton_PKK;
        private Button OpenFileButton_PKK;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartFunctionResultVisual_PKK;
    }
}
