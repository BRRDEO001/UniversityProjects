
namespace WGame___Prototype_1.PresentationLayer
{
    partial class GuessingGame
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
            this.Guessing_title = new System.Windows.Forms.Label();
            this.guessing_input_label = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.GuessGameSubmit_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblWord = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Guessing_title
            // 
            this.Guessing_title.AutoSize = true;
            this.Guessing_title.BackColor = System.Drawing.Color.Transparent;
            this.Guessing_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Guessing_title.Location = new System.Drawing.Point(84, 103);
            this.Guessing_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Guessing_title.Name = "Guessing_title";
            this.Guessing_title.Size = new System.Drawing.Size(428, 37);
            this.Guessing_title.TabIndex = 6;
            this.Guessing_title.Text = "What is this word in English?";
            // 
            // guessing_input_label
            // 
            this.guessing_input_label.AutoSize = true;
            this.guessing_input_label.BackColor = System.Drawing.Color.Transparent;
            this.guessing_input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.guessing_input_label.Location = new System.Drawing.Point(127, 295);
            this.guessing_input_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guessing_input_label.Name = "guessing_input_label";
            this.guessing_input_label.Size = new System.Drawing.Size(61, 24);
            this.guessing_input_label.TabIndex = 8;
            this.guessing_input_label.Text = "Word:";
            // 
            // txtInput
            // 
            this.txtInput.Enabled = false;
            this.txtInput.Location = new System.Drawing.Point(208, 298);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(233, 20);
            this.txtInput.TabIndex = 9;
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
            this.menuStrip1.Size = new System.Drawing.Size(600, 29);
            this.menuStrip1.TabIndex = 10;
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
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeLeft.Location = new System.Drawing.Point(486, 34);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(54, 13);
            this.lblTimeLeft.TabIndex = 11;
            this.lblTimeLeft.Text = "Time Left:";
            // 
            // GuessGameSubmit_button
            // 
            this.GuessGameSubmit_button.Location = new System.Drawing.Point(254, 323);
            this.GuessGameSubmit_button.Margin = new System.Windows.Forms.Padding(2);
            this.GuessGameSubmit_button.Name = "GuessGameSubmit_button";
            this.GuessGameSubmit_button.Size = new System.Drawing.Size(131, 37);
            this.GuessGameSubmit_button.TabIndex = 12;
            this.GuessGameSubmit_button.Text = "SUBMIT";
            this.GuessGameSubmit_button.UseVisualStyleBackColor = true;
            this.GuessGameSubmit_button.Click += new System.EventHandler(this.GuessGameSubmit_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.lblWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblWord.Location = new System.Drawing.Point(180, 162);
            this.lblWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(220, 73);
            this.lblWord.TabIndex = 7;
            this.lblWord.Text = "HOND";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(556, 34);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(19, 13);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "30";
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::WGame___Prototype_1.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.GuessGameSubmit_button);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.guessing_input_label);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.Guessing_title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GuessingGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GuessingGame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Guessing_title;
        private System.Windows.Forms.Label guessing_input_label;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Button GuessGameSubmit_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}