namespace WatchDocks
{
    partial class TempWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempWindow));
            this.bt1 = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Black;
            this.bt1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt1.BackgroundImage")));
            this.bt1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bt1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt1.ForeColor = System.Drawing.Color.White;
            this.bt1.Location = new System.Drawing.Point(103, 101);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(155, 26);
            this.bt1.TabIndex = 59;
            this.bt1.Text = "OK";
            this.bt1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt1.UseCustomBackColor = true;
            this.bt1.UseCustomForeColor = true;
            this.bt1.UseSelectable = true;
            this.bt1.UseStyleColors = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 18);
            this.label2.TabIndex = 61;
            this.label2.Text = "Beta Version Does not  support this function";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(79, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 60;
            this.label1.Text = "Not Available";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TempWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 150);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 150);
            this.MinimumSize = new System.Drawing.Size(360, 150);
            this.Name = "TempWindow";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.TempWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton bt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}