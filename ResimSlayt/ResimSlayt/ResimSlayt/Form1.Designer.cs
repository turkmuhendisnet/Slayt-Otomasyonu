namespace ResimSlayt
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStarStop = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.btnilk = new System.Windows.Forms.Button();
            this.btnİleri = new System.Windows.Forms.Button();
            this.btnSon = new System.Windows.Forms.Button();
            this.pctrBxResimler = new System.Windows.Forms.PictureBox();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxResimler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStarStop
            // 
            this.btnStarStop.BackColor = System.Drawing.Color.Aqua;
            this.btnStarStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStarStop.Location = new System.Drawing.Point(208, 361);
            this.btnStarStop.Name = "btnStarStop";
            this.btnStarStop.Size = new System.Drawing.Size(75, 34);
            this.btnStarStop.TabIndex = 1;
            this.btnStarStop.Text = "Star Stop";
            this.btnStarStop.UseVisualStyleBackColor = false;
            this.btnStarStop.Click += new System.EventHandler(this.btnStarStop_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGeri.Location = new System.Drawing.Point(114, 361);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(75, 34);
            this.BtnGeri.TabIndex = 2;
            this.BtnGeri.Text = "<<";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // btnilk
            // 
            this.btnilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnilk.Location = new System.Drawing.Point(12, 361);
            this.btnilk.Name = "btnilk";
            this.btnilk.Size = new System.Drawing.Size(75, 34);
            this.btnilk.TabIndex = 3;
            this.btnilk.Text = "I<";
            this.btnilk.UseVisualStyleBackColor = true;
            this.btnilk.Click += new System.EventHandler(this.btnilk_Click);
            // 
            // btnİleri
            // 
            this.btnİleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİleri.Location = new System.Drawing.Point(308, 361);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(75, 34);
            this.btnİleri.TabIndex = 4;
            this.btnİleri.Text = ">>";
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // btnSon
            // 
            this.btnSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSon.Location = new System.Drawing.Point(410, 361);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(75, 34);
            this.btnSon.TabIndex = 5;
            this.btnSon.Text = ">I";
            this.btnSon.UseVisualStyleBackColor = true;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // pctrBxResimler
            // 
            this.pctrBxResimler.Image = global::ResimSlayt.Properties.Resources.Resim11;
            this.pctrBxResimler.Location = new System.Drawing.Point(12, 12);
            this.pctrBxResimler.Name = "pctrBxResimler";
            this.pctrBxResimler.Size = new System.Drawing.Size(473, 343);
            this.pctrBxResimler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBxResimler.TabIndex = 0;
            this.pctrBxResimler.TabStop = false;
            // 
            // tmrSure
            // 
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 429);
            this.Controls.Add(this.btnSon);
            this.Controls.Add(this.btnİleri);
            this.Controls.Add(this.btnilk);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.btnStarStop);
            this.Controls.Add(this.pctrBxResimler);
            this.Name = "Form1";
            this.Text = "Slayt Gösterisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxResimler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrBxResimler;
        private System.Windows.Forms.Button btnStarStop;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button btnilk;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button btnSon;
        private System.Windows.Forms.Timer tmrSure;
    }
}

