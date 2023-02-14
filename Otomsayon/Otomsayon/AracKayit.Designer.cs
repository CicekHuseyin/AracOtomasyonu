
namespace Otomsayon
{
    partial class AracKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracKayit));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmb_renk = new System.Windows.Forms.ComboBox();
            this.btn_arac_kaydet = new System.Windows.Forms.Button();
            this.cmb_yakit = new System.Windows.Forms.ComboBox();
            this.cmb_seri = new System.Windows.Forms.ComboBox();
            this.cmb_marka = new System.Windows.Forms.ComboBox();
            this.txt_kilometre = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_plaka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "musteri-kayıt.jpg");
            // 
            // cmb_renk
            // 
            this.cmb_renk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_renk.FormattingEnabled = true;
            this.cmb_renk.Items.AddRange(new object[] {
            "Siyah",
            "Gri",
            "Kırmızı",
            "Mavi",
            "Beyaz"});
            this.cmb_renk.Location = new System.Drawing.Point(188, 241);
            this.cmb_renk.Name = "cmb_renk";
            this.cmb_renk.Size = new System.Drawing.Size(144, 33);
            this.cmb_renk.TabIndex = 29;
            // 
            // btn_arac_kaydet
            // 
            this.btn_arac_kaydet.BackColor = System.Drawing.Color.White;
            this.btn_arac_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arac_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_arac_kaydet.ImageIndex = 0;
            this.btn_arac_kaydet.ImageList = this.ımageList1;
            this.btn_arac_kaydet.Location = new System.Drawing.Point(188, 441);
            this.btn_arac_kaydet.Name = "btn_arac_kaydet";
            this.btn_arac_kaydet.Size = new System.Drawing.Size(109, 54);
            this.btn_arac_kaydet.TabIndex = 32;
            this.btn_arac_kaydet.Text = "Kayıt";
            this.btn_arac_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_arac_kaydet.UseVisualStyleBackColor = false;
            this.btn_arac_kaydet.Click += new System.EventHandler(this.btn_arac_kaydet_Click);
            // 
            // cmb_yakit
            // 
            this.cmb_yakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_yakit.FormattingEnabled = true;
            this.cmb_yakit.ItemHeight = 25;
            this.cmb_yakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin+LPG"});
            this.cmb_yakit.Location = new System.Drawing.Point(188, 340);
            this.cmb_yakit.Name = "cmb_yakit";
            this.cmb_yakit.Size = new System.Drawing.Size(144, 33);
            this.cmb_yakit.TabIndex = 41;
            // 
            // cmb_seri
            // 
            this.cmb_seri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_seri.FormattingEnabled = true;
            this.cmb_seri.Location = new System.Drawing.Point(188, 142);
            this.cmb_seri.Name = "cmb_seri";
            this.cmb_seri.Size = new System.Drawing.Size(144, 33);
            this.cmb_seri.TabIndex = 27;
            // 
            // cmb_marka
            // 
            this.cmb_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_marka.FormattingEnabled = true;
            this.cmb_marka.Location = new System.Drawing.Point(188, 96);
            this.cmb_marka.Name = "cmb_marka";
            this.cmb_marka.Size = new System.Drawing.Size(144, 33);
            this.cmb_marka.TabIndex = 26;
            this.cmb_marka.SelectedIndexChanged += new System.EventHandler(this.cmb_marka_SelectedIndexChanged);
            // 
            // txt_kilometre
            // 
            this.txt_kilometre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kilometre.Location = new System.Drawing.Point(188, 295);
            this.txt_kilometre.Name = "txt_kilometre";
            this.txt_kilometre.Size = new System.Drawing.Size(144, 30);
            this.txt_kilometre.TabIndex = 30;
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_model.Location = new System.Drawing.Point(188, 193);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(144, 30);
            this.txt_model.TabIndex = 28;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_fiyat.Location = new System.Drawing.Point(188, 392);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(144, 30);
            this.txt_fiyat.TabIndex = 31;
            // 
            // txt_plaka
            // 
            this.txt_plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_plaka.Location = new System.Drawing.Point(188, 45);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(144, 30);
            this.txt_plaka.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(57, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(57, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Model(Yıl)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(57, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Yakıt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(58, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Seri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(57, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Marka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(57, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Renk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Plaka";
            // 
            // AracKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(431, 551);
            this.Controls.Add(this.cmb_renk);
            this.Controls.Add(this.btn_arac_kaydet);
            this.Controls.Add(this.cmb_yakit);
            this.Controls.Add(this.cmb_seri);
            this.Controls.Add(this.cmb_marka);
            this.Controls.Add(this.txt_kilometre);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_plaka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AracKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracKayit";
            this.Load += new System.EventHandler(this.AracKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ComboBox cmb_renk;
        private System.Windows.Forms.Button btn_arac_kaydet;
        private System.Windows.Forms.ComboBox cmb_yakit;
        private System.Windows.Forms.ComboBox cmb_seri;
        private System.Windows.Forms.ComboBox cmb_marka;
        private System.Windows.Forms.TextBox txt_kilometre;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_plaka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}