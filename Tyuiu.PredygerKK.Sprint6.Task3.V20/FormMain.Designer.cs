namespace Tyuiu.PredygerKK.Sprint6.Task3.V20
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            HelpButton_PKK = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SolveButton_PKK = new Button();
            DataGridViewFunction_PKK = new DataGridView();
            DataGridViewResult_PKK = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFunction_PKK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewResult_PKK).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(10, 9);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(513, 131);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(32, -2);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 1;
            label1.Text = "Условие";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(21, 22);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(492, 110);
            textBox2.TabIndex = 2;
            textBox2.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в пятой строке на 0.\r\n\r\nРезультат вывести в DataGridView.\r\n\r\nГрафический интерфейс оформить по шаблону из лекции.\r\n";
            // 
            // HelpButton_PKK
            // 
            HelpButton_PKK.AutoSize = true;
            HelpButton_PKK.BackColor = Color.FromArgb(192, 192, 255);
            HelpButton_PKK.Font = new Font("Bahnschrift SemiBold Condensed", 20F, FontStyle.Bold);
            HelpButton_PKK.Location = new Point(685, 9);
            HelpButton_PKK.Margin = new Padding(3, 2, 3, 2);
            HelpButton_PKK.Name = "HelpButton_PKK";
            HelpButton_PKK.Size = new Size(49, 43);
            HelpButton_PKK.TabIndex = 4;
            HelpButton_PKK.Text = "?";
            HelpButton_PKK.UseVisualStyleBackColor = false;
            HelpButton_PKK.Click += HelpButton_PKK_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(10, 190);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(234, 201);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(500, 190);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(234, 201);
            textBox4.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(21, 178);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 7;
            label2.Text = "Ввод данных";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(514, 178);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 8;
            label3.Text = "Вывод данных";
            // 
            // SolveButton_PKK
            // 
            SolveButton_PKK.AutoSize = true;
            SolveButton_PKK.BackColor = Color.FromArgb(192, 255, 192);
            SolveButton_PKK.Font = new Font("Bahnschrift SemiBold Condensed", 16.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SolveButton_PKK.Location = new Point(276, 270);
            SolveButton_PKK.Margin = new Padding(3, 2, 3, 2);
            SolveButton_PKK.Name = "SolveButton_PKK";
            SolveButton_PKK.Size = new Size(192, 37);
            SolveButton_PKK.TabIndex = 9;
            SolveButton_PKK.Text = "Преобразовать";
            SolveButton_PKK.UseVisualStyleBackColor = false;
            SolveButton_PKK.Click += SolveButton_PKK_Click;
            // 
            // DataGridViewFunction_PKK
            // 
            DataGridViewFunction_PKK.AllowUserToDeleteRows = false;
            DataGridViewFunction_PKK.AllowUserToResizeColumns = false;
            DataGridViewFunction_PKK.AllowUserToResizeRows = false;
            DataGridViewFunction_PKK.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            DataGridViewFunction_PKK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewFunction_PKK.ColumnHeadersVisible = false;
            DataGridViewFunction_PKK.Location = new Point(21, 201);
            DataGridViewFunction_PKK.Margin = new Padding(3, 2, 3, 2);
            DataGridViewFunction_PKK.Name = "DataGridViewFunction_PKK";
            DataGridViewFunction_PKK.RowHeadersVisible = false;
            DataGridViewFunction_PKK.RowHeadersWidth = 51;
            DataGridViewFunction_PKK.Size = new Size(210, 180);
            DataGridViewFunction_PKK.TabIndex = 10;
            DataGridViewFunction_PKK.CellContentClick += DataGridViewFunction_PKK_CellContentClick;
            // 
            // DataGridViewResult_PKK
            // 
            DataGridViewResult_PKK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewResult_PKK.ColumnHeadersVisible = false;
            DataGridViewResult_PKK.Location = new Point(514, 201);
            DataGridViewResult_PKK.Margin = new Padding(3, 2, 3, 2);
            DataGridViewResult_PKK.Name = "DataGridViewResult_PKK";
            DataGridViewResult_PKK.ReadOnly = true;
            DataGridViewResult_PKK.RowHeadersVisible = false;
            DataGridViewResult_PKK.RowHeadersWidth = 51;
            DataGridViewResult_PKK.Size = new Size(210, 180);
            DataGridViewResult_PKK.TabIndex = 11;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 400);
            Controls.Add(DataGridViewResult_PKK);
            Controls.Add(DataGridViewFunction_PKK);
            Controls.Add(SolveButton_PKK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(HelpButton_PKK);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 20 | Предыгер К.К.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewFunction_PKK).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewResult_PKK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button HelpButton_PKK;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Button SolveButton_PKK;
        private DataGridView DataGridViewFunction_PKK;
        private DataGridView DataGridViewResult_PKK;
    }
}
