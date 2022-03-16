namespace Ezan_Vakti
{
    partial class EzanVakti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EzanVakti));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelImsak = new System.Windows.Forms.Label();
            this.labelGunes = new System.Windows.Forms.Label();
            this.labelOgle = new System.Windows.Forms.Label();
            this.labelIkindi = new System.Windows.Forms.Label();
            this.labelAksam = new System.Windows.Forms.Label();
            this.labelYatsi = new System.Windows.Forms.Label();
            this.Baslatici = new System.Windows.Forms.Timer(this.components);
            this.labelSehir = new System.Windows.Forms.Label();
            this.linkSehirDegistir = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İmsak:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Güneş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "İkindi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Akşam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yatsı:";
            // 
            // labelImsak
            // 
            this.labelImsak.AutoSize = true;
            this.labelImsak.Location = new System.Drawing.Point(117, 47);
            this.labelImsak.Name = "labelImsak";
            this.labelImsak.Size = new System.Drawing.Size(58, 24);
            this.labelImsak.TabIndex = 6;
            this.labelImsak.Text = "İmsak";
            // 
            // labelGunes
            // 
            this.labelGunes.AutoSize = true;
            this.labelGunes.Location = new System.Drawing.Point(117, 71);
            this.labelGunes.Name = "labelGunes";
            this.labelGunes.Size = new System.Drawing.Size(64, 24);
            this.labelGunes.TabIndex = 7;
            this.labelGunes.Text = "Güneş";
            // 
            // labelOgle
            // 
            this.labelOgle.AutoSize = true;
            this.labelOgle.Location = new System.Drawing.Point(117, 95);
            this.labelOgle.Name = "labelOgle";
            this.labelOgle.Size = new System.Drawing.Size(50, 24);
            this.labelOgle.TabIndex = 8;
            this.labelOgle.Text = "Öğle";
            // 
            // labelIkindi
            // 
            this.labelIkindi.AutoSize = true;
            this.labelIkindi.Location = new System.Drawing.Point(117, 119);
            this.labelIkindi.Name = "labelIkindi";
            this.labelIkindi.Size = new System.Drawing.Size(52, 24);
            this.labelIkindi.TabIndex = 9;
            this.labelIkindi.Text = "İkindi";
            // 
            // labelAksam
            // 
            this.labelAksam.AutoSize = true;
            this.labelAksam.Location = new System.Drawing.Point(117, 143);
            this.labelAksam.Name = "labelAksam";
            this.labelAksam.Size = new System.Drawing.Size(68, 24);
            this.labelAksam.TabIndex = 10;
            this.labelAksam.Text = "Akşam";
            // 
            // labelYatsi
            // 
            this.labelYatsi.AutoSize = true;
            this.labelYatsi.Location = new System.Drawing.Point(117, 167);
            this.labelYatsi.Name = "labelYatsi";
            this.labelYatsi.Size = new System.Drawing.Size(53, 24);
            this.labelYatsi.TabIndex = 11;
            this.labelYatsi.Text = "Yatsı";
            // 
            // Baslatici
            // 
            this.Baslatici.Interval = 1;
            this.Baslatici.Tick += new System.EventHandler(this.Baslatici_Tick);
            // 
            // labelSehir
            // 
            this.labelSehir.Font = new System.Drawing.Font("Outfit Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSehir.Location = new System.Drawing.Point(0, 9);
            this.labelSehir.Name = "labelSehir";
            this.labelSehir.Size = new System.Drawing.Size(229, 24);
            this.labelSehir.TabIndex = 12;
            this.labelSehir.Text = "-----";
            this.labelSehir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkSehirDegistir
            // 
            this.linkSehirDegistir.AutoSize = true;
            this.linkSehirDegistir.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.linkSehirDegistir.Location = new System.Drawing.Point(99, 200);
            this.linkSehirDegistir.Name = "linkSehirDegistir";
            this.linkSehirDegistir.Size = new System.Drawing.Size(132, 12);
            this.linkSehirDegistir.TabIndex = 13;
            this.linkSehirDegistir.TabStop = true;
            this.linkSehirDegistir.Text = "Şehir değiştirmek için tıklayın.\r\n";
            this.linkSehirDegistir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSehirDegistir_LinkClicked);
            // 
            // EzanVakti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 214);
            this.Controls.Add(this.linkSehirDegistir);
            this.Controls.Add(this.labelSehir);
            this.Controls.Add(this.labelYatsi);
            this.Controls.Add(this.labelAksam);
            this.Controls.Add(this.labelIkindi);
            this.Controls.Add(this.labelOgle);
            this.Controls.Add(this.labelGunes);
            this.Controls.Add(this.labelImsak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Outfit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "EzanVakti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ezan Vakti";
            this.Load += new System.EventHandler(this.EzanVakti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelImsak;
        private System.Windows.Forms.Label labelGunes;
        private System.Windows.Forms.Label labelOgle;
        private System.Windows.Forms.Label labelIkindi;
        private System.Windows.Forms.Label labelAksam;
        private System.Windows.Forms.Label labelYatsi;
        private System.Windows.Forms.Timer Baslatici;
        private System.Windows.Forms.Label labelSehir;
        private System.Windows.Forms.LinkLabel linkSehirDegistir;
    }
}

