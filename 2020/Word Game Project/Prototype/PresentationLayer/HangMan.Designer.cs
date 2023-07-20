
namespace WGame___Prototype_1.PresentationLayer
{
    partial class HangMan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangMan));
            this.hangman_title = new System.Windows.Forms.Label();
            this.letter_input_label = new System.Windows.Forms.Label();
            this.menu_choosegame = new System.Windows.Forms.Button();
            this.listIncorrect = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imgHang = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).BeginInit();
            this.SuspendLayout();
            // 
            // hangman_title
            // 
            this.hangman_title.AutoSize = true;
            this.hangman_title.BackColor = System.Drawing.Color.Transparent;
            this.hangman_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.hangman_title.Location = new System.Drawing.Point(11, 29);
            this.hangman_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hangman_title.Name = "hangman_title";
            this.hangman_title.Size = new System.Drawing.Size(219, 37);
            this.hangman_title.TabIndex = 1;
            this.hangman_title.Text = "Enter a Letter!";
            this.hangman_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // letter_input_label
            // 
            this.letter_input_label.AutoSize = true;
            this.letter_input_label.BackColor = System.Drawing.Color.Transparent;
            this.letter_input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.letter_input_label.Location = new System.Drawing.Point(84, 534);
            this.letter_input_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.letter_input_label.Name = "letter_input_label";
            this.letter_input_label.Size = new System.Drawing.Size(61, 24);
            this.letter_input_label.TabIndex = 3;
            this.letter_input_label.Text = "Letter:";
            // 
            // menu_choosegame
            // 
            this.menu_choosegame.Location = new System.Drawing.Point(1035, 344);
            this.menu_choosegame.Margin = new System.Windows.Forms.Padding(2);
            this.menu_choosegame.Name = "menu_choosegame";
            this.menu_choosegame.Size = new System.Drawing.Size(74, 32);
            this.menu_choosegame.TabIndex = 6;
            this.menu_choosegame.Text = "Check";
            this.menu_choosegame.UseVisualStyleBackColor = true;
            this.menu_choosegame.Click += new System.EventHandler(this.menu_choosegame_Click);
            // 
            // listIncorrect
            // 
            this.listIncorrect.FormattingEnabled = true;
            this.listIncorrect.Items.AddRange(new object[] {
            "Incorrect Words/Letters Guessed"});
            this.listIncorrect.Location = new System.Drawing.Point(417, 85);
            this.listIncorrect.Name = "listIncorrect";
            this.listIncorrect.ScrollAlwaysVisible = true;
            this.listIncorrect.Size = new System.Drawing.Size(195, 342);
            this.listIncorrect.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(256, 534);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Word:";
            // 
            // btnCheck
            // 
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.Location = new System.Drawing.Point(526, 537);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playGameToolStripMenuItem,
            this.progressToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(842, 29);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(102, 25);
            this.playGameToolStripMenuItem.Text = "Play Game";
            this.playGameToolStripMenuItem.Click += new System.EventHandler(this.playGameToolStripMenuItem_Click);
            // 
            // progressToolStripMenuItem
            // 
            this.progressToolStripMenuItem.Name = "progressToolStripMenuItem";
            this.progressToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.progressToolStripMenuItem.Text = "Progress";
            this.progressToolStripMenuItem.Click += new System.EventHandler(this.progressToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(50, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(427, 474);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(133, 37);
            this.lblWord.TabIndex = 13;
            this.lblWord.Text = "_ _ _ _ ";
            // 
            // txtWord
            // 
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(332, 534);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(169, 29);
            this.txtWord.TabIndex = 15;
            // 
            // txtLetter
            // 
            this.txtLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetter.Location = new System.Drawing.Point(150, 534);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(66, 29);
            this.txtLetter.TabIndex = 16;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "hm13.PNG");
            this.imageList1.Images.SetKeyName(1, "hm2.PNG");
            // 
            // imgHang
            // 
            this.imgHang.BackgroundImage = global::WGame___Prototype_1.Properties.Resources.hangman1;
            this.imgHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgHang.Location = new System.Drawing.Point(11, 85);
            this.imgHang.Margin = new System.Windows.Forms.Padding(2);
            this.imgHang.Name = "imgHang";
            this.imgHang.Size = new System.Drawing.Size(382, 426);
            this.imgHang.TabIndex = 0;
            this.imgHang.TabStop = false;
            // 
            // HangMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WGame___Prototype_1.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(842, 606);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listIncorrect);
            this.Controls.Add(this.menu_choosegame);
            this.Controls.Add(this.letter_input_label);
            this.Controls.Add(this.hangman_title);
            this.Controls.Add(this.imgHang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HangMan";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.HangMan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgHang;
        private System.Windows.Forms.Label hangman_title;
        private System.Windows.Forms.Label letter_input_label;
        private System.Windows.Forms.Button menu_choosegame;
        private System.Windows.Forms.ListBox listIncorrect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.ImageList imageList1;
    }
}