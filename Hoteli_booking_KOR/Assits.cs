using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
//using System.Data.SqlClient;


using DatabaseLogic;
using System.Collections;

namespace Hoteli_booking_KOR
{
  public  class Assits : IOInterface
    {

        Konekcija con = new Konekcija();

        private string _tipSobe;

        public ArrayList TipSobe
        {
            get;
            private set;
        }





        //konstruktor
        public Assits()
        {

            TipSobe = new ArrayList();
            TipSobe.Add("Obiteljska soba");
            TipSobe.Add("Apartman");
            TipSobe.Add("Dvokrevetna");
            TipSobe.Add("Jednokrevetna");
        }


        //provjeravai sprećavada nema duplih soba u Hotelu, misli se na broj sobe
        public int CheckRoomNumber(int soba, int hotel)
        {
            string sql = "p_provjera_sobe";
            using (SqlConnection conn = new SqlConnection(con.KonkcijskiString_Lokal))
            {
                SqlCommand com = new SqlCommand(sql, conn);
                com.CommandType = CommandType.StoredProcedure;

                SqlParameter paraBrojSobe = new SqlParameter();
                paraBrojSobe.ParameterName = "@brojSobe";
                paraBrojSobe.Value = soba;
                com.Parameters.Add(paraBrojSobe);


                SqlParameter paraHotel = new SqlParameter();
                paraHotel.ParameterName = "@Hotel";
                paraHotel.Value = hotel;
                com.Parameters.Add(paraHotel);

                //vraćeni objekt
                SqlParameter paraValidate = new SqlParameter();
                paraValidate.ParameterName = "@validate";
                paraValidate.SqlDbType = SqlDbType.Int;
                paraValidate.Direction = ParameterDirection.ReturnValue;
                com.Parameters.Add(paraValidate);

                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                int validate = Convert.ToInt16(paraValidate.Value);


                //ako je 1 tada je duplikat
                return validate;
             
            }



        }

        public int CheckHotelDuplicate(string naziv, string adresa)
        {
            string sql = "p_provjera_hotela";
            using (SqlConnection conn = new SqlConnection(con.KonkcijskiString_Lokal))
            {
                SqlCommand com = new SqlCommand(sql, conn);
                com.CommandType = CommandType.StoredProcedure;

                SqlParameter paraAdresa = new SqlParameter();
                paraAdresa.ParameterName = "@adresa";
                paraAdresa.Value = adresa;
                com.Parameters.Add(paraAdresa);


                SqlParameter paraNaziv = new SqlParameter();
                paraNaziv.ParameterName = "@naziv";
                paraNaziv.Value = naziv;
                com.Parameters.Add(paraNaziv);

                //vraćeni objekt
                SqlParameter paraValidate = new SqlParameter();
                paraValidate.ParameterName = "@validate";
                paraValidate.SqlDbType = SqlDbType.Int;
                paraValidate.Direction = ParameterDirection.ReturnValue;
                com.Parameters.Add(paraValidate);

                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                int validate = Convert.ToInt16(paraValidate.Value);


                //ako je 1 tada je duplikat
                return validate;

            }



        }


        //provjeravam koliko imam soba u hotelu ako brišem hotel.
        public int GetRooms(int Id_Hotel)
        {

            string sql = "select COUNT(*) from t_Sobe WHERE fk_hotel = "+ Id_Hotel.ToString();
            using (SqlConnection conn = new SqlConnection(con.KonkcijskiString_Lokal))
            {

                int rezultat;
                conn.Open();
                SqlCommand com = new SqlCommand(sql, conn);
                rezultat = ((int)com.ExecuteScalar());

                conn.Close();
                conn.Dispose();
                return rezultat;
  
            }


            
        }



        //koristi proceduru u bazi za brisanje hotelai soba po određenom parametru
        public void DeleteHotel(int Hotelid, int optimizeTable)
        {

            string sql = "p_brisanje_hotela";
                using (SqlConnection conn = new SqlConnection(con.KonkcijskiString_Lokal))
                {
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.CommandType = CommandType.StoredProcedure;

                    SqlParameter paraHotel = new SqlParameter();
                    paraHotel.ParameterName = "@Hotel";
                    paraHotel.Value = Hotelid;
                    com.Parameters.Add(paraHotel);

                    SqlParameter paraOptimnize = new SqlParameter();
                    paraOptimnize.ParameterName = "@optimizeTable";
                    paraOptimnize.Value = optimizeTable;
                    com.Parameters.Add(paraOptimnize);

                    conn.Open();
                    com.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                }

        }



    }
}
