namespace cau16
{
    partial class StepByStep2_19
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
            components = new System.ComponentModel.Container();
            dlgColor = new ColorDialog();
            mnuMainMenu = new MenuStrip();
            mnuContext = new ContextMenuStrip(components);
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            dlgOpenFile = new OpenFileDialog();
            dlgSaveFile = new SaveFileDialog();
            dlgFont = new FontDialog();
            mnuContext.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMainMenu
            // 
            mnuMainMenu.ImageScalingSize = new Size(20, 20);
            mnuMainMenu.Location = new Point(0, 0);
            mnuMainMenu.Name = "mnuMainMenu";
            mnuMainMenu.Size = new Size(800, 24);
            mnuMainMenu.TabIndex = 1;
            // 
            // mnuContext
            // 
            mnuContext.ImageScalingSize = new Size(20, 20);
            mnuContext.Items.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            mnuContext.Name = "contextMenuStrip1";
            mnuContext.Size = new Size(113, 76);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(210, 24);
            cutToolStripMenuItem.Text = "&Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(210, 24);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(210, 24);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.FileName = "openFileDialog1";
            // 
            // StepByStep2_19
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuMainMenu);
            Name = "StepByStep2_19";
            Text = "StepByStep2_19";
            mnuContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog dlgColor;
        private MenuStrip mnuMainMenu;
        private ContextMenuStrip mnuContext;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private OpenFileDialog dlgOpenFile;
        private SaveFileDialog dlgSaveFile;
        private FontDialog dlgFont;
    }
}