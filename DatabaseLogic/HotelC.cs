using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogic
{
   public class HotelC
    {

        int id_hotel;
        string naziv;
        string adresa;

        public int Id_hotel
        {
            get
            {
                return id_hotel;
            }

            set
            {
                id_hotel = value;
            }
        }

        public string Naziv
        {
            get
            {

                return naziv;
            }

            set
            {
                  naziv = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }
    }
}
