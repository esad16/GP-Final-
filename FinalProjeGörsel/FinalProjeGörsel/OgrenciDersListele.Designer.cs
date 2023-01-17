namespace FinalProjeGörsel
{
    partial class OgrenciDersListele
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
            this.dataGridViewDers = new System.Windows.Forms.DataGridView();
            this.Ara_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbfiltre = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsırala = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbdeğer = new System.Windows.Forms.ComboBox();
            this.Yenile_btn = new System.Windows.Forms.Button();
            this.cmbşekil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDers
            // 
            this.dataGridViewDers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDers.Location = new System.Drawing.Point(12, 120);
            this.dataGridViewDers.Name = "dataGridViewDers";
            this.dataGridViewDers.Size = new System.Drawing.Size(984, 339);
            this.dataGridViewDers.TabIndex = 63;
            this.dataGridViewDers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDers_CellDoubleClick);
            // 
            // Ara_txt
            // 
            this.Ara_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ara_txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ara_txt.Location = new System.Drawing.Point(6, 63);
            this.Ara_txt.Multiline = true;
            this.Ara_txt.Name = "Ara_txt";
            this.Ara_txt.Size = new System.Drawing.Size(240, 33);
            this.Ara_txt.TabIndex = 40;
            this.Ara_txt.TextChanged += new System.EventHandler(this.Ara_txt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbfiltre);
            this.groupBox1.Controls.Add(this.Ara_txt);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 102);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgi Ara";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(252, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 30);
            this.label3.TabIndex = 59;
            this.label3.Text = "Filtreleme";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 30);
            this.label2.TabIndex = 58;
            this.label2.Text = "Aranacak Kelime";
            // 
            // cmbfiltre
            // 
            this.cmbfiltre.FormattingEnabled = true;
            this.cmbfiltre.Location = new System.Drawing.Point(252, 63);
            this.cmbfiltre.Name = "cmbfiltre";
            this.cmbfiltre.Size = new System.Drawing.Size(145, 32);
            this.cmbfiltre.TabIndex = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsırala);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbdeğer);
            this.groupBox2.Controls.Add(this.Yenile_btn);
            this.groupBox2.Controls.Add(this.cmbşekil);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(429, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 102);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnsırala
            // 
            this.btnsırala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsırala.BackColor = System.Drawing.Color.Aqua;
            this.btnsırala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsırala.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsırala.ForeColor = System.Drawing.Color.Black;
            this.btnsırala.Location = new System.Drawing.Point(416, 24);
            this.btnsırala.Name = "btnsırala";
            this.btnsırala.Size = new System.Drawing.Size(145, 33);
            this.btnsırala.TabIndex = 59;
            this.btnsırala.Text = "Sırala";
            this.btnsırala.UseVisualStyleBackColor = false;
            this.btnsırala.Click += new System.EventHandler(this.btnsırala_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(227, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "Sıralama Şekli";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 30);
            this.label4.TabIndex = 57;
            this.label4.Text = "Sıralanacak Değer";
            // 
            // cmbdeğer
            // 
            this.cmbdeğer.FormattingEnabled = true;
            this.cmbdeğer.Location = new System.Drawing.Point(6, 64);
            this.cmbdeğer.Name = "cmbdeğer";
            this.cmbdeğer.Size = new System.Drawing.Size(219, 32);
            this.cmbdeğer.TabIndex = 54;
            // 
            // Yenile_btn
            // 
            this.Yenile_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Yenile_btn.BackColor = System.Drawing.Color.Aqua;
            this.Yenile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Yenile_btn.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile_btn.ForeColor = System.Drawing.Color.Black;
            this.Yenile_btn.Location = new System.Drawing.Point(416, 63);
            this.Yenile_btn.Name = "Yenile_btn";
            this.Yenile_btn.Size = new System.Drawing.Size(145, 33);
            this.Yenile_btn.TabIndex = 56;
            this.Yenile_btn.Text = "Yenile";
            this.Yenile_btn.UseVisualStyleBackColor = false;
            this.Yenile_btn.Click += new System.EventHandler(this.Yenile_btn_Click);
            // 
            // cmbşekil
            // 
            this.cmbşekil.FormattingEnabled = true;
            this.cmbşekil.Location = new System.Drawing.Point(231, 63);
            this.cmbşekil.Name = "cmbşekil";
            this.cmbşekil.Size = new System.Drawing.Size(179, 32);
            this.cmbşekil.TabIndex = 55;
            // 
            // OgrenciDersListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1009, 478);
            this.Controls.Add(this.dataGridViewDers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "OgrenciDersListele";
            this.Text = "OgrenciDersListele";
            this.Load += new System.EventHandler(this.OgrenciDersListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDers;
        private System.Windows.Forms.TextBox Ara_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbfiltre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsırala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbdeğer;
        private System.Windows.Forms.Button Yenile_btn;
        private System.Windows.Forms.ComboBox cmbşekil;
    }
}