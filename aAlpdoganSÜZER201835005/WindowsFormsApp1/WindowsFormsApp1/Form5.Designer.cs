namespace WindowsFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.lstGoster = new System.Windows.Forms.ListBox();
            this.texteleman = new System.Windows.Forms.TextBox();
            this.textAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSırala = new System.Windows.Forms.Button();
            this.btnTersCevir = new System.Windows.Forms.Button();
            this.btnKapasiteGoster = new System.Windows.Forms.Button();
            this.btnUzunlukGoster = new System.Windows.Forms.Button();
            this.btnElemanSil = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGoster
            // 
            this.lstGoster.FormattingEnabled = true;
            this.lstGoster.Location = new System.Drawing.Point(26, 120);
            this.lstGoster.Name = "lstGoster";
            this.lstGoster.Size = new System.Drawing.Size(131, 173);
            this.lstGoster.TabIndex = 0;
            this.lstGoster.SelectedIndexChanged += new System.EventHandler(this.lstGoster_SelectedIndexChanged);
            // 
            // texteleman
            // 
            this.texteleman.Location = new System.Drawing.Point(26, 68);
            this.texteleman.Name = "texteleman";
            this.texteleman.Size = new System.Drawing.Size(131, 20);
            this.texteleman.TabIndex = 1;
            // 
            // textAra
            // 
            this.textAra.Location = new System.Drawing.Point(26, 338);
            this.textAra.Name = "textAra";
            this.textAra.Size = new System.Drawing.Size(120, 20);
            this.textAra.TabIndex = 2;
            this.textAra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the product code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search:";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(182, 68);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(140, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Add";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoster.Location = new System.Drawing.Point(163, 120);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(86, 36);
            this.btnGoster.TabIndex = 6;
            this.btnGoster.Text = "Show";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(263, 120);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(91, 36);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Clean";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSırala
            // 
            this.btnSırala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSırala.Location = new System.Drawing.Point(163, 162);
            this.btnSırala.Name = "btnSırala";
            this.btnSırala.Size = new System.Drawing.Size(86, 38);
            this.btnSırala.TabIndex = 8;
            this.btnSırala.Text = "Sorting";
            this.btnSırala.UseVisualStyleBackColor = true;
            this.btnSırala.Click += new System.EventHandler(this.btnSırala_Click);
            // 
            // btnTersCevir
            // 
            this.btnTersCevir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTersCevir.Location = new System.Drawing.Point(263, 162);
            this.btnTersCevir.Name = "btnTersCevir";
            this.btnTersCevir.Size = new System.Drawing.Size(91, 38);
            this.btnTersCevir.TabIndex = 9;
            this.btnTersCevir.Text = "Reverse";
            this.btnTersCevir.UseVisualStyleBackColor = true;
            this.btnTersCevir.Click += new System.EventHandler(this.btnTersCevir_Click);
            // 
            // btnKapasiteGoster
            // 
            this.btnKapasiteGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapasiteGoster.Location = new System.Drawing.Point(193, 223);
            this.btnKapasiteGoster.Name = "btnKapasiteGoster";
            this.btnKapasiteGoster.Size = new System.Drawing.Size(129, 23);
            this.btnKapasiteGoster.TabIndex = 10;
            this.btnKapasiteGoster.Text = "Inventory capacity";
            this.btnKapasiteGoster.UseVisualStyleBackColor = true;
            this.btnKapasiteGoster.Click += new System.EventHandler(this.btnKapasiteGoster_Click);
            // 
            // btnUzunlukGoster
            // 
            this.btnUzunlukGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUzunlukGoster.Location = new System.Drawing.Point(193, 252);
            this.btnUzunlukGoster.Name = "btnUzunlukGoster";
            this.btnUzunlukGoster.Size = new System.Drawing.Size(129, 23);
            this.btnUzunlukGoster.TabIndex = 11;
            this.btnUzunlukGoster.Text = "Show the lenght";
            this.btnUzunlukGoster.UseVisualStyleBackColor = true;
            this.btnUzunlukGoster.Click += new System.EventHandler(this.btnUzunlukGoster_Click);
            // 
            // btnElemanSil
            // 
            this.btnElemanSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElemanSil.Location = new System.Drawing.Point(193, 281);
            this.btnElemanSil.Name = "btnElemanSil";
            this.btnElemanSil.Size = new System.Drawing.Size(129, 23);
            this.btnElemanSil.TabIndex = 12;
            this.btnElemanSil.Text = "Delete/Cansel";
            this.btnElemanSil.UseVisualStyleBackColor = true;
            this.btnElemanSil.Click += new System.EventHandler(this.btnElemanSil_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(26, 374);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 33);
            this.button9.TabIndex = 13;
            this.button9.Text = "Back";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(246, 374);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 33);
            this.button10.TabIndex = 14;
            this.button10.Text = "Close";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnBul
            // 
            this.btnBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBul.Location = new System.Drawing.Point(193, 312);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(129, 23);
            this.btnBul.TabIndex = 15;
            this.btnBul.Text = "Find";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // Form5
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 429);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnElemanSil);
            this.Controls.Add(this.btnUzunlukGoster);
            this.Controls.Add(this.btnKapasiteGoster);
            this.Controls.Add(this.btnTersCevir);
            this.Controls.Add(this.btnSırala);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAra);
            this.Controls.Add(this.texteleman);
            this.Controls.Add(this.lstGoster);
            this.Name = "Form5";
            this.Text = "FastInvantorySystemCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGoster;
        private System.Windows.Forms.TextBox texteleman;
        private System.Windows.Forms.TextBox textAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSırala;
        private System.Windows.Forms.Button btnTersCevir;
        private System.Windows.Forms.Button btnKapasiteGoster;
        private System.Windows.Forms.Button btnUzunlukGoster;
        private System.Windows.Forms.Button btnElemanSil;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnBul;
    }
}