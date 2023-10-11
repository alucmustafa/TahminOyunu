namespace Tahmin_Oyunu
{
    partial class StartScreen
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
            this.LogoImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoImg
            // 
            this.LogoImg.Image = global::Tahmin_Oyunu.Properties.Resources.MGames;
            this.LogoImg.Location = new System.Drawing.Point(219, 129);
            this.LogoImg.Name = "LogoImg";
            this.LogoImg.Size = new System.Drawing.Size(353, 193);
            this.LogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoImg.TabIndex = 0;
            this.LogoImg.TabStop = false;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreen";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoImg;
    }
}