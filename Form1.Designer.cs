namespace ABVCalc
{
    partial class Form1
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
            this.txtOGlbl = new System.Windows.Forms.Label();
            this.txtFGlbl = new System.Windows.Forms.Label();
            this.txtOG = new System.Windows.Forms.TextBox();
            this.txtFG = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOGlbl
            // 
            this.txtOGlbl.AutoSize = true;
            this.txtOGlbl.Location = new System.Drawing.Point(12, 9);
            this.txtOGlbl.Name = "txtOGlbl";
            this.txtOGlbl.Size = new System.Drawing.Size(120, 15);
            this.txtOGlbl.TabIndex = 0;
            this.txtOGlbl.Text = "Original Gravity (OG):";
            // 
            // txtFGlbl
            // 
            this.txtFGlbl.AutoSize = true;
            this.txtFGlbl.Location = new System.Drawing.Point(12, 52);
            this.txtFGlbl.Name = "txtFGlbl";
            this.txtFGlbl.Size = new System.Drawing.Size(100, 15);
            this.txtFGlbl.TabIndex = 1;
            this.txtFGlbl.Text = "Final Gravity (FG):";
            // 
            // txtOG
            // 
            this.txtOG.Location = new System.Drawing.Point(12, 26);
            this.txtOG.Name = "txtOG";
            this.txtOG.Size = new System.Drawing.Size(120, 23);
            this.txtOG.TabIndex = 2;
            // 
            // txtFG
            // 
            this.txtFG.Location = new System.Drawing.Point(12, 70);
            this.txtFG.Name = "txtFG";
            this.txtFG.Size = new System.Drawing.Size(120, 23);
            this.txtFG.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate ABV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(142, 130);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFG);
            this.Controls.Add(this.txtOG);
            this.Controls.Add(this.txtFGlbl);
            this.Controls.Add(this.txtOGlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABV Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtOGlbl;
        private Label txtFGlbl;
        private TextBox txtOG;
        private TextBox txtFG;
        private Button button1;
    }
}