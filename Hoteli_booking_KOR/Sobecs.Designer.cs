namespace Hoteli_booking_KOR
{
    partial class Sobecs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Hotel = new System.Windows.Forms.ComboBox();
            this.comboBox_TipSobe = new System.Windows.Forms.ComboBox();
            this.textBox_BrojSobe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_hotelUnos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hoteliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
            this.panel1_editHotel.SuspendLayout();
>>>>>>> 9800b4e9a2933ec8936b4bb7be054d052b0263a4
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox_Hotel);
            this.panel1.Controls.Add(this.comboBox_TipSobe);
            this.panel1.Controls.Add(this.textBox_BrojSobe);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_hotelUnos);
            this.panel1.Location = new System.Drawing.Point(158, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 258);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hotel";
            // 
            // comboBox_Hotel
            // 
            this.comboBox_Hotel.FormattingEnabled = true;
            this.comboBox_Hotel.Location = new System.Drawing.Point(93, 143);
            this.comboBox_Hotel.Name = "comboBox_Hotel";
            this.comboBox_Hotel.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Hotel.TabIndex = 6;
<<<<<<< HEAD
            this.comboBox_Hotel.SelectedIndexChanged += new System.EventHandler(this.comboBox_Hotel_SelectedIndexChanged);
=======
          //  this.comboBox_Hotel.SelectedIndexChanged += new System.EventHandler(this.comboBox_Hotel_SelectedIndexChanged);
            this.comboBox_Hotel.Click += new System.EventHandler(this.comboBox_Hotel_Click);
>>>>>>> 9800b4e9a2933ec8936b4bb7be054d052b0263a4
            // 
            // comboBox_TipSobe
            // 
            this.comboBox_TipSobe.FormattingEnabled = true;
            this.comboBox_TipSobe.Location = new System.Drawing.Point(93, 101);
            this.comboBox_TipSobe.Name = "comboBox_TipSobe";
            this.comboBox_TipSobe.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TipSobe.TabIndex = 5;
            this.comboBox_TipSobe.SelectedIndexChanged += new System.EventHandler(this.comboBox_TipSobe_SelectedIndexChanged);
            // 
            // textBox_BrojSobe
            // 
            this.textBox_BrojSobe.Location = new System.Drawing.Point(94, 51);
            this.textBox_BrojSobe.Name = "textBox_BrojSobe";
            this.textBox_BrojSobe.Size = new System.Drawing.Size(92, 20);
            this.textBox_BrojSobe.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip Sobe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Broj Sobe";
            // 
            // button_hotelUnos
            // 
            this.button_hotelUnos.Location = new System.Drawing.Point(89, 184);
            this.button_hotelUnos.Name = "button_hotelUnos";
            this.button_hotelUnos.Size = new System.Drawing.Size(92, 52);
            this.button_hotelUnos.TabIndex = 0;
            this.button_hotelUnos.Text = "Unesi Sobu";
            this.button_hotelUnos.UseVisualStyleBackColor = true;
            this.button_hotelUnos.Click += new System.EventHandler(this.button_hotelUnos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(158, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 230);
            this.dataGridView1.TabIndex = 4;
            // 
<<<<<<< HEAD
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoteliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hoteliToolStripMenuItem
            // 
            this.hoteliToolStripMenuItem.Name = "hoteliToolStripMenuItem";
            this.hoteliToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.hoteliToolStripMenuItem.Text = "Hoteli";
            this.hoteliToolStripMenuItem.Click += new System.EventHandler(this.hoteliToolStripMenuItem_Click);
            // 
=======
>>>>>>> 9800b4e9a2933ec8936b4bb7be054d052b0263a4
            // Sobecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sobecs";
            this.Text = "Sobecs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_hotelUnos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_BrojSobe;
        private System.Windows.Forms.ComboBox comboBox_TipSobe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Hotel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hoteliToolStripMenuItem;
    }
}