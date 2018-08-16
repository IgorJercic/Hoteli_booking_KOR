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
        Assits _ass = new Assits();
       

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

                if (_ass.CheckHotelDuplicate(_hotel.Naziv, _hotel.Adresa) == 0)
                {
                    //nije duplikat
                    _context.NewHotel(_hotel);
                    LoadGrid();
                    MessageBox.Show("Unjeli ste hotel!");
                }

                else
                {
                    MessageBox.Show("Unašate dupli hotel po nazivu ili adresi");
                }


            }

            else
            {
                MessageBox.Show("Nisi unio adresu ili naziv hotela");
                textBoxNazivHotel.BackColor = Color.Red;
                textBoxAdresa.BackColor = Color.Red;
            }

         
        }



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

                _hotel.Id_hotel = Convert.ToInt16(label_id.Text);
                _hotel.Adresa = textBoxEdit_AdresaHotel.Text;
                _hotel.Naziv = textBoxEdit_nazivHotel.Text;
                _context.UpdateHotel(_hotel);
                LoadGrid();
            }

            else
            {
                MessageBox.Show("Nisi odabrao hotel");
            }



        }



        //brisanje hotela
        private void button1_Click(object sender, EventArgs e)
        {
            _hotel.Id_hotel = Convert.ToInt16(label_id.Text);

            
            if (_ass.GetRooms(_hotel.Id_hotel) > 0)
            {
                DialogResult dijalogAkcijaBrisanje = MessageBox.Show("Ima više soba, obrisat će te hoteli više soba","jj", MessageBoxButtons.YesNo);
                if(dijalogAkcijaBrisanje == DialogResult.Yes)
                {
                    _ass.DeleteHotel(_hotel.Id_hotel, 1);
                    LoadGrid();
                }

                else if(dijalogAkcijaBrisanje == DialogResult.No)
                {
                         //PIPREMA ZA GOSTE
                      //  _ass.DeleteHotel(_hotel.Id_hotel, 0);
                 }
            }

            else
            {
               
            }
        }

        private void unesiSobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobecs sobe = new Sobecs();
            sobe.Show();
            this.Close();
            
        }
    }
}
