namespace SecondApp
{
    partial class FColor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.textbox = new System.Windows.Forms.TextBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(12, 12);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(66, 24);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Black";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(12, 42);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(70, 24);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "White";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(12, 72);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(61, 24);
            this.cb3.TabIndex = 2;
            this.cb3.Text = "Gray";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb3_CheckedChanged);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(12, 102);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(198, 27);
            this.textbox.TabIndex = 3;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(140, 12);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(57, 24);
            this.cb4.TabIndex = 4;
            this.cb4.Text = "Red";
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.CheckedChanged += new System.EventHandler(this.cb4_CheckedChanged);
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Location = new System.Drawing.Point(140, 42);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(70, 24);
            this.cb5.TabIndex = 5;
            this.cb5.Text = "Green";
            this.cb5.UseVisualStyleBackColor = true;
            this.cb5.CheckedChanged += new System.EventHandler(this.cb5_CheckedChanged);
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.Location = new System.Drawing.Point(140, 72);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(60, 24);
            this.cb6.TabIndex = 6;
            this.cb6.Text = "Blue";
            this.cb6.UseVisualStyleBackColor = true;
            this.cb6.CheckedChanged += new System.EventHandler(this.cb6_CheckedChanged);
            // 
            // FColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 138);
            this.Controls.Add(this.cb6);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Name = "FColor";
            this.Text = "FColor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb6;
    }
}

