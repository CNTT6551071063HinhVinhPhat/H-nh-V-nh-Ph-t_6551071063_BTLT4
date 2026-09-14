namespace cau14
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
            Button btnCapNhat;
            panel1 = new Panel();
            lbTen = new Label();
            txtTen = new TextBox();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnXoaLopA = new Button();
            btnKetThuc = new Button();
            btnXoaLopB = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCapNhat = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = SystemColors.ButtonFace;
            btnCapNhat.FlatStyle = FlatStyle.Popup;
            btnCapNhat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(663, 59);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(105, 29);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 40);
            panel1.TabIndex = 0;
            // 
            // lbTen
            // 
            lbTen.AutoSize = true;
            lbTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTen.Location = new Point(70, 63);
            lbTen.Name = "lbTen";
            lbTen.Size = new Size(60, 20);
            lbTen.TabIndex = 1;
            lbTen.Text = "Tên SV:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(184, 60);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(435, 27);
            txtTen.TabIndex = 2;
            txtTen.AcceptsTabChanged += txtTen_AcceptsTabChanged;
            txtTen.TextChanged += txtTen_TextChanged;
            txtTen.Enter += txtTen_TextChanged;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(70, 151);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(252, 204);
            lstLopA.TabIndex = 4;
            // 
            // lstLopB
            // 
            lstLopB.DisplayMember = "Le Duy Tinh";
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(526, 151);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(242, 204);
            lstLopB.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(368, 151);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(368, 211);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(368, 272);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = ">>";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(368, 326);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaLopA.Location = new Point(70, 370);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(166, 39);
            btnXoaLopA.TabIndex = 10;
            btnXoaLopA.Text = "Xóa Lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKetThuc.Location = new Point(338, 370);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(166, 39);
            btnKetThuc.TabIndex = 11;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaLopB.Location = new Point(602, 370);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(166, 39);
            btnXoaLopB.TabIndex = 12;
            btnXoaLopB.Text = "Xóa Lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 255);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 426);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 25);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(302, 20);
            label1.TabIndex = 0;
            label1.Text = "11/30/2011 10:51:52 AM Designed by Xavier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "Cập Nhật";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 9);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 1;
            label3.Text = "Hệ Thống";
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(btnXoaLopB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaLopA);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTen);
            Controls.Add(lbTen);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Cập Nhật 2 ListBox";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbTen;
        private TextBox txtTen;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnXoaLopA;
        private Button btnKetThuc;
        private Button btnXoaLopB;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
