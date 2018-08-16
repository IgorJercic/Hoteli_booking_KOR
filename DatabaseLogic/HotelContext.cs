using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace DatabaseLogic 
{
   public class HotelContext
    {
        Konekcija con = new Konekcija();



   
        public IEnumerable<HotelC> IEHotel
        {

            get
            {
                string konekcijaString = con.KonkcijskiString_Lokal;
                string sql_ = "select * from t_Hotel";

                List<HotelC> hotel_lst = new List<HotelC>();

                using (SqlConnection conn = new SqlConnection(konekcijaString))
                {

                    SqlCommand com = new SqlCommand(sql_, conn);
                    conn.Open();
                    SqlDataReader rdr = com.ExecuteReader();

                    while (rdr.Read())
                    {
                        HotelC _hotel = new HotelC();

                        _hotel.Id_hotel = Convert.ToInt16(rdr["ID_Hotel"]);
                        _hotel.Naziv = rdr["naziv"].ToString();
                     
                        if (rdr["adresa"] is DBNull)
                        {
                           // _hotel.Adresa = rdr["adresa"].ToString();
                            _hotel.Adresa = "nema adrese";

                        }

                      
                        _hotel.Adresa = rdr["adresa"].ToString();






                        hotel_lst.Add(_hotel);


                    }

                    return hotel_lst;

                }

            }

        }


        public void NewHotel(HotelC hotel)
        {

            string konekcijaString = con.KonkcijskiString_Lokal;
            string sql = "p_insert_hotel";

            using (SqlConnection conn = new SqlConnection(konekcijaString))
            {

                SqlCommand com = new SqlCommand(sql, conn);
                com.CommandType = CommandType.StoredProcedure;

                SqlParameter paraNaziv = new SqlParameter();
                paraNaziv.ParameterName = "@naziv";
                paraNaziv.Value = hotel.Naziv;
                com.Parameters.Add(paraNaziv);



                SqlParameter paraAdresa = new SqlParameter();
                paraAdresa.ParameterName = "@adresa";
                paraAdresa.Value = hotel.Adresa;
                com.Parameters.Add(paraAdresa);

                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
            }
        }


        public void UpdateHotel(HotelC hotel)
        {
            string konekcijaString = con.KonkcijskiString_Lokal;
            string sql = "p_update_hotel";


            using (SqlConnection conn = new SqlConnection(konekcijaString))
            {

                SqlCommand com = new SqlCommand(sql, conn);
                com.CommandType = CommandType.StoredProcedure;

                SqlParameter paraIdHotel = new SqlParameter();
                paraIdHotel.ParameterName = "@id";
                paraIdHotel.Value = hotel.Id_hotel;
                com.Parameters.Add(paraIdHotel);

                SqlParameter paraNaziv = new SqlParameter();
                paraNaziv.ParameterName = "@naziv";
                paraNaziv.Value = hotel.Naziv;
                com.Parameters.Add(paraNaziv);

                SqlParameter paraAdresa = new SqlParameter();
                paraAdresa.ParameterName = "@adresa";
                paraAdresa.Value = hotel.Adresa;
                com.Parameters.Add(paraAdresa);


                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();

            }
        }



        ////Sobe 

        public IEnumerable<Sobe> IESobe
        {

            get
            {
                string konekcijaString = con.KonkcijskiString_Lokal;
                string sql_ = "select * from t_Sobe";

                List<Sobe> sobe_lst = new List<Sobe>();

                using (SqlConnection conn = new SqlConnection(konekcijaString))
                {

                    SqlCommand com = new SqlCommand(sql_, conn);
                    conn.Open();
                    SqlDataReader rdr = com.ExecuteReader();

                    while (rdr.Read())
                    {
                        Sobe _sobe = new Sobe();
                        _sobe.Id_soba = Convert.ToInt16(rdr["ID_Soba"]);
                        _sobe.BrojSobe = Convert.ToInt32(rdr["broj_sobe"]);
                        _sobe.TipSobe = rdr["tip_sobe"].ToString();
                        _sobe.Fk_Hotel = Convert.ToInt32(rdr["fk_hotel"]);
                        sobe_lst.Add(_sobe);

                    }

                    return sobe_lst;

                }

            }

        }


        public void NewSoba(Sobe sobe)
        {

            string konekcijaString = con.KonkcijskiString_Lokal;
            string sql = "p_insert_sobe";

            using (SqlConnection conn = new SqlConnection(konekcijaString))
            {

                SqlCommand com = new SqlCommand(sql, conn);
                com.CommandType = CommandType.StoredProcedure;

                SqlParameter paraBrojSobe = new SqlParameter();
                paraBrojSobe.ParameterName = "@brojsobe";
                paraBrojSobe.Value = sobe.BrojSobe;
                com.Parameters.Add(paraBrojSobe);

                SqlParameter paraTip = new SqlParameter();
                paraTip.ParameterName = "@tip";
                paraTip.Value = sobe.TipSobe;
                com.Parameters.Add(paraTip);

                SqlParameter paraFk_Hotel = new SqlParameter();
                paraFk_Hotel.ParameterName = "@fk_hotel";
                paraFk_Hotel.Value = sobe.Fk_Hotel;
                com.Parameters.Add(paraFk_Hotel);

                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
            }
        }


    }
}
