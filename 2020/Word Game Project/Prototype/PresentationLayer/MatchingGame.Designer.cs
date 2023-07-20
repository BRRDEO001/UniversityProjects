
namespace WGame___Prototype_1.PresentationLayer
{
    partial class MatchingGame
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
            this.matchinggame_title = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.btnWord1 = new System.Windows.Forms.Button();
            this.btnWord2 = new System.Windows.Forms.Button();
            this.btnWord3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matchinggame_title
            // 
            this.matchinggame_title.AutoSize = true;
            this.matchinggame_title.BackColor = System.Drawing.Color.Transparent;
            this.matchinggame_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.matchinggame_title.Location = new System.Drawing.Point(121, 91);
            this.matchinggame_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matchinggame_title.Name = "matchinggame_title";
            this.matchinggame_title.Size = new System.Drawing.Size(369, 37);
            this.matchinggame_title.TabIndex = 0;
            this.matchinggame_title.Text = "Select The Correct Word";
            this.matchinggame_title.Click += new System.EventHandler(this.matchinggame_title_Click);
            // 
            // img
            // 
            this.img.Image = global::WGame___Prototype_1.Properties.Resources.download;
            this.img.Location = new System.Drawing.Point(70, 162);
            this.img.Margin = new System.Windows.Forms.Padding(2);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(159, 255);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 1;
            this.img.TabStop = false;
            this.img.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnWord1
            // 
            this.btnWord1.Location = new System.Drawing.Point(337, 185);
            this.btnWord1.Margin = new System.Windows.Forms.Padding(2);
            this.btnWord1.Name = "btnWord1";
            this.btnWord1.Size = new System.Drawing.Size(207, 60);
            this.btnWord1.TabIndex = 2;
            this.btnWord1.Text = "Hond";
            this.btnWord1.UseVisualStyleBackColor = true;
            this.btnWord1.Click += new System.EventHandler(this.word1_button_Click);
            // 
            // btnWord2
            // 
            this.btnWord2.Location = new System.Drawing.Point(337, 260);
            this.btnWord2.Margin = new System.Windows.Forms.Padding(2);
            this.btnWord2.Name = "btnWord2";
            this.btnWord2.Size = new System.Drawing.Size(207, 60);
            this.btnWord2.TabIndex = 3;
            this.btnWord2.Text = "Kameelperd";
            this.btnWord2.UseVisualStyleBackColor = true;
            this.btnWord2.Click += new System.EventHandler(this.word2_label_Click);
            // 
            // btnWord3
            // 
            this.btnWord3.Location = new System.Drawing.Point(337, 340);
            this.btnWord3.Margin = new System.Windows.Forms.Padding(2);
            this.btnWord3.Name = "btnWord3";
            this.btnWord3.Size = new System.Drawing.Size(207, 60);
            this.btnWord3.TabIndex = 4;
            this.btnWord3.Text = "Hoender";
            this.btnWord3.UseVisualStyleBackColor = true;
            this.btnWord3.Click += new System.EventHandler(this.word3_label_Click);
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
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(667, 29);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.playGameToolStripMenuItem.Text = "Start";
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
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(208, 25);
            this.backToolStripMenuItem.Text = "Choose A Different Game";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(50, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(252, 60);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(89, 20);
            this.lblTimeLeft.TabIndex = 12;
            this.lblTimeLeft.Text = "Time Left:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(340, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 20);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "10";
            // 
            // MatchingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WGame___Prototype_1.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 445);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnWord3);
            this.Controls.Add(this.btnWord2);
            this.Controls.Add(this.btnWord1);
            this.Controls.Add(this.img);
            this.Controls.Add(this.matchinggame_title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MatchingGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MatchingGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label matchinggame_title;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button btnWord1;
        private System.Windows.Forms.Button btnWord2;
        private System.Windows.Forms.Button btnWord3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblTime;
    }
}