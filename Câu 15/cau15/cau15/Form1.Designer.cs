namespace cau15
{
    partial class Form1
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
            lbColor = new Label();
            lbSize = new Label();
            dudColor = new DomainUpDown();
            nudSize = new NumericUpDown();
            lblSampleText = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            SuspendLayout();
            // 
            // lbColor
            // 
            lbColor.AutoSize = true;
            lbColor.Location = new Point(193, 110);
            lbColor.Name = "lbColor";
            lbColor.Size = new Size(48, 20);
            lbColor.TabIndex = 0;
            lbColor.Text = "Color:";
            lbColor.Click += lbColor_Click;
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Location = new Point(193, 175);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(39, 20);
            lbSize.TabIndex = 1;
            lbSize.Text = "Size:";
            // 
            // dudColor
            // 
            dudColor.Location = new Point(337, 103);
            dudColor.Name = "dudColor";
            dudColor.Size = new Size(150, 27);
            dudColor.TabIndex = 2;
            dudColor.Text = "Green";
            dudColor.UpDownAlign = LeftRightAlignment.Left;
            dudColor.SelectedItemChanged += dudColor_SelectedItemChanged;
            // 
            // nudSize
            // 
            nudSize.Location = new Point(337, 168);
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(150, 27);
            nudSize.TabIndex = 3;
            nudSize.Value = new decimal(new int[] { 16, 0, 0, 0 });
            nudSize.ValueChanged += nudSize_ValueChanged;
            // 
            // lblSampleText
            // 
            lblSampleText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSampleText.AutoSize = true;
            lblSampleText.BackColor = SystemColors.ControlLight;
            lblSampleText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSampleText.Location = new Point(311, 306);
            lblSampleText.Name = "lblSampleText";
            lblSampleText.Size = new Size(144, 31);
            lblSampleText.TabIndex = 4;
            lblSampleText.Text = "Sample Text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSampleText);
            Controls.Add(nudSize);
            Controls.Add(dudColor);
            Controls.Add(lbSize);
            Controls.Add(lbColor);
            Name = "Form1";
            Text = "StepByStep2_12";
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbColor;
        private Label lbSize;
        private DomainUpDown dudColor;
        private NumericUpDown nudSize;
        private Label lblSampleText;
    }
}
