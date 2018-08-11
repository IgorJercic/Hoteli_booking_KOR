using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLogic;
using System.Data.SqlClient;

namespace Hoteli_booking_KOR
{
    public partial class Form1 : Form
    {

        Konekcija con = new Konekcija();
        public Form1()
        {
            InitializeComponent();
            ChkKonekciju();
        }

        //testiram konekciju
        public void ChkKonekciju()
        {
            using (SqlConnection kon = new SqlConnection(con.KonkcijskiString_Lokal))
            {

                kon.Open();
                if (kon.State == ConnectionState.Open)
                {
                    label_kon.BackColor = Color.ForestGreen;
                    label_kon.ForeColor = Color.White;
                    label_kon.Text = "Veza je otvorena";
                }

                else
                {
                    label_kon.BackColor = Color.Red;
                    label_kon.ForeColor = Color.White;
                    label_kon.Text = "Problem s spajanjem na bazu";
                }

            }
        }

        private void button1_hotel_Click(object sender, EventArgs e)
        {
            Hotel hotelForma = new Hotel();
            hotelForma.Show();
        }

        private void button_sobe_Click(object sender, EventArgs e)
        {
            Sobecs sobe = new Sobecs();
            sobe.Show();
            
        }
    }
}
