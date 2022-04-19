namespace WindowsFormWebService
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
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.lbl_yil = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_yil = new System.Windows.Forms.TextBox();
            this.btn_gönder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tc.Location = new System.Drawing.Point(56, 40);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(39, 13);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "T.C. :";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.Location = new System.Drawing.Point(56, 84);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(41, 13);
            this.lbl_isim.TabIndex = 1;
            this.lbl_isim.Text = "İSİM :";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyisim.Location = new System.Drawing.Point(56, 127);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(66, 13);
            this.lbl_soyisim.TabIndex = 2;
            this.lbl_soyisim.Text = "SOYİSİM :";
            // 
            // lbl_yil
            // 
            this.lbl_yil.AutoSize = true;
            this.lbl_yil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yil.Location = new System.Drawing.Point(56, 170);
            this.lbl_yil.Name = "lbl_yil";
            this.lbl_yil.Size = new System.Drawing.Size(34, 13);
            this.lbl_yil.TabIndex = 3;
            this.lbl_yil.Text = "YIL :";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(165, 37);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(100, 20);
            this.txt_tc.TabIndex = 4;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(165, 81);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 20);
            this.txt_isim.TabIndex = 5;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(165, 124);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(100, 20);
            this.txt_soyisim.TabIndex = 6;
            // 
            // txt_yil
            // 
            this.txt_yil.Location = new System.Drawing.Point(165, 167);
            this.txt_yil.Name = "txt_yil";
            this.txt_yil.Size = new System.Drawing.Size(100, 20);
            this.txt_yil.TabIndex = 7;
            // 
            // btn_gönder
            // 
            this.btn_gönder.Location = new System.Drawing.Point(165, 222);
            this.btn_gönder.Name = "btn_gönder";
            this.btn_gönder.Size = new System.Drawing.Size(100, 23);
            this.btn_gönder.TabIndex = 8;
            this.btn_gönder.Text = "GÖNDER";
            this.btn_gönder.UseVisualStyleBackColor = true;
            this.btn_gönder.Click += new System.EventHandler(this.btn_gönder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(356, 304);
            this.Controls.Add(this.btn_gönder);
            this.Controls.Add(this.txt_yil);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.lbl_yil);
            this.Controls.Add(this.lbl_soyisim);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.lbl_tc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label lbl_yil;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_yil;
        private System.Windows.Forms.Button btn_gönder;
    }
}

