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
    public partial class Sobecs : Form
    {
        HotelContext _context = new HotelContext();
        Sobe _sobe = new Sobe();
        Assits _ass = new Assits();
        public Sobecs()
        {
            InitializeComponent();
            LoadListTip_Sobe();

        }

        private void LoadGrid()
        {
            

            var grid = from u in _context.IESobe
                       from h in _context.IEHotel
                       where  u.Fk_Hotel == h.Id_hotel
                       select new { ID = u.Id_soba, Tip = u.TipSobe, Broj = u.BrojSobe, FkHotel = h.Id_hotel };
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





        }




        private void LoadListTip_Sobe()
        {
            comboBox_TipSobe.Text = "-Odaberi tip sobe-";

            foreach (var item in _ass.TipSobe)
            {
                comboBox_TipSobe.Items.Add(item);
            }
        }
    }
}
