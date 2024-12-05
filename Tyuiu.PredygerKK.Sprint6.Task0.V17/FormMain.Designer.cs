
namespace Tyuiu.PredygerKK.Sprint6.Task0.V17
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
            pictureBoxFormula_PKK = new PictureBox();
            TextBoxCondition_PKK = new TextBox();
            TextBoxTask_PKK = new TextBox();
            TextBoxInPutText_PKK = new TextBox();
            TextBoxInPut_PKK = new TextBox();
            TextBoxResultText_PKK = new TextBox();
            TextBoxResult_PKK = new TextBox();
            SolveButton_PKK = new Button();
            ButtonHelp_PKK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PKK).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFormula_PKK
            // 
            pictureBoxFormula_PKK.Image = (Image)resources.GetObject("pictureBoxFormula_PKK.Image");
            pictureBoxFormula_PKK.Location = new Point(653, 12);
            pictureBoxFormula_PKK.Name = "pictureBoxFormula_PKK";
            pictureBoxFormula_PKK.Size = new Size(135, 102);
            pictureBoxFormula_PKK.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFormula_PKK.TabIndex = 0;
            pictureBoxFormula_PKK.TabStop = false;
            // 
            // TextBoxCondition_PKK
            // 
            TextBoxCondition_PKK.Location = new Point(12, 12);
            TextBoxCondition_PKK.Name = "TextBoxCondition_PKK";
            TextBoxCondition_PKK.ReadOnly = true;
            TextBoxCondition_PKK.Size = new Size(125, 27);
            TextBoxCondition_PKK.TabIndex = 1;
            TextBoxCondition_PKK.Text = "Условие\r\n";
            TextBoxCondition_PKK.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxTask_PKK
            // 
            TextBoxTask_PKK.AccessibleDescription = "";
            TextBoxTask_PKK.AccessibleName = "";
            TextBoxTask_PKK.BackColor = SystemColors.Control;
            TextBoxTask_PKK.Location = new Point(12, 41);
            TextBoxTask_PKK.Multiline = true;
            TextBoxTask_PKK.Name = "TextBoxTask_PKK";
            TextBoxTask_PKK.ReadOnly = true;
            TextBoxTask_PKK.Size = new Size(635, 73);
            TextBoxTask_PKK.TabIndex = 2;
            TextBoxTask_PKK.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.";
            // 
            // TextBoxInPutText_PKK
            // 
            TextBoxInPutText_PKK.Location = new Point(92, 299);
            TextBoxInPutText_PKK.Name = "TextBoxInPutText_PKK";
            TextBoxInPutText_PKK.ReadOnly = true;
            TextBoxInPutText_PKK.Size = new Size(125, 27);
            TextBoxInPutText_PKK.TabIndex = 3;
            TextBoxInPutText_PKK.Text = "Ввод данных\r\n (x)";
            TextBoxInPutText_PKK.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxInPut_PKK
            // 
            TextBoxInPut_PKK.BorderStyle = BorderStyle.FixedSingle;
            TextBoxInPut_PKK.Location = new Point(92, 332);
            TextBoxInPut_PKK.Name = "TextBoxInPut_PKK";
            TextBoxInPut_PKK.Size = new Size(125, 27);
            TextBoxInPut_PKK.TabIndex = 4;
            // 
            // TextBoxResultText_PKK
            // 
            TextBoxResultText_PKK.BackColor = SystemColors.Control;
            TextBoxResultText_PKK.ForeColor = SystemColors.HotTrack;
            TextBoxResultText_PKK.Location = new Point(587, 299);
            TextBoxResultText_PKK.Name = "TextBoxResultText_PKK";
            TextBoxResultText_PKK.ReadOnly = true;
            TextBoxResultText_PKK.Size = new Size(125, 27);
            TextBoxResultText_PKK.TabIndex = 5;
            TextBoxResultText_PKK.Text = "Вывод данных\r\n";
            TextBoxResultText_PKK.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxResult_PKK
            // 
            TextBoxResult_PKK.BorderStyle = BorderStyle.FixedSingle;
            TextBoxResult_PKK.Location = new Point(587, 332);
            TextBoxResult_PKK.Name = "TextBoxResult_PKK";
            TextBoxResult_PKK.ReadOnly = true;
            TextBoxResult_PKK.Size = new Size(125, 27);
            TextBoxResult_PKK.TabIndex = 6;
            TextBoxResult_PKK.TextChanged += TextBoxResult_PKK_TextChanged;
            // 
            // SolveButton_PKK
            // 
            SolveButton_PKK.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SolveButton_PKK.Location = new Point(653, 388);
            SolveButton_PKK.Name = "SolveButton_PKK";
            SolveButton_PKK.Size = new Size(135, 50);
            SolveButton_PKK.TabIndex = 7;
            SolveButton_PKK.Text = "Вычислить";
            SolveButton_PKK.UseVisualStyleBackColor = true;
            SolveButton_PKK.Click += SolveButton_PKK_Click;
            // 
            // ButtonHelp_PKK
            // 
            ButtonHelp_PKK.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            ButtonHelp_PKK.Location = new Point(598, 388);
            ButtonHelp_PKK.Name = "ButtonHelp_PKK";
            ButtonHelp_PKK.Size = new Size(49, 50);
            ButtonHelp_PKK.TabIndex = 8;
            ButtonHelp_PKK.Text = "?";
            ButtonHelp_PKK.UseVisualStyleBackColor = true;
            ButtonHelp_PKK.Click += ButtonHelp_PKK_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonHelp_PKK);
            Controls.Add(SolveButton_PKK);
            Controls.Add(TextBoxResult_PKK);
            Controls.Add(TextBoxResultText_PKK);
            Controls.Add(TextBoxInPut_PKK);
            Controls.Add(TextBoxInPutText_PKK);
            Controls.Add(TextBoxTask_PKK);
            Controls.Add(TextBoxCondition_PKK);
            Controls.Add(pictureBoxFormula_PKK);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 17 | Предыгер К.К.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PKK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxFormula_PKK;
        private TextBox TextBoxCondition_PKK;
        private TextBox TextBoxTask_PKK;
        private TextBox TextBoxInPutText_PKK;
        private TextBox TextBoxInPut_PKK;
        private TextBox TextBoxResultText_PKK;
        private TextBox TextBoxResult_PKK;
        private Button SolveButton_PKK;
        private Button ButtonHelp_PKK;
    }
}
