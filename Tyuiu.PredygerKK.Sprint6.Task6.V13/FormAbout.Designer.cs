namespace Tyuiu.PredygerKK.Sprint6.Task6.V13
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_PKK = new PictureBox();
            labelInfo = new Label();
            CloseButton_PKK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_PKK).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_PKK
            // 
            pictureBoxAvatar_PKK.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxAvatar_PKK.Image = (Image)resources.GetObject("pictureBoxAvatar_PKK.Image");
            pictureBoxAvatar_PKK.Location = new Point(12, 12);
            pictureBoxAvatar_PKK.Name = "pictureBoxAvatar_PKK";
            pictureBoxAvatar_PKK.Size = new Size(250, 340);
            pictureBoxAvatar_PKK.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_PKK.TabIndex = 0;
            pictureBoxAvatar_PKK.TabStop = false;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Georgia", 12F);
            labelInfo.Location = new Point(283, 12);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(505, 216);
            labelInfo.TabIndex = 1;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // CloseButton_PKK
            // 
            CloseButton_PKK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseButton_PKK.BackColor = SystemColors.ButtonHighlight;
            CloseButton_PKK.Cursor = Cursors.Hand;
            CloseButton_PKK.Font = new Font("Georgia", 10F);
            CloseButton_PKK.Location = new Point(686, 311);
            CloseButton_PKK.Name = "CloseButton_PKK";
            CloseButton_PKK.Size = new Size(102, 41);
            CloseButton_PKK.TabIndex = 2;
            CloseButton_PKK.Text = "Закрыть";
            CloseButton_PKK.UseVisualStyleBackColor = false;
            CloseButton_PKK.Click += CloseButton_PKK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 364);
            Controls.Add(CloseButton_PKK);
            Controls.Add(labelInfo);
            Controls.Add(pictureBoxAvatar_PKK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_PKK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_PKK;
        private Label labelInfo;
        private Button CloseButton_PKK;
    }
}