namespace Hoteli_booking_KOR
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
            this.button1_hotel = new System.Windows.Forms.Button();
            this.button_sobe = new System.Windows.Forms.Button();
            this.button_gost = new System.Windows.Forms.Button();
            this.label_kon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_hotel
            // 
            this.button1_hotel.Location = new System.Drawing.Point(183, 205);
            this.button1_hotel.Name = "button1_hotel";
            this.button1_hotel.Size = new System.Drawing.Size(245, 125);
            this.button1_hotel.TabIndex = 0;
            this.button1_hotel.Text = "HOTEL (unesi, obrisi)";
            this.button1_hotel.UseVisualStyleBackColor = true;
            this.button1_hotel.Click += new System.EventHandler(this.button1_hotel_Click);
            // 
            // button_sobe
            // 
            this.button_sobe.Location = new System.Drawing.Point(473, 205);
            this.button_sobe.Name = "button_sobe";
            this.button_sobe.Size = new System.Drawing.Size(245, 125);
            this.button_sobe.TabIndex = 1;
            this.button_sobe.Text = "SOBE (unesi, obrisi)";
            this.button_sobe.UseVisualStyleBackColor = true;
            this.button_sobe.Click += new System.EventHandler(this.button_sobe_Click);
            // 
            // button_gost
            // 
            this.button_gost.Location = new System.Drawing.Point(757, 205);
            this.button_gost.Name = "button_gost";
            this.button_gost.Size = new System.Drawing.Size(245, 125);
            this.button_gost.TabIndex = 2;
            this.button_gost.Text = "GOST (manager)";
            this.button_gost.UseVisualStyleBackColor = true;
            // 
            // label_kon
            // 
            this.label_kon.AutoSize = true;
            this.label_kon.Location = new System.Drawing.Point(570, 415);
            this.label_kon.Name = "label_kon";
            this.label_kon.Size = new System.Drawing.Size(0, 13);
            this.label_kon.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 593);
            this.Controls.Add(this.label_kon);
            this.Controls.Add(this.button_gost);
            this.Controls.Add(this.button_sobe);
            this.Controls.Add(this.button1_hotel);
            this.Name = "Form1";
            this.Text = "Hotel Igor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_hotel;
        private System.Windows.Forms.Button button_sobe;
        private System.Windows.Forms.Button button_gost;
        private System.Windows.Forms.Label label_kon;
    }
}

