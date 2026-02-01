namespace RandomNotes
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelCountdownGuatemala = new System.Windows.Forms.Label();
            this.pictureBoxGuatemala = new System.Windows.Forms.PictureBox();
            this.monthCalendarGuatemala = new System.Windows.Forms.MonthCalendar();
            this.NotePad = new System.Windows.Forms.Label();
            this.gif = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxEditor = new System.Windows.Forms.RichTextBox();
            this.pictureBoxGif = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuatemala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCountdownGuatemala
            // 
            this.labelCountdownGuatemala.AutoSize = true;
            this.labelCountdownGuatemala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCountdownGuatemala.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelCountdownGuatemala.Location = new System.Drawing.Point(834, 64);
            this.labelCountdownGuatemala.Name = "labelCountdownGuatemala";
            this.labelCountdownGuatemala.Size = new System.Drawing.Size(305, 27);
            this.labelCountdownGuatemala.TabIndex = 4;
            this.labelCountdownGuatemala.Text = "Select a Date to See Countdown";
            // 
            // pictureBoxGuatemala
            // 
            this.pictureBoxGuatemala.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGuatemala.Image")));
            this.pictureBoxGuatemala.Location = new System.Drawing.Point(72, 364);
            this.pictureBoxGuatemala.Name = "pictureBoxGuatemala";
            this.pictureBoxGuatemala.Size = new System.Drawing.Size(322, 184);
            this.pictureBoxGuatemala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGuatemala.TabIndex = 3;
            this.pictureBoxGuatemala.TabStop = false;
            // 
            // monthCalendarGuatemala
            // 
            this.monthCalendarGuatemala.Location = new System.Drawing.Point(864, 122);
            this.monthCalendarGuatemala.Name = "monthCalendarGuatemala";
            this.monthCalendarGuatemala.TabIndex = 2;
            this.monthCalendarGuatemala.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarGuatemala_DateChanged);
            // 
            // NotePad
            // 
            this.NotePad.AutoSize = true;
            this.NotePad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NotePad.Location = new System.Drawing.Point(73, 61);
            this.NotePad.Name = "NotePad";
            this.NotePad.Size = new System.Drawing.Size(157, 25);
            this.NotePad.TabIndex = 1;
            this.NotePad.Text = "Trip Notes Editor";
            // 
            // gif
            // 
            this.gif.Location = new System.Drawing.Point(0, 0);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(100, 50);
            this.gif.TabIndex = 0;
            this.gif.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 30);
            this.menuStrip1.TabIndex = 5;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // richTextBoxEditor
            // 
            this.richTextBoxEditor.Location = new System.Drawing.Point(72, 101);
            this.richTextBoxEditor.Name = "richTextBoxEditor";
            this.richTextBoxEditor.Size = new System.Drawing.Size(635, 228);
            this.richTextBoxEditor.TabIndex = 0;
            this.richTextBoxEditor.Text = "";
            this.richTextBoxEditor.TextChanged += new System.EventHandler(this.richTextBoxEditor_TextChanged);
            // 
            // pictureBoxGif
            // 
            this.pictureBoxGif.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGif.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGif.Image")));
            this.pictureBoxGif.Location = new System.Drawing.Point(864, 364);
            this.pictureBoxGif.Name = "pictureBoxGif";
            this.pictureBoxGif.Size = new System.Drawing.Size(262, 184);
            this.pictureBoxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGif.TabIndex = 6;
            this.pictureBoxGif.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(523, 416);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(184, 49);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // FormMain
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 602);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureBoxGif);
            this.Controls.Add(this.richTextBoxEditor);
            this.Controls.Add(this.NotePad);
            this.Controls.Add(this.monthCalendarGuatemala);
            this.Controls.Add(this.pictureBoxGuatemala);
            this.Controls.Add(this.labelCountdownGuatemala);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "My Trips";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuatemala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 🔑 REQUIRED FIELD DECLARATIONS (THIS WAS MISSING)
        private System.Windows.Forms.Label labelCountdownGuatemala;
        private System.Windows.Forms.PictureBox pictureBoxGuatemala;
        private System.Windows.Forms.MonthCalendar monthCalendarGuatemala;
        private System.Windows.Forms.Label NotePad;
        private System.Windows.Forms.PictureBox gif;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxEditor;
        private System.Windows.Forms.PictureBox pictureBoxGif;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}
