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

namespace Hoteli_booking_KOR
{
    public partial class Hotel : Form, IOInterface
    {

        HotelContext _context = new HotelContext();
        HotelC _hotel = new HotelC();
       

        public Hotel()
        {
            InitializeComponent();
            panel1_editHotel.Hide();
            LoadGrid();
           
        }



        private void LoadGrid()
        {
            var grid = from u in _context.IEHotel
                       select new { ID = u.Id_hotel, Naziv = u.Naziv, Adresa = u.Adresa };
            dataGridView1.DataSource = grid.ToList();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button_hotelUnos_Click(object sender, EventArgs e)
        {

            if(textBoxAdresa.Text != null || textBoxNazivHotel.Text != null)
            {
                _hotel.Naziv = textBoxNazivHotel.Text;
                _hotel.Adresa = textBoxAdresa.Text;

                _context.NewHotel(_hotel);
                LoadGrid();

            }

            else
            {
                MessageBox.Show("Nisi unio adresu ili naziv hotela");
                textBoxNazivHotel.BackColor = Color.Red;
                textBoxAdresa.BackColor = Color.Red;
            }

         
        }


        //private void dataGridView1_DoubleClick(object sender, EventArgs e)
        //{
        //    ////ovo radi
        //    //DataGridViewRow rowID = this.dataGridView1.SelectedRows[0];
        //    //panel1_editHotel.Show();

        //    //int IDHotel = Convert.ToInt32(rowID.Cells["ID"].Value);
        //    //label_id.Text = Convert.ToInt16(rowID.Cells["ID"].Value).ToString();
        //    //textBoxEdit_nazivHotel.Text = rowID.Cells["naziv"].Value.ToString();
        //    //textBoxEdit_AdresaHotel.Text = rowID.Cells["adresa"].Value.ToString();

        //}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1_editHotel.Show();

            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            label_id.Text = selectedRow.Cells[0].Value.ToString();
            textBoxEdit_nazivHotel.Text = selectedRow.Cells[1].Value.ToString();
            textBoxEdit_AdresaHotel.Text = selectedRow.Cells[2].Value.ToString();
            
           
        }

        private void button_izmjena_Click(object sender, EventArgs e)
        {
            if(label_id.Text != null || label_id.Text != "0")
            {
                _hotel.Id_hotel = int.Parse(label_id.Text);
                _hotel.Adresa = textBoxEdit_AdresaHotel.ToString();
                _hotel.Naziv = textBoxEdit_nazivHotel.ToString();

                _context.UpdateHotel(_hotel);
            
               
            }

            else
            {
                MessageBox.Show("Nisi odabrao hotel");
            }



        }
    }
}
