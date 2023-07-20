
using System;

namespace WGame___Prototype_1
{
    partial class MDIParent1
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Play_button = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Play_button
            // 
            this.Play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Play_button.Location = new System.Drawing.Point(256, 262);
            this.Play_button.Margin = new System.Windows.Forms.Padding(2);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(199, 68);
            this.Play_button.TabIndex = 4;
            this.Play_button.Text = "Play!";
            this.Play_button.UseVisualStyleBackColor = true;
            this.Play_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.welcome_label.Location = new System.Drawing.Point(28, 50);
            this.welcome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(622, 73);
            this.welcome_label.TabIndex = 5;
            this.welcome_label.Text = "Welcome to WGame";
            this.welcome_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(639, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "⚙️ Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::WGame___Prototype_1.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 453);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.Play_button);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "WGame";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button btnSettings;
    }
}



