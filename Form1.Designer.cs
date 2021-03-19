namespace yoklamadeneme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmSinif = new System.Windows.Forms.ComboBox();
            this.cmDers = new System.Windows.Forms.ComboBox();
            this.lbSinifListe = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.yoklamaTakipDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btGonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yoklamaTakipDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmSinif
            // 
            this.cmSinif.FormattingEnabled = true;
            this.cmSinif.Items.AddRange(new object[] {
            "5-A",
            "6-A",
            "7-A",
            "8-A",
            "8-B",
            "9-A",
            "9-B",
            "10-A/B",
            "11-A",
            "11-B",
            "12-A",
            "12-B",
            "12-D",
            "12-E"});
            this.cmSinif.Location = new System.Drawing.Point(160, 116);
            this.cmSinif.Name = "cmSinif";
            this.cmSinif.Size = new System.Drawing.Size(121, 21);
            this.cmSinif.TabIndex = 0;
            this.cmSinif.SelectedIndexChanged += new System.EventHandler(this.cmSinif_SelectedIndexChanged);
            // 
            // cmDers
            // 
            this.cmDers.FormattingEnabled = true;
            this.cmDers.Items.AddRange(new object[] {
            "1.DERS",
            "2.DERS",
            "3.DERS",
            "4.DERS",
            "5.DERS",
            "6.DERS"});
            this.cmDers.Location = new System.Drawing.Point(160, 231);
            this.cmDers.Name = "cmDers";
            this.cmDers.Size = new System.Drawing.Size(121, 21);
            this.cmDers.TabIndex = 1;
            this.cmDers.SelectedIndexChanged += new System.EventHandler(this.cmDers_SelectedIndexChanged);
            this.cmDers.TextChanged += new System.EventHandler(this.cmDers_TextChanged);
            // 
            // lbSinifListe
            // 
            this.lbSinifListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSinifListe.FormattingEnabled = true;
            this.lbSinifListe.ItemHeight = 16;
            this.lbSinifListe.Location = new System.Drawing.Point(332, 23);
            this.lbSinifListe.Name = "lbSinifListe";
            this.lbSinifListe.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSinifListe.Size = new System.Drawing.Size(221, 452);
            this.lbSinifListe.TabIndex = 2;
            this.lbSinifListe.SelectedIndexChanged += new System.EventHandler(this.lbSinifListe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sınıf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ders Saati";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(594, 425);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(53, 16);
            this.lblTarih.TabIndex = 6;
            this.lblTarih.Text = "lblTarih";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(594, 455);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(50, 16);
            this.lblSaat.TabIndex = 7;
            this.lblSaat.Text = "lblSaat";
            // 
            // btGonder
            // 
            this.btGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btGonder.Location = new System.Drawing.Point(597, 195);
            this.btGonder.Name = "btGonder";
            this.btGonder.Size = new System.Drawing.Size(183, 34);
            this.btGonder.TabIndex = 9;
            this.btGonder.Text = "Gönder";
            this.btGonder.UseVisualStyleBackColor = true;
            this.btGonder.Click += new System.EventHandler(this.btGonder_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(805, 496);
            this.Controls.Add(this.btGonder);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSinifListe);
            this.Controls.Add(this.cmDers);
            this.Controls.Add(this.cmSinif);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kariyer Mimarı Koleji";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yoklamaTakipDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmSinif;
        private System.Windows.Forms.ComboBox cmDers;
        private System.Windows.Forms.ListBox lbSinifListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource yoklamaTakipDBDataSetBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Button btGonder;
    }
}

