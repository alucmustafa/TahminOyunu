namespace Tahmin_Oyunu
{
    partial class ResultScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.winnerText = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.vinnerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(189, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yeniden Oyna...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(707, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // winnerText
            // 
            this.winnerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.winnerText.ForeColor = System.Drawing.Color.White;
            this.winnerText.Location = new System.Drawing.Point(26, 142);
            this.winnerText.Name = "winnerText";
            this.winnerText.Size = new System.Drawing.Size(146, 61);
            this.winnerText.TabIndex = 4;
            this.winnerText.Text = "Kazanan :";
            this.winnerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number.ForeColor = System.Drawing.Color.White;
            this.number.Location = new System.Drawing.Point(462, 142);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(146, 61);
            this.number.TabIndex = 4;
            this.number.Text = "0";
            this.number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vinnerName
            // 
            this.vinnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vinnerName.ForeColor = System.Drawing.Color.White;
            this.vinnerName.Location = new System.Drawing.Point(204, 146);
            this.vinnerName.Name = "vinnerName";
            this.vinnerName.Size = new System.Drawing.Size(146, 61);
            this.vinnerName.TabIndex = 4;
            this.vinnerName.Text = "Kazanan";
            this.vinnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(465, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sayı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.number);
            this.Controls.Add(this.vinnerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winnerText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label winnerText;
        public System.Windows.Forms.Label number;
        public System.Windows.Forms.Label vinnerName;
        private System.Windows.Forms.Label label1;
    }
}