namespace Hoteli_booking_KOR
{
    partial class Hotel
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
            this.panel1_editHotel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEdit_AdresaHotel = new System.Windows.Forms.TextBox();
            this.textBoxEdit_nazivHotel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNazivHotel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_hotelUnos = new System.Windows.Forms.Button();
            this.button_izmjena = new System.Windows.Forms.Button();
            this.panel1_editHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_editHotel
            // 
            this.panel1_editHotel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1_editHotel.Controls.Add(this.button_izmjena);
            this.panel1_editHotel.Controls.Add(this.label2);
            this.panel1_editHotel.Controls.Add(this.textBoxEdit_AdresaHotel);
            this.panel1_editHotel.Controls.Add(this.textBoxEdit_nazivHotel);
            this.panel1_editHotel.Controls.Add(this.label1);
            this.panel1_editHotel.Controls.Add(this.label_id);
            this.panel1_editHotel.Location = new System.Drawing.Point(113, 295);
            this.panel1_editHotel.Name = "panel1_editHotel";
            this.panel1_editHotel.Size = new System.Drawing.Size(318, 258);
            this.panel1_editHotel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adresa";
            // 
            // textBoxEdit_AdresaHotel
            // 
            this.textBoxEdit_AdresaHotel.Location = new System.Drawing.Point(48, 159);
            this.textBoxEdit_AdresaHotel.Name = "textBoxEdit_AdresaHotel";
            this.textBoxEdit_AdresaHotel.Size = new System.Drawing.Size(192, 20);
            this.textBoxEdit_AdresaHotel.TabIndex = 3;
            // 
            // textBoxEdit_nazivHotel
            // 
            this.textBoxEdit_nazivHotel.Location = new System.Drawing.Point(48, 94);
            this.textBoxEdit_nazivHotel.Name = "textBoxEdit_nazivHotel";
            this.textBoxEdit_nazivHotel.Size = new System.Drawing.Size(193, 20);
            this.textBoxEdit_nazivHotel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv Hotela";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(46, 20);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(111, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 230);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxAdresa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxNazivHotel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_hotelUnos);
            this.panel1.Location = new System.Drawing.Point(451, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 258);
            this.panel1.TabIndex = 2;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(103, 116);
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(123, 20);
            this.textBoxAdresa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa";
            // 
            // textBoxNazivHotel
            // 
            this.textBoxNazivHotel.Location = new System.Drawing.Point(103, 51);
            this.textBoxNazivHotel.Name = "textBoxNazivHotel";
            this.textBoxNazivHotel.Size = new System.Drawing.Size(123, 20);
            this.textBoxNazivHotel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Naziv Hotela";
            // 
            // button_hotelUnos
            // 
            this.button_hotelUnos.Location = new System.Drawing.Point(89, 184);
            this.button_hotelUnos.Name = "button_hotelUnos";
            this.button_hotelUnos.Size = new System.Drawing.Size(92, 52);
            this.button_hotelUnos.TabIndex = 0;
            this.button_hotelUnos.Text = "Unesi hotel";
            this.button_hotelUnos.UseVisualStyleBackColor = true;
            this.button_hotelUnos.Click += new System.EventHandler(this.button_hotelUnos_Click);
            // 
            // button_izmjena
            // 
            this.button_izmjena.Location = new System.Drawing.Point(88, 195);
            this.button_izmjena.Name = "button_izmjena";
            this.button_izmjena.Size = new System.Drawing.Size(100, 41);
            this.button_izmjena.TabIndex = 5;
            this.button_izmjena.Text = "Potvrdi izmjenu";
            this.button_izmjena.UseVisualStyleBackColor = true;
            this.button_izmjena.Click += new System.EventHandler(this.button_izmjena_Click);
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1_editHotel);
            this.Name = "Hotel";
            this.Text = "Hotel";
            this.panel1_editHotel.ResumeLayout(false);
            this.panel1_editHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_editHotel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBoxEdit_nazivHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEdit_AdresaHotel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_hotelUnos;
        private System.Windows.Forms.TextBox textBoxNazivHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_izmjena;
    }
}