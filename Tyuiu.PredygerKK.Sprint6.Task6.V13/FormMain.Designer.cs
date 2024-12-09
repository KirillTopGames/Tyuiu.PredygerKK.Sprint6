namespace Tyuiu.PredygerKK.Sprint6.Task6.V13
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            ButtonsPanel_PKK = new Panel();
            HelpButton_PKK = new Button();
            OpenFileButton_PKK = new Button();
            SolveButton_PKK = new Button();
            ConditionPanel_PKK = new Panel();
            ConditionGroupBox_PKK = new GroupBox();
            ConditionTextBox_PKK = new TextBox();
            InputPanel_PKK = new Panel();
            InputGroupBox_PKK = new GroupBox();
            textBoxIn = new TextBox();
            OutputPanel_PKK = new Panel();
            OutputGroupBox_PKK = new GroupBox();
            textBoxOut = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            ButtonsPanel_PKK.SuspendLayout();
            ConditionPanel_PKK.SuspendLayout();
            ConditionGroupBox_PKK.SuspendLayout();
            InputPanel_PKK.SuspendLayout();
            InputGroupBox_PKK.SuspendLayout();
            OutputPanel_PKK.SuspendLayout();
            OutputGroupBox_PKK.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonsPanel_PKK
            // 
            ButtonsPanel_PKK.BorderStyle = BorderStyle.FixedSingle;
            ButtonsPanel_PKK.Controls.Add(HelpButton_PKK);
            ButtonsPanel_PKK.Controls.Add(OpenFileButton_PKK);
            ButtonsPanel_PKK.Controls.Add(SolveButton_PKK);
            ButtonsPanel_PKK.Dock = DockStyle.Top;
            ButtonsPanel_PKK.Location = new Point(0, 0);
            ButtonsPanel_PKK.Name = "ButtonsPanel_PKK";
            ButtonsPanel_PKK.Size = new Size(965, 105);
            ButtonsPanel_PKK.TabIndex = 0;
            // 
            // HelpButton_PKK
            // 
            HelpButton_PKK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HelpButton_PKK.BackColor = Color.FromArgb(128, 128, 255);
            HelpButton_PKK.Cursor = Cursors.Help;
            HelpButton_PKK.Font = new Font("Georgia", 24F, FontStyle.Bold);
            HelpButton_PKK.ForeColor = Color.White;
            HelpButton_PKK.Location = new Point(901, 11);
            HelpButton_PKK.Name = "HelpButton_PKK";
            HelpButton_PKK.Size = new Size(50, 50);
            HelpButton_PKK.TabIndex = 2;
            HelpButton_PKK.Text = "?";
            HelpButton_PKK.UseVisualStyleBackColor = false;
            HelpButton_PKK.Click += HelpButton_PKK_Click;
            // 
            // OpenFileButton_PKK
            // 
            OpenFileButton_PKK.BackColor = Color.LemonChiffon;
            OpenFileButton_PKK.Cursor = Cursors.Hand;
            OpenFileButton_PKK.Font = new Font("Georgia", 9F, FontStyle.Bold);
            OpenFileButton_PKK.Location = new Point(11, 11);
            OpenFileButton_PKK.Name = "OpenFileButton_PKK";
            OpenFileButton_PKK.Size = new Size(94, 78);
            OpenFileButton_PKK.TabIndex = 1;
            OpenFileButton_PKK.Text = "Открыть файл";
            toolTip.SetToolTip(OpenFileButton_PKK, "\r\nВыберите файл, который необходимо\r\nпреобразовать по указанному условию");
            OpenFileButton_PKK.UseVisualStyleBackColor = false;
            OpenFileButton_PKK.Click += OpenFileButton_PKK_Click;
            // 
            // SolveButton_PKK
            // 
            SolveButton_PKK.BackColor = Color.PaleGreen;
            SolveButton_PKK.Cursor = Cursors.Hand;
            SolveButton_PKK.Enabled = false;
            SolveButton_PKK.Font = new Font("Georgia", 12F, FontStyle.Bold);
            SolveButton_PKK.ForeColor = Color.Black;
            SolveButton_PKK.Location = new Point(151, 11);
            SolveButton_PKK.Name = "SolveButton_PKK";
            SolveButton_PKK.Size = new Size(94, 78);
            SolveButton_PKK.TabIndex = 0;
            SolveButton_PKK.Text = "Запуск";
            toolTip.SetToolTip(SolveButton_PKK, "\r\nПри нажатии преобразует файл по условию");
            SolveButton_PKK.UseVisualStyleBackColor = false;
            SolveButton_PKK.Click += SolveButton_PKK_Click;
            // 
            // ConditionPanel_PKK
            // 
            ConditionPanel_PKK.BackColor = SystemColors.ControlLight;
            ConditionPanel_PKK.BorderStyle = BorderStyle.Fixed3D;
            ConditionPanel_PKK.Controls.Add(ConditionGroupBox_PKK);
            ConditionPanel_PKK.Dock = DockStyle.Top;
            ConditionPanel_PKK.Location = new Point(0, 105);
            ConditionPanel_PKK.Name = "ConditionPanel_PKK";
            ConditionPanel_PKK.Size = new Size(965, 125);
            ConditionPanel_PKK.TabIndex = 1;
            // 
            // ConditionGroupBox_PKK
            // 
            ConditionGroupBox_PKK.Controls.Add(ConditionTextBox_PKK);
            ConditionGroupBox_PKK.Dock = DockStyle.Fill;
            ConditionGroupBox_PKK.Font = new Font("Georgia", 10F, FontStyle.Bold);
            ConditionGroupBox_PKK.Location = new Point(0, 0);
            ConditionGroupBox_PKK.Name = "ConditionGroupBox_PKK";
            ConditionGroupBox_PKK.Padding = new Padding(10);
            ConditionGroupBox_PKK.Size = new Size(961, 121);
            ConditionGroupBox_PKK.TabIndex = 0;
            ConditionGroupBox_PKK.TabStop = false;
            ConditionGroupBox_PKK.Text = "Условие: ";
            // 
            // ConditionTextBox_PKK
            // 
            ConditionTextBox_PKK.BackColor = Color.White;
            ConditionTextBox_PKK.Dock = DockStyle.Fill;
            ConditionTextBox_PKK.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConditionTextBox_PKK.Location = new Point(10, 29);
            ConditionTextBox_PKK.Multiline = true;
            ConditionTextBox_PKK.Name = "ConditionTextBox_PKK";
            ConditionTextBox_PKK.ReadOnly = true;
            ConditionTextBox_PKK.Size = new Size(941, 82);
            ConditionTextBox_PKK.TabIndex = 0;
            ConditionTextBox_PKK.Text = resources.GetString("ConditionTextBox_PKK.Text");
            // 
            // InputPanel_PKK
            // 
            InputPanel_PKK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InputPanel_PKK.Controls.Add(InputGroupBox_PKK);
            InputPanel_PKK.Location = new Point(0, 230);
            InputPanel_PKK.Name = "InputPanel_PKK";
            InputPanel_PKK.Padding = new Padding(10);
            InputPanel_PKK.Size = new Size(479, 315);
            InputPanel_PKK.TabIndex = 2;
            // 
            // InputGroupBox_PKK
            // 
            InputGroupBox_PKK.Controls.Add(textBoxIn);
            InputGroupBox_PKK.Dock = DockStyle.Fill;
            InputGroupBox_PKK.Font = new Font("Georgia", 9F, FontStyle.Bold);
            InputGroupBox_PKK.Location = new Point(10, 10);
            InputGroupBox_PKK.Name = "InputGroupBox_PKK";
            InputGroupBox_PKK.Padding = new Padding(10);
            InputGroupBox_PKK.Size = new Size(459, 295);
            InputGroupBox_PKK.TabIndex = 1;
            InputGroupBox_PKK.TabStop = false;
            InputGroupBox_PKK.Text = "Ввод: ";
            // 
            // textBoxIn
            // 
            textBoxIn.BackColor = Color.White;
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Location = new Point(10, 28);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ReadOnly = true;
            textBoxIn.ScrollBars = ScrollBars.Vertical;
            textBoxIn.Size = new Size(439, 257);
            textBoxIn.TabIndex = 0;
            // 
            // OutputPanel_PKK
            // 
            OutputPanel_PKK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OutputPanel_PKK.Controls.Add(OutputGroupBox_PKK);
            OutputPanel_PKK.Location = new Point(485, 230);
            OutputPanel_PKK.Name = "OutputPanel_PKK";
            OutputPanel_PKK.Padding = new Padding(10);
            OutputPanel_PKK.Size = new Size(480, 315);
            OutputPanel_PKK.TabIndex = 3;
            // 
            // OutputGroupBox_PKK
            // 
            OutputGroupBox_PKK.Controls.Add(textBoxOut);
            OutputGroupBox_PKK.Dock = DockStyle.Fill;
            OutputGroupBox_PKK.Font = new Font("Georgia", 9F, FontStyle.Bold);
            OutputGroupBox_PKK.Location = new Point(10, 10);
            OutputGroupBox_PKK.Name = "OutputGroupBox_PKK";
            OutputGroupBox_PKK.Padding = new Padding(10);
            OutputGroupBox_PKK.Size = new Size(460, 295);
            OutputGroupBox_PKK.TabIndex = 0;
            OutputGroupBox_PKK.TabStop = false;
            OutputGroupBox_PKK.Text = "Вывод: ";
            // 
            // textBoxOut
            // 
            textBoxOut.BackColor = Color.White;
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.Location = new Point(10, 28);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(440, 257);
            textBoxOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 545);
            Controls.Add(OutputPanel_PKK);
            Controls.Add(InputPanel_PKK);
            Controls.Add(ConditionPanel_PKK);
            Controls.Add(ButtonsPanel_PKK);
            MinimumSize = new Size(983, 592);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 13 | Предыгер К.К.";
            ButtonsPanel_PKK.ResumeLayout(false);
            ConditionPanel_PKK.ResumeLayout(false);
            ConditionGroupBox_PKK.ResumeLayout(false);
            ConditionGroupBox_PKK.PerformLayout();
            InputPanel_PKK.ResumeLayout(false);
            InputGroupBox_PKK.ResumeLayout(false);
            InputGroupBox_PKK.PerformLayout();
            OutputPanel_PKK.ResumeLayout(false);
            OutputGroupBox_PKK.ResumeLayout(false);
            OutputGroupBox_PKK.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ButtonsPanel_PKK;
        private Panel ConditionPanel_PKK;
        private Panel InputPanel_PKK;
        private Panel OutputPanel_PKK;
        private GroupBox InputGroupBox_PKK;
        private GroupBox ConditionGroupBox_PKK;
        private TextBox ConditionTextBox_PKK;
        private GroupBox OutputGroupBox_PKK;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
        private Button HelpButton_PKK;
        private Button OpenFileButton_PKK;
        private Button SolveButton_PKK;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
    }
}
