namespace tckimliknoDogrulama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdogumyil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttckimlikno = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdogumyil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsoyisim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttckimlikno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtisim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKontrolEt);
            this.groupBox2.Location = new System.Drawing.Point(227, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem";
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Location = new System.Drawing.Point(6, 29);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(156, 23);
            this.btnKontrolEt.TabIndex = 2;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(6, 100);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(188, 20);
            this.txtisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(6, 149);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(188, 20);
            this.txtsoyisim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doğum Yıl";
            // 
            // txtdogumyil
            // 
            this.txtdogumyil.Location = new System.Drawing.Point(6, 196);
            this.txtdogumyil.Name = "txtdogumyil";
            this.txtdogumyil.Size = new System.Drawing.Size(188, 20);
            this.txtdogumyil.TabIndex = 1;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "T.C. Kimlik No";
            // 
            // txttckimlikno
            // 
            this.txttckimlikno.Location = new System.Drawing.Point(6, 43);
            this.txttckimlikno.Name = "txttckimlikno";
            this.txttckimlikno.Size = new System.Drawing.Size(188, 20);
            this.txttckimlikno.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 260);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T.C. Kimlik No Doğrulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.TextBox txtdogumyil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttckimlikno;
        private System.Windows.Forms.Label label4;
    }
}

