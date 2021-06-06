
namespace EsiniBulOyunu
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
            this.components = new System.ComponentModel.Container();
            this.pnlKartlar = new System.Windows.Forms.Panel();
            this.tmrSaniye = new System.Windows.Forms.Timer(this.components);
            this.lblDk = new System.Windows.Forms.Label();
            this.lblSn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrDakika = new System.Windows.Forms.Timer(this.components);
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmOyun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmYeniOyun = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKartlar
            // 
            this.pnlKartlar.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlKartlar.Location = new System.Drawing.Point(16, 37);
            this.pnlKartlar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlKartlar.Name = "pnlKartlar";
            this.pnlKartlar.Size = new System.Drawing.Size(754, 781);
            this.pnlKartlar.TabIndex = 0;
            // 
            // tmrSaniye
            // 
            this.tmrSaniye.Tick += new System.EventHandler(this.tmrSaniye_Tick);
            // 
            // lblDk
            // 
            this.lblDk.Location = new System.Drawing.Point(231, 8);
            this.lblDk.Name = "lblDk";
            this.lblDk.Size = new System.Drawing.Size(25, 25);
            this.lblDk.TabIndex = 1;
            this.lblDk.Text = "00";
            this.lblDk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSn
            // 
            this.lblSn.Location = new System.Drawing.Point(262, 8);
            this.lblSn.Name = "lblSn";
            this.lblSn.Size = new System.Drawing.Size(25, 25);
            this.lblSn.TabIndex = 2;
            this.lblSn.Text = "00";
            this.lblSn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Süre:";
            // 
            // tmrDakika
            // 
            this.tmrDakika.Tick += new System.EventHandler(this.tmrDakika_Tick);
            // 
            // msMenu
            // 
            this.msMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOyun,
            this.tsmKapat});
            this.msMenu.Location = new System.Drawing.Point(9, 9);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(144, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmOyun
            // 
            this.tsmOyun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmYeniOyun});
            this.tsmOyun.Name = "tsmOyun";
            this.tsmOyun.Size = new System.Drawing.Size(48, 20);
            this.tsmOyun.Text = "Oyun";
            // 
            // tsmYeniOyun
            // 
            this.tsmYeniOyun.Name = "tsmYeniOyun";
            this.tsmYeniOyun.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmYeniOyun.Size = new System.Drawing.Size(180, 22);
            this.tsmYeniOyun.Text = "Yeni Oyun";
            this.tsmYeniOyun.Click += new System.EventHandler(this.tsmYeniOyun_Click);
            // 
            // tsmKapat
            // 
            this.tsmKapat.Name = "tsmKapat";
            this.tsmKapat.Size = new System.Drawing.Size(88, 20);
            this.tsmKapat.Text = "Oyunu Kapat";
            this.tsmKapat.Click += new System.EventHandler(this.tsmKapat_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(251, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 849);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.pnlKartlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDk);
            this.Controls.Add(this.lblSn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eşini Bul Oyunu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlKartlar;
        private System.Windows.Forms.Timer tmrSaniye;
        private System.Windows.Forms.Label lblDk;
        private System.Windows.Forms.Label lblSn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrDakika;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmOyun;
        private System.Windows.Forms.ToolStripMenuItem tsmYeniOyun;
        private System.Windows.Forms.ToolStripMenuItem tsmKapat;
        private System.Windows.Forms.Label label2;
    }
}

