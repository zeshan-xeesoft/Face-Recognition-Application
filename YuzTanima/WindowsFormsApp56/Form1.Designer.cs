namespace WindowsFormsApp56
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEgit = new System.Windows.Forms.Button();
            this.lblEgitilenAdet = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtFaceName = new System.Windows.Forms.TextBox();
            this.btnEgitimSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(922, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEgit
            // 
            this.btnEgit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEgit.Location = new System.Drawing.Point(957, 100);
            this.btnEgit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEgit.Name = "btnEgit";
            this.btnEgit.Size = new System.Drawing.Size(136, 64);
            this.btnEgit.TabIndex = 1;
            this.btnEgit.Text = "Algılanan Yüzü Kaydet (10 Adet)";
            this.btnEgit.UseVisualStyleBackColor = false;
            this.btnEgit.Click += new System.EventHandler(this.btnEgit_Click);
            // 
            // lblEgitilenAdet
            // 
            this.lblEgitilenAdet.AutoSize = true;
            this.lblEgitilenAdet.Location = new System.Drawing.Point(947, 175);
            this.lblEgitilenAdet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEgitilenAdet.Name = "lblEgitilenAdet";
            this.lblEgitilenAdet.Size = new System.Drawing.Size(37, 17);
            this.lblEgitilenAdet.TabIndex = 2;
            this.lblEgitilenAdet.Text = "Adet";
            this.lblEgitilenAdet.Click += new System.EventHandler(this.lblEgitilenAdet_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(957, 199);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txtFaceName
            // 
            this.txtFaceName.Location = new System.Drawing.Point(958, 60);
            this.txtFaceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFaceName.Name = "txtFaceName";
            this.txtFaceName.Size = new System.Drawing.Size(135, 22);
            this.txtFaceName.TabIndex = 4;
            // 
            // btnEgitimSil
            // 
            this.btnEgitimSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEgitimSil.Location = new System.Drawing.Point(957, 366);
            this.btnEgitimSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnEgitimSil.Name = "btnEgitimSil";
            this.btnEgitimSil.Size = new System.Drawing.Size(136, 64);
            this.btnEgitimSil.TabIndex = 5;
            this.btnEgitimSil.Text = "Tüm Eğitimleri Sil";
            this.btnEgitimSil.UseVisualStyleBackColor = false;
            this.btnEgitimSil.Click += new System.EventHandler(this.btnEgitimSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(959, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kaydedilecek İsim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1109, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEgitimSil);
            this.Controls.Add(this.txtFaceName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblEgitilenAdet);
            this.Controls.Add(this.btnEgit);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEgit;
        private System.Windows.Forms.Label lblEgitilenAdet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtFaceName;
        private System.Windows.Forms.Button btnEgitimSil;
        private System.Windows.Forms.Label label1;
    }
}

