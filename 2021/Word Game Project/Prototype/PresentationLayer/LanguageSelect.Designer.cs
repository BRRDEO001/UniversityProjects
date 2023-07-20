
namespace WGame___Prototype_1.PresentationLayer
{
    partial class LanguageSelect
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
            this.language_selection_title = new System.Windows.Forms.Label();
            this.cboLang = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblOther = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // language_selection_title
            // 
            this.language_selection_title.AutoSize = true;
            this.language_selection_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.language_selection_title.Location = new System.Drawing.Point(56, 34);
            this.language_selection_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.language_selection_title.Name = "language_selection_title";
            this.language_selection_title.Size = new System.Drawing.Size(514, 37);
            this.language_selection_title.TabIndex = 0;
            this.language_selection_title.Text = "Please select your home language:";
            this.language_selection_title.Click += new System.EventHandler(this.language_selection_title_Click);
            // 
            // cboLang
            // 
            this.cboLang.FormattingEnabled = true;
            this.cboLang.Items.AddRange(new object[] {
            "English",
            "Afrikaans"});
            this.cboLang.Location = new System.Drawing.Point(215, 137);
            this.cboLang.Name = "cboLang";
            this.cboLang.Size = new System.Drawing.Size(121, 21);
            this.cboLang.TabIndex = 1;
            this.cboLang.Text = "Select Language";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(513, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(421, 331);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(23, 331);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(169, 13);
            this.lblOther.TabIndex = 4;
            this.lblOther.Text = "Language Not On List? Click Here";
            this.lblOther.Click += new System.EventHandler(this.lblOther_Click);
            // 
            // LanguageSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WGame___Prototype_1.Properties.Resources.blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboLang);
            this.Controls.Add(this.language_selection_title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LanguageSelect";
            this.Text = "WGame";
            this.Load += new System.EventHandler(this.LanguageSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label language_selection_title;
        private System.Windows.Forms.ComboBox cboLang;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblOther;
    }
}