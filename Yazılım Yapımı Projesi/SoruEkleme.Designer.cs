
namespace Yazılım_Yapımı_Projesi
{
    partial class SoruEkleme
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
            this.rtbSoruEkle = new System.Windows.Forms.RichTextBox();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBölüm = new System.Windows.Forms.TextBox();
            this.cbRightAns = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSoruEkle = new System.Windows.Forms.Button();
            this.buttonFont = new System.Windows.Forms.Button();
            this.buttonRenk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // rtbSoruEkle
            // 
            this.rtbSoruEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSoruEkle.EnableAutoDragDrop = true;
            this.rtbSoruEkle.Location = new System.Drawing.Point(12, 12);
            this.rtbSoruEkle.Name = "rtbSoruEkle";
            this.rtbSoruEkle.Size = new System.Drawing.Size(712, 577);
            this.rtbSoruEkle.TabIndex = 0;
            this.rtbSoruEkle.Text = "";
            // 
            // tbUnit
            // 
            this.tbUnit.Location = new System.Drawing.Point(805, 16);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(107, 20);
            this.tbUnit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(758, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ünite =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(748, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bölüm =";
            // 
            // tbBölüm
            // 
            this.tbBölüm.Location = new System.Drawing.Point(805, 42);
            this.tbBölüm.Name = "tbBölüm";
            this.tbBölüm.Size = new System.Drawing.Size(107, 20);
            this.tbBölüm.TabIndex = 4;
            // 
            // cbRightAns
            // 
            this.cbRightAns.FormattingEnabled = true;
            this.cbRightAns.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbRightAns.Location = new System.Drawing.Point(805, 68);
            this.cbRightAns.Name = "cbRightAns";
            this.cbRightAns.Size = new System.Drawing.Size(107, 21);
            this.cbRightAns.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(736, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doğru Şık =";
            // 
            // buttonSoruEkle
            // 
            this.buttonSoruEkle.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSoruEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSoruEkle.Location = new System.Drawing.Point(761, 185);
            this.buttonSoruEkle.Name = "buttonSoruEkle";
            this.buttonSoruEkle.Size = new System.Drawing.Size(143, 46);
            this.buttonSoruEkle.TabIndex = 7;
            this.buttonSoruEkle.Text = "Soruyu Kaydet";
            this.buttonSoruEkle.UseVisualStyleBackColor = false;
            this.buttonSoruEkle.Click += new System.EventHandler(this.buttonSoruEkle_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(730, 115);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(98, 37);
            this.buttonFont.TabIndex = 8;
            this.buttonFont.Text = "Font";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // buttonRenk
            // 
            this.buttonRenk.Location = new System.Drawing.Point(836, 115);
            this.buttonRenk.Name = "buttonRenk";
            this.buttonRenk.Size = new System.Drawing.Size(98, 37);
            this.buttonRenk.TabIndex = 9;
            this.buttonRenk.Text = "Renk";
            this.buttonRenk.UseVisualStyleBackColor = true;
            this.buttonRenk.Click += new System.EventHandler(this.buttonRenk_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // SoruEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(946, 601);
            this.Controls.Add(this.buttonRenk);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.buttonSoruEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRightAns);
            this.Controls.Add(this.tbBölüm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.rtbSoruEkle);
            this.Name = "SoruEkleme";
            this.Text = "SoruEkleme";
            this.Load += new System.EventHandler(this.SoruEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSoruEkle;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBölüm;
        private System.Windows.Forms.ComboBox cbRightAns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSoruEkle;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.Button buttonRenk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}