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
            this.tbCode = new System.Windows.Forms.TextBox();
            this.IntelliSenseWorker = new System.ComponentModel.BackgroundWorker();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1200, 33);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.ControlDark;
            this.status.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.status.Location = new System.Drawing.Point(0, 670);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.status.Size = new System.Drawing.Size(1200, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // lbCompletion
            // 
            this.lbCompletion.BackColor = System.Drawing.Color.DimGray;
            this.lbCompletion.Enabled = false;
            this.lbCompletion.ForeColor = System.Drawing.SystemColors.Window;
            this.lbCompletion.FormattingEnabled = true;
            this.lbCompletion.ItemHeight = 20;
            this.lbCompletion.Items.AddRange(new object[] {
            "Auto Complete"});
            this.lbCompletion.Location = new System.Drawing.Point(867, 148);
            this.lbCompletion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbCompletion.Name = "lbCompletion";
            this.lbCompletion.ScrollAlwaysVisible = true;
            this.lbCompletion.Size = new System.Drawing.Size(258, 184);
            this.lbCompletion.TabIndex = 3;
            this.lbCompletion.TabStop = false;
            this.lbCompletion.UseTabStops = false;
            this.lbCompletion.Visible = false;
            // 
            // tbCode
            // 
            this.tbCode.AcceptsTab = true;
            this.tbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCode.AutoCompleteCustomSource.AddRange(new string[] {
            "sevas"});
            this.tbCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbCode.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbCode.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCode.ForeColor = System.Drawing.SystemColors.Window;
            this.tbCode.Location = new System.Drawing.Point(18, 42);
            this.tbCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(1162, 596);
            this.tbCode.TabIndex = 4;
            this.tbCode.Text = "void setup() \r\n{\r\n\r\n}\r\n\r\nvoid loop()\r\n{\r\n\r\n}";
            this.tbCode.WordWrap = false;
            this.tbCode.TextChanged += new System.EventHandler(this.tbCode_TextChanged);
            this.tbCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCode_KeyDown);
            // 
            // IntelliSenseWorker
            // 
            this.IntelliSenseWorker.WorkerSupportsCancellation = true;
            this.IntelliSenseWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.IntelliSenseWorker_DoWork);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lbCompletion);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.TextBox tbCode;
        private System.ComponentModel.BackgroundWorker IntelliSenseWorker;
    }
}

