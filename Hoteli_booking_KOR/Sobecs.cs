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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hoteli_booking_KOR
{
    public partial class Sobecs : Form
    {
        HotelContext _context = new HotelContext();
        Sobe _sobe = new Sobe();
        Assits _ass = new Assits();
        Konekcija _konekcija = new Konekcija();
        
        public Sobecs()
        {
            InitializeComponent();
            LoadListTip_Sobe();
            LoadHoteli();
            LoadGrid();

        }

        private void LoadGrid()
        {
            

            var grid = from u in _context.IESobe
                       from h in _context.IEHotel
                       where  u.Fk_Hotel == h.Id_hotel
                       select new { ID = u.Id_soba, Tip = u.TipSobe, Broj = u.BrojSobe, Hotel = h.Naziv };
            dataGridView1.DataSource = grid.ToList();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }



        private void button_izmjena_Click(object sender, EventArgs e)
        {

        }



        private void button_hotelUnos_Click(object sender, EventArgs e)
        {

            if (textBox_BrojSobe.Text != null || comboBox_TipSobe.SelectedValue != null || comboBox_Hotel.SelectedValue != null)
            {
             
                _sobe.BrojSobe = Convert.ToInt32(textBox_BrojSobe.Text);

                if (_ass.CheckRoomNumber(_sobe.BrojSobe, _sobe.Fk_Hotel) == 1)
                {
                      MessageBox.Show("Čini se da je broj sobe " + _sobe.BrojSobe.ToString() + " postoječi već u " + _sobe.Fk_Hotel + " hotelu!");
                }

               else
                {
                    _context.NewSoba(_sobe);
                    LoadGrid();
                }


            }

            else
            {
                MessageBox.Show("Niste odabrali polje za unos");

            }



        }




        private void LoadListTip_Sobe()
        {
            comboBox_TipSobe.Text = "-Odaberi tip sobe-";
            foreach (var item in _ass.TipSobe)
            {
                comboBox_TipSobe.Items.Add(item);
                
            }
        }





        private void LoadHoteli()
        {


            comboBox_Hotel.Text = "----";
            string query = "select ID_Hotel, naziv from t_Hotel order by ID_Hotel asc";

            SqlConnection conn = new SqlConnection(_konekcija.KonkcijskiString_Lokal);
            
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            conn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Sobe");
            comboBox_Hotel.DisplayMember = "naziv";
            comboBox_Hotel.ValueMember = "ID_Hotel";
            comboBox_Hotel.DataSource = ds.Tables["Sobe"];
            conn.Close();
            conn.Dispose();
        }

       



        private void comboBox_TipSobe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_TipSobe.Items != null)
            {
                _sobe.TipSobe = comboBox_TipSobe.SelectedItem.ToString();
            }
        }


        private void comboBox_Hotel_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (comboBox_Hotel.Items != null)
            {
                int br = Convert.ToInt16(comboBox_Hotel.SelectedValue.ToString());
                _sobe.Fk_Hotel = br;
            }







        }

        private void hoteliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            hotel.Show();
            this.Close();
        }
    }
}
