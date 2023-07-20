
namespace WGame___Prototype_1.PresentationLayer
{
    partial class GameChoice
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
            this.Exercise_TItle = new System.Windows.Forms.Label();
            this.picword_label = new System.Windows.Forms.Button();
            this.guess_label = new System.Windows.Forms.Button();
            this.hangman_label = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exercise_TItle
            // 
            this.Exercise_TItle.AutoSize = true;
            this.Exercise_TItle.BackColor = System.Drawing.Color.Transparent;
            this.Exercise_TItle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Exercise_TItle.Location = new System.Drawing.Point(169, 48);
            this.Exercise_TItle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Exercise_TItle.Name = "Exercise_TItle";
            this.Exercise_TItle.Size = new System.Drawing.Size(232, 37);
            this.Exercise_TItle.TabIndex = 0;
            this.Exercise_TItle.Text = "Choose Game!";
            this.Exercise_TItle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // picword_label
            // 
            this.picword_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picword_label.FlatAppearance.BorderSize = 0;
            this.picword_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.picword_label.Location = new System.Drawing.Point(197, 100);
            this.picword_label.Margin = new System.Windows.Forms.Padding(2);
            this.picword_label.Name = "picword_label";
            this.picword_label.Size = new System.Drawing.Size(184, 69);
            this.picword_label.TabIndex = 1;
            this.picword_label.Text = "MATCHING";
            this.picword_label.UseVisualStyleBackColor = false;
            this.picword_label.Click += new System.EventHandler(this.button1_Click);
            // 
            // guess_label
            // 
            this.guess_label.FlatAppearance.BorderSize = 0;
            this.guess_label.Location = new System.Drawing.Point(197, 187);
            this.guess_label.Margin = new System.Windows.Forms.Padding(2);
            this.guess_label.Name = "guess_label";
            this.guess_label.Size = new System.Drawing.Size(184, 69);
            this.guess_label.TabIndex = 2;
            this.guess_label.Text = "GUESSING";
            this.guess_label.UseVisualStyleBackColor = true;
            this.guess_label.Click += new System.EventHandler(this.guess_label_Click);
            // 
            // hangman_label
            // 
            this.hangman_label.FlatAppearance.BorderSize = 0;
            this.hangman_label.Location = new System.Drawing.Point(197, 276);
            this.hangman_label.Margin = new System.Windows.Forms.Padding(2);
            this.hangman_label.Name = "hangman_label";
            this.hangman_label.Size = new System.Drawing.Size(184, 69);
            this.hangman_label.TabIndex = 3;
            this.hangman_label.Text = "HANGMAN";
            this.hangman_label.UseVisualStyleBackColor = true;
            this.hangman_label.Click += new System.EventHandler(this.hangman_label_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(600, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.playGameToolStripMenuItem.Text = "Home";
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
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.resetToolStripMenuItem.Text = "Back";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(50, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // GameChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WGame___Prototype_1.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.hangman_label);
            this.Controls.Add(this.guess_label);
            this.Controls.Add(this.picword_label);
            this.Controls.Add(this.Exercise_TItle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameChoice";
            this.Text = "Select Game";
            this.Load += new System.EventHandler(this.GameChoice_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exercise_TItle;
        private System.Windows.Forms.Button picword_label;
        private System.Windows.Forms.Button guess_label;
        private System.Windows.Forms.Button hangman_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}