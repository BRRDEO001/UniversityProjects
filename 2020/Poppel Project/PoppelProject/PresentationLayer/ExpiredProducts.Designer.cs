
namespace PoppelProject
{
    partial class ExpiredProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpiredProducts));
            this.button2 = new System.Windows.Forms.Button();
            this.expiredproductList = new System.Windows.Forms.RichTextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // expiredproductList
            // 
            this.expiredproductList.Location = new System.Drawing.Point(85, 220);
            this.expiredproductList.Name = "expiredproductList";
            this.expiredproductList.Size = new System.Drawing.Size(396, 320);
            this.expiredproductList.TabIndex = 31;
            this.expiredproductList.Text = "BatchNumber      Product Code    Expiry Date";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(303, 176);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(144, 23);
            this.btnList.TabIndex = 29;
            this.btnList.Text = "List Expired products";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palace Script MT", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(100, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 74);
            this.label5.TabIndex = 28;
            this.label5.Text = "Expired Products";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palace Script MT", 90F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(157, -7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 111);
            this.label4.TabIndex = 27;
            this.label4.Text = "Poppel";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(97, 179);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 20);
            this.txtDate.TabIndex = 33;
            // 
            // ExpiredProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 613);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.expiredproductList);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "ExpiredProducts";
            this.Text = "ExpiredProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox expiredproductList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDate;
    }
}