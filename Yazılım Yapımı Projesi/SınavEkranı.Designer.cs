
namespace Yazılım_Yapımı_Projesi
{
    partial class SınavEkranı
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
            this.rtbSoruYükle = new System.Windows.Forms.RichTextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSoruYükle
            // 
            this.rtbSoruYükle.Location = new System.Drawing.Point(12, 3);
            this.rtbSoruYükle.Name = "rtbSoruYükle";
            this.rtbSoruYükle.Size = new System.Drawing.Size(1131, 566);
            this.rtbSoruYükle.TabIndex = 0;
            this.rtbSoruYükle.Text = "";
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(392, 575);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(81, 32);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "A Şıkkı";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(479, 575);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(75, 32);
            this.buttonB.TabIndex = 2;
            this.buttonB.Text = "B Şıkkı";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(560, 575);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 32);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "C Şıkkı";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(641, 575);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(75, 32);
            this.buttonD.TabIndex = 4;
            this.buttonD.Text = "D Şıkkı";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // SınavEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 619);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.rtbSoruYükle);
            this.Name = "SınavEkranı";
            this.Text = "SınavEkranı";
            this.Load += new System.EventHandler(this.SınavEkranı_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSoruYükle;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
    }
}