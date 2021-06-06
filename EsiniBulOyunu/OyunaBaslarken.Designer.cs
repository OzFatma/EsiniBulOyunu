
namespace EsiniBulOyunu
{
    partial class OyunaBaslarken
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
            this.gbSeviye = new System.Windows.Forms.GroupBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbKolay = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbZor = new System.Windows.Forms.RadioButton();
            this.gbSeviye.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSeviye
            // 
            this.gbSeviye.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gbSeviye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbSeviye.Controls.Add(this.panel1);
            this.gbSeviye.Controls.Add(this.btnCik);
            this.gbSeviye.Controls.Add(this.btnBaslat);
            this.gbSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSeviye.ForeColor = System.Drawing.Color.White;
            this.gbSeviye.Location = new System.Drawing.Point(11, 13);
            this.gbSeviye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSeviye.Name = "gbSeviye";
            this.gbSeviye.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSeviye.Size = new System.Drawing.Size(279, 366);
            this.gbSeviye.TabIndex = 0;
            this.gbSeviye.TabStop = false;
            this.gbSeviye.Text = "Seviye Belirle";
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.ForeColor = System.Drawing.Color.Black;
            this.btnBaslat.Location = new System.Drawing.Point(51, 252);
            this.btnBaslat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(167, 49);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "Oyunu Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnCik
            // 
            this.btnCik.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCik.ForeColor = System.Drawing.Color.Black;
            this.btnCik.Location = new System.Drawing.Point(51, 309);
            this.btnCik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(167, 49);
            this.btnCik.TabIndex = 4;
            this.btnCik.Text = "Oyundan Çık";
            this.btnCik.UseVisualStyleBackColor = false;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbZor);
            this.panel1.Controls.Add(this.rbOrta);
            this.panel1.Controls.Add(this.rbKolay);
            this.panel1.Location = new System.Drawing.Point(7, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 219);
            this.panel1.TabIndex = 5;
            // 
            // rbKolay
            // 
            this.rbKolay.Location = new System.Drawing.Point(42, 26);
            this.rbKolay.Name = "rbKolay";
            this.rbKolay.Size = new System.Drawing.Size(167, 39);
            this.rbKolay.TabIndex = 3;
            this.rbKolay.TabStop = true;
            this.rbKolay.Text = "Kolay [4x4]";
            this.rbKolay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbKolay.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.Location = new System.Drawing.Point(42, 85);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(167, 39);
            this.rbOrta.TabIndex = 4;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta [6x6]";
            this.rbOrta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbZor
            // 
            this.rbZor.Location = new System.Drawing.Point(42, 147);
            this.rbZor.Name = "rbZor";
            this.rbZor.Size = new System.Drawing.Size(167, 39);
            this.rbZor.TabIndex = 5;
            this.rbZor.TabStop = true;
            this.rbZor.Text = "Zor [8x8]";
            this.rbZor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbZor.UseVisualStyleBackColor = true;
            // 
            // OyunaBaslarken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(300, 386);
            this.Controls.Add(this.gbSeviye);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OyunaBaslarken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OyunaBaslarken";
            this.gbSeviye.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSeviye;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbZor;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKolay;
    }
}