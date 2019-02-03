namespace VistaGlassButtonDemo
{
    partial class Form1
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
            this.glassButton1 = new SpinnyFlashyShinyControls.GlassButton();
            this.glassButton2 = new SpinnyFlashyShinyControls.GlassButton();
            this.glassButton3 = new SpinnyFlashyShinyControls.GlassButton();
            this.SuspendLayout();
            // 
            // glassButton1
            // 
            this.glassButton1.BackColor = System.Drawing.Color.Red;
            this.glassButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.glassButton1.FontAntiAlias = true;
            this.glassButton1.ForeColor = System.Drawing.Color.White;
            this.glassButton1.Location = new System.Drawing.Point(13, 13);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.RoundedCornerRadius = 6;
            this.glassButton1.Size = new System.Drawing.Size(100, 32);
            this.glassButton1.TabIndex = 0;
            this.glassButton1.Text = "Red Glass";
            this.glassButton1.UseVisualStyleBackColor = false;
            // 
            // glassButton2
            // 
            this.glassButton2.BackColor = System.Drawing.Color.Olive;
            this.glassButton2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.glassButton2.FontAntiAlias = true;
            this.glassButton2.ForeColor = System.Drawing.Color.White;
            this.glassButton2.Location = new System.Drawing.Point(120, 13);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.RoundedCornerRadius = 6;
            this.glassButton2.Size = new System.Drawing.Size(100, 32);
            this.glassButton2.TabIndex = 1;
            this.glassButton2.Text = "Green Glass";
            this.glassButton2.UseVisualStyleBackColor = false;
            // 
            // glassButton3
            // 
            this.glassButton3.BackColor = System.Drawing.Color.Blue;
            this.glassButton3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.glassButton3.FontAntiAlias = true;
            this.glassButton3.ForeColor = System.Drawing.Color.White;
            this.glassButton3.Location = new System.Drawing.Point(227, 13);
            this.glassButton3.Name = "glassButton3";
            this.glassButton3.RoundedCornerRadius = 6;
            this.glassButton3.Size = new System.Drawing.Size(100, 32);
            this.glassButton3.TabIndex = 2;
            this.glassButton3.Text = "Blue Glass";
            this.glassButton3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 91);
            this.Controls.Add(this.glassButton3);
            this.Controls.Add(this.glassButton2);
            this.Controls.Add(this.glassButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SpinnyFlashyShinyControls.GlassButton glassButton1;
        private SpinnyFlashyShinyControls.GlassButton glassButton2;
        private SpinnyFlashyShinyControls.GlassButton glassButton3;
    }
}

