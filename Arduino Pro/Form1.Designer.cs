namespace Arduino_Pro
{
    partial class MainWindow
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lbCompletion = new System.Windows.Forms.ListBox();
            this.IntelliSenseWorker = new System.ComponentModel.BackgroundWorker();
            this.tbCode = new System.Windows.Forms.RichTextBox();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuMain.Size = new System.Drawing.Size(800, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.ControlDark;
            this.status.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.status.Location = new System.Drawing.Point(0, 428);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(800, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // lbCompletion
            // 
            this.lbCompletion.BackColor = System.Drawing.Color.DimGray;
            this.lbCompletion.Enabled = false;
            this.lbCompletion.ForeColor = System.Drawing.SystemColors.Window;
            this.lbCompletion.FormattingEnabled = true;
            this.lbCompletion.Items.AddRange(new object[] {
            "Auto Complete"});
            this.lbCompletion.Location = new System.Drawing.Point(578, 96);
            this.lbCompletion.Name = "lbCompletion";
            this.lbCompletion.ScrollAlwaysVisible = true;
            this.lbCompletion.Size = new System.Drawing.Size(179, 121);
            this.lbCompletion.TabIndex = 3;
            this.lbCompletion.TabStop = false;
            this.lbCompletion.UseTabStops = false;
            this.lbCompletion.Visible = false;
            // 
            // IntelliSenseWorker
            // 
            this.IntelliSenseWorker.WorkerSupportsCancellation = true;
            // 
            // tbCode
            // 
            this.tbCode.AcceptsTab = true;
            this.tbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCode.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.ForeColor = System.Drawing.SystemColors.Window;
            this.tbCode.Location = new System.Drawing.Point(8, 31);
            this.tbCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(785, 398);
            this.tbCode.TabIndex = 4;
            this.tbCode.Text = "void setup() \n{\n\n}\n\nvoid loop()\n{\n\n}";
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            this.tbCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCode_KeyPress);
            this.tbCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbCode_PreviewKeyDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lbCompletion);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Arduino";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ListBox lbCompletion;
        private System.ComponentModel.BackgroundWorker IntelliSenseWorker;
        public System.Windows.Forms.RichTextBox tbCode;
    }
}

