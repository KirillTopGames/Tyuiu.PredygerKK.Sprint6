namespace Tyuiu.PredygerKK.Sprint6.Task7.V8
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
            SolveButton_PKK = new Button();
            HelpButton_PKK = new Button();
            SaveFileButton_PKK = new Button();
            OpenFileButton_PKK = new Button();
            ConditionGroupBox_PKK = new GroupBox();
            ConditionTextBox_PKK = new TextBox();
            ConditionPanel_PKK = new Panel();
            InputOutputPanel_PKK = new SplitContainer();
            InputGroupBox_PKK = new GroupBox();
            dataGridInput_PKK = new DataGridView();
            OutputGroupBox_PKK = new GroupBox();
            dataGridOutput_PKK = new DataGridView();
            openFileDialogTask_PKK = new OpenFileDialog();
            saveFileDialogMatrix_PKK = new SaveFileDialog();
            toolTipButton = new ToolTip(components);
            ButtonsPanel_PKK.SuspendLayout();
            ConditionGroupBox_PKK.SuspendLayout();
            ConditionPanel_PKK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputOutputPanel_PKK).BeginInit();
            InputOutputPanel_PKK.Panel1.SuspendLayout();
            InputOutputPanel_PKK.Panel2.SuspendLayout();
            InputOutputPanel_PKK.SuspendLayout();
            InputGroupBox_PKK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridInput_PKK).BeginInit();
            OutputGroupBox_PKK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOutput_PKK).BeginInit();
            SuspendLayout();
            // 
            // ButtonsPanel_PKK
            // 
            ButtonsPanel_PKK.BorderStyle = BorderStyle.FixedSingle;
            ButtonsPanel_PKK.Controls.Add(SolveButton_PKK);
            ButtonsPanel_PKK.Controls.Add(HelpButton_PKK);
            ButtonsPanel_PKK.Controls.Add(SaveFileButton_PKK);
            ButtonsPanel_PKK.Controls.Add(OpenFileButton_PKK);
            ButtonsPanel_PKK.Dock = DockStyle.Top;
            ButtonsPanel_PKK.Location = new Point(0, 0);
            ButtonsPanel_PKK.Margin = new Padding(3, 2, 3, 2);
            ButtonsPanel_PKK.Name = "ButtonsPanel_PKK";
            ButtonsPanel_PKK.Size = new Size(800, 86);
            ButtonsPanel_PKK.TabIndex = 1;
            // 
            // SolveButton_PKK
            // 
            SolveButton_PKK.BackColor = Color.PaleGreen;
            SolveButton_PKK.Enabled = false;
            SolveButton_PKK.Image = (Image)resources.GetObject("SolveButton_PKK.Image");
            SolveButton_PKK.Location = new Point(98, 10);
            SolveButton_PKK.Name = "SolveButton_PKK";
            SolveButton_PKK.Size = new Size(82, 62);
            SolveButton_PKK.TabIndex = 6;
            toolTipButton.SetToolTip(SolveButton_PKK, "Запустить программу");
            SolveButton_PKK.UseVisualStyleBackColor = false;
            SolveButton_PKK.Click += SolveButton_PKK_Click;
            SolveButton_PKK.MouseEnter += SolveButton_PKK_MouseEnter;
            SolveButton_PKK.MouseLeave += SolveButton_PKK_MouseLeave;
            // 
            // HelpButton_PKK
            // 
            HelpButton_PKK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            HelpButton_PKK.BackColor = Color.White;
            HelpButton_PKK.Image = (Image)resources.GetObject("HelpButton_PKK.Image");
            HelpButton_PKK.Location = new Point(747, 11);
            HelpButton_PKK.Name = "HelpButton_PKK";
            HelpButton_PKK.Size = new Size(40, 40);
            HelpButton_PKK.TabIndex = 5;
            toolTipButton.SetToolTip(HelpButton_PKK, "О программе");
            HelpButton_PKK.UseVisualStyleBackColor = false;
            HelpButton_PKK.Click += HelpButton_PKK_Click;
            HelpButton_PKK.MouseEnter += HelpButton_PKK_MouseEnter;
            HelpButton_PKK.MouseLeave += HelpButton_PKK_MouseLeave;
            // 
            // SaveFileButton_PKK
            // 
            SaveFileButton_PKK.BackColor = Color.CornflowerBlue;
            SaveFileButton_PKK.Enabled = false;
            SaveFileButton_PKK.Image = (Image)resources.GetObject("SaveFileButton_PKK.Image");
            SaveFileButton_PKK.Location = new Point(186, 10);
            SaveFileButton_PKK.Name = "SaveFileButton_PKK";
            SaveFileButton_PKK.Size = new Size(82, 63);
            SaveFileButton_PKK.TabIndex = 4;
            toolTipButton.SetToolTip(SaveFileButton_PKK, "Сохранить результат в любую директорию");
            SaveFileButton_PKK.UseVisualStyleBackColor = false;
            SaveFileButton_PKK.Click += SaveFileButton_PKK_Click;
            SaveFileButton_PKK.MouseEnter += SaveFileButton_PKK_MouseEnter;
            SaveFileButton_PKK.MouseLeave += SaveFileButton_PKK_MouseLeave;
            // 
            // OpenFileButton_PKK
            // 
            OpenFileButton_PKK.BackColor = Color.LemonChiffon;
            OpenFileButton_PKK.Cursor = Cursors.Hand;
            OpenFileButton_PKK.Font = new Font("Georgia", 9F, FontStyle.Bold);
            OpenFileButton_PKK.Image = (Image)resources.GetObject("OpenFileButton_PKK.Image");
            OpenFileButton_PKK.Location = new Point(10, 8);
            OpenFileButton_PKK.Margin = new Padding(3, 2, 3, 2);
            OpenFileButton_PKK.Name = "OpenFileButton_PKK";
            OpenFileButton_PKK.Size = new Size(82, 65);
            OpenFileButton_PKK.TabIndex = 1;
            toolTipButton.SetToolTip(OpenFileButton_PKK, "Выберите файл, который необходимо открыть");
            OpenFileButton_PKK.UseVisualStyleBackColor = false;
            OpenFileButton_PKK.Click += OpenFileButton_PKK_Click;
            OpenFileButton_PKK.MouseEnter += OpenFileButton_PKK_MouseEnter;
            OpenFileButton_PKK.MouseLeave += OpenFileButton_PKK_MouseLeave;
            // 
            // ConditionGroupBox_PKK
            // 
            ConditionGroupBox_PKK.Controls.Add(ConditionTextBox_PKK);
            ConditionGroupBox_PKK.Dock = DockStyle.Fill;
            ConditionGroupBox_PKK.Font = new Font("Georgia", 10F, FontStyle.Bold);
            ConditionGroupBox_PKK.Location = new Point(0, 0);
            ConditionGroupBox_PKK.Margin = new Padding(3, 2, 3, 2);
            ConditionGroupBox_PKK.Name = "ConditionGroupBox_PKK";
            ConditionGroupBox_PKK.Padding = new Padding(9, 8, 9, 8);
            ConditionGroupBox_PKK.Size = new Size(796, 98);
            ConditionGroupBox_PKK.TabIndex = 0;
            ConditionGroupBox_PKK.TabStop = false;
            ConditionGroupBox_PKK.Text = "Условие: ";
            // 
            // ConditionTextBox_PKK
            // 
            ConditionTextBox_PKK.BackColor = Color.White;
            ConditionTextBox_PKK.Dock = DockStyle.Fill;
            ConditionTextBox_PKK.Font = new Font("Georgia", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConditionTextBox_PKK.Location = new Point(9, 24);
            ConditionTextBox_PKK.Margin = new Padding(3, 2, 3, 2);
            ConditionTextBox_PKK.Multiline = true;
            ConditionTextBox_PKK.Name = "ConditionTextBox_PKK";
            ConditionTextBox_PKK.ReadOnly = true;
            ConditionTextBox_PKK.Size = new Size(778, 66);
            ConditionTextBox_PKK.TabIndex = 0;
            ConditionTextBox_PKK.Text = resources.GetString("ConditionTextBox_PKK.Text");
            // 
            // ConditionPanel_PKK
            // 
            ConditionPanel_PKK.BackColor = SystemColors.ControlLight;
            ConditionPanel_PKK.BorderStyle = BorderStyle.Fixed3D;
            ConditionPanel_PKK.Controls.Add(ConditionGroupBox_PKK);
            ConditionPanel_PKK.Dock = DockStyle.Top;
            ConditionPanel_PKK.Location = new Point(0, 86);
            ConditionPanel_PKK.Margin = new Padding(3, 2, 3, 2);
            ConditionPanel_PKK.Name = "ConditionPanel_PKK";
            ConditionPanel_PKK.Size = new Size(800, 102);
            ConditionPanel_PKK.TabIndex = 2;
            // 
            // InputOutputPanel_PKK
            // 
            InputOutputPanel_PKK.Dock = DockStyle.Fill;
            InputOutputPanel_PKK.Location = new Point(0, 188);
            InputOutputPanel_PKK.Name = "InputOutputPanel_PKK";
            // 
            // InputOutputPanel_PKK.Panel1
            // 
            InputOutputPanel_PKK.Panel1.Controls.Add(InputGroupBox_PKK);
            // 
            // InputOutputPanel_PKK.Panel2
            // 
            InputOutputPanel_PKK.Panel2.Controls.Add(OutputGroupBox_PKK);
            InputOutputPanel_PKK.Size = new Size(800, 262);
            InputOutputPanel_PKK.SplitterDistance = 398;
            InputOutputPanel_PKK.TabIndex = 3;
            // 
            // InputGroupBox_PKK
            // 
            InputGroupBox_PKK.Controls.Add(dataGridInput_PKK);
            InputGroupBox_PKK.Dock = DockStyle.Fill;
            InputGroupBox_PKK.Font = new Font("Georgia", 9F, FontStyle.Bold);
            InputGroupBox_PKK.Location = new Point(0, 0);
            InputGroupBox_PKK.Margin = new Padding(3, 2, 3, 2);
            InputGroupBox_PKK.Name = "InputGroupBox_PKK";
            InputGroupBox_PKK.Padding = new Padding(9, 8, 9, 8);
            InputGroupBox_PKK.Size = new Size(398, 262);
            InputGroupBox_PKK.TabIndex = 2;
            InputGroupBox_PKK.TabStop = false;
            InputGroupBox_PKK.Text = "Ввод: ";
            // 
            // dataGridInput_PKK
            // 
            dataGridInput_PKK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInput_PKK.ColumnHeadersVisible = false;
            dataGridInput_PKK.Dock = DockStyle.Fill;
            dataGridInput_PKK.Location = new Point(9, 22);
            dataGridInput_PKK.Name = "dataGridInput_PKK";
            dataGridInput_PKK.ReadOnly = true;
            dataGridInput_PKK.RowHeadersVisible = false;
            dataGridInput_PKK.Size = new Size(380, 232);
            dataGridInput_PKK.TabIndex = 0;
            // 
            // OutputGroupBox_PKK
            // 
            OutputGroupBox_PKK.Controls.Add(dataGridOutput_PKK);
            OutputGroupBox_PKK.Dock = DockStyle.Fill;
            OutputGroupBox_PKK.Font = new Font("Georgia", 9F, FontStyle.Bold);
            OutputGroupBox_PKK.Location = new Point(0, 0);
            OutputGroupBox_PKK.Margin = new Padding(3, 2, 3, 2);
            OutputGroupBox_PKK.Name = "OutputGroupBox_PKK";
            OutputGroupBox_PKK.Padding = new Padding(9, 8, 9, 8);
            OutputGroupBox_PKK.Size = new Size(398, 262);
            OutputGroupBox_PKK.TabIndex = 1;
            OutputGroupBox_PKK.TabStop = false;
            OutputGroupBox_PKK.Text = "Вывод: ";
            // 
            // dataGridOutput_PKK
            // 
            dataGridOutput_PKK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOutput_PKK.ColumnHeadersVisible = false;
            dataGridOutput_PKK.Dock = DockStyle.Fill;
            dataGridOutput_PKK.EnableHeadersVisualStyles = false;
            dataGridOutput_PKK.Location = new Point(9, 22);
            dataGridOutput_PKK.Name = "dataGridOutput_PKK";
            dataGridOutput_PKK.ReadOnly = true;
            dataGridOutput_PKK.RowHeadersVisible = false;
            dataGridOutput_PKK.Size = new Size(380, 232);
            dataGridOutput_PKK.TabIndex = 1;
            // 
            // openFileDialogTask_PKK
            // 
            openFileDialogTask_PKK.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            toolTipButton.ForeColor = SystemColors.Highlight;
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InputOutputPanel_PKK);
            Controls.Add(ConditionPanel_PKK);
            Controls.Add(ButtonsPanel_PKK);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 8 | Предыгер К.К";
            ButtonsPanel_PKK.ResumeLayout(false);
            ConditionGroupBox_PKK.ResumeLayout(false);
            ConditionGroupBox_PKK.PerformLayout();
            ConditionPanel_PKK.ResumeLayout(false);
            InputOutputPanel_PKK.Panel1.ResumeLayout(false);
            InputOutputPanel_PKK.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InputOutputPanel_PKK).EndInit();
            InputOutputPanel_PKK.ResumeLayout(false);
            InputGroupBox_PKK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridInput_PKK).EndInit();
            OutputGroupBox_PKK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOutput_PKK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ButtonsPanel_PKK;
        private Button OpenFileButton_PKK;
        private GroupBox ConditionGroupBox_PKK;
        private TextBox ConditionTextBox_PKK;
        private Panel ConditionPanel_PKK;
        private SplitContainer InputOutputPanel_PKK;
        private GroupBox InputGroupBox_PKK;
        private GroupBox OutputGroupBox_PKK;
        private DataGridView dataGridInput_PKK;
        private DataGridView dataGridOutput_PKK;
        private Button SaveFileButton_PKK;
        private OpenFileDialog openFileDialogTask_PKK;
        private SaveFileDialog saveFileDialogMatrix_PKK;
        private Button HelpButton_PKK;
        private Button SolveButton_PKK;
        private ToolTip toolTipButton;
    }
}
