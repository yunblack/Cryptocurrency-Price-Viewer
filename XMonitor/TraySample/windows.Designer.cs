namespace Planet
{
    partial class windows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windows));
            this.bt1 = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Black;
            this.bt1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt1.BackgroundImage")));
            this.bt1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bt1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt1.ForeColor = System.Drawing.Color.White;
            this.bt1.Location = new System.Drawing.Point(100, 89);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(155, 26);
            this.bt1.TabIndex = 57;
            this.bt1.Text = "OK";
            this.bt1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt1.UseCustomBackColor = true;
            this.bt1.UseCustomForeColor = true;
            this.bt1.UseSelectable = true;
            this.bt1.UseStyleColors = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(52, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 37);
            this.label3.TabIndex = 61;
            this.label3.Text = "Save Completed";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 150);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 150);
            this.Name = "windows";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.windows_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton bt1;
        private System.Windows.Forms.Label label3;
    }
}