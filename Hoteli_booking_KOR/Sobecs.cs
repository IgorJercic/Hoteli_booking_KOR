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

            if (textBoxEdit_BrojSobe != null || comboBox_TipSobe.SelectedValue != null || comboBox_Hotel.SelectedValue != null)
            {


                // _sobe.BrojSobe = int.Parse(textBoxEdit_BrojSobe.Text);
                _sobe.BrojSobe = 1;
                _sobe.Fk_Hotel = 1;
                _context.NewSoba(_sobe);
                LoadGrid();
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

            //comboBox_TipSobe.ValueMember = _ass.TipSobe.ToString();
        }



        private void LoadHoteli()
        {
            HotelC _newHotel = new HotelC();

            string sqlUpit = "select ID_Hotel, naziv from t_Hotel order by ID_Hotel asc";
            List<HotelC> hotelList = new List<HotelC>();

            using (SqlConnection conn = new SqlConnection(_konekcija.KonkcijskiString_Lokal))
            {

                SqlCommand com = new SqlCommand(sqlUpit, conn);
                conn.Open();
                SqlDataReader rdr = com.ExecuteReader();




                while (rdr.Read())
                {

                    //_newHotel.Id_hotel = Convert.ToInt16(rdr["ID_Hotel"]);
                    _newHotel.Naziv = rdr["naziv"].ToString();

                    hotelList.Add(_newHotel);
                    foreach (var item in hotelList)
                    {
                        comboBox_Hotel.Items.Add(item.Naziv);
                    }
                }
             

                //    while (rdr.Read())
                //    {

                //        _newHotel.Id_hotel = Convert.ToInt16(rdr["ID_Hotel"]);
                //        _newHotel.Naziv = rdr["naziv"].ToString();
                //        hotelList.Add(_newHotel);

                //        comboBox_Hotel.DataSource = hotelList;
                //        comboBox_Hotel.DisplayMember = rdr["naziv"].ToString();
                //        comboBox_Hotel.ValueMember = "ID_Hotel";


                //}

                rdr.Close();
                conn.Close();
                conn.Dispose();

            }
            
        }






       

        private void comboBox_TipSobe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_TipSobe.Items != null)
            {
                _sobe.TipSobe = comboBox_TipSobe.SelectedItem.ToString();
               // MessageBox.Show("" + _sobe.TipSobe);
            }
        }

        private void comboBox_Hotel_Click(object sender, EventArgs e)
        {
            if (comboBox_Hotel.Items != null)
            {

                if (comboBox_Hotel.SelectedValue != null)
                {
                    // int br = Convert.ToInt16(comboBox_Hotel.SelectedValue.ToString());
                    string tk = comboBox_Hotel.SelectedValue.ToString();

                    _sobe.Fk_Hotel = Convert.ToInt16(tk);
                    //jebe peru mater
                    // MessageBox.Show("" + comboBox_Hotel.SelectedValue.ToString().GetType());
                    // MessageBox.Show("Hotel" +  _sobe.Fk_Hotel);
                    // https://stackoverflow.com/questions/4018114/read-data-from-sqldatareader
                    // https://stackoverflow.com/questions/23561375/objects-from-database-to-fill-list
                    //https://stackoverflow.com/questions/46484454/populate-textbox-with-id-column-of-related-selected-value-from-combo-box
                }


            }
        }
    }
}
