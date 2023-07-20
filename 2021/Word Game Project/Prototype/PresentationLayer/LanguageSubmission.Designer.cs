
namespace WGame___Prototype_1.PresentationLayer
{
    partial class LanguageSubmission
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
            this.Language_submission_Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Language_Submission_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Language_submission_Title
            // 
            this.Language_submission_Title.AutoSize = true;
            this.Language_submission_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Language_submission_Title.Location = new System.Drawing.Point(58, 33);
            this.Language_submission_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Language_submission_Title.Name = "Language_submission_Title";
            this.Language_submission_Title.Size = new System.Drawing.Size(492, 29);
            this.Language_submission_Title.TabIndex = 0;
            this.Language_submission_Title.Text = "Please submit language not found in options:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Language_Submission_button
            // 
            this.Language_Submission_button.Location = new System.Drawing.Point(216, 146);
            this.Language_Submission_button.Margin = new System.Windows.Forms.Padding(2);
            this.Language_Submission_button.Name = "Language_Submission_button";
            this.Language_Submission_button.Size = new System.Drawing.Size(116, 39);
            this.Language_Submission_button.TabIndex = 2;
            this.Language_Submission_button.Text = "SUBMIT";
            this.Language_Submission_button.UseVisualStyleBackColor = true;
            this.Language_Submission_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // LanguageSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WGame___Prototype_1.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Language_Submission_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Language_submission_Title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LanguageSubmission";
            this.Text = "WGame";
            this.Load += new System.EventHandler(this.LanguageSubmission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Language_submission_Title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Language_Submission_button;
    }
}