using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogic
{
   public class Sobe
    {

        int idSoba;
        int brojSobe;
        string tipSobe;
        int fk_hotel;

        public int Id_soba
        {
            get
            {
                return idSoba;
            }

            set
            {
                idSoba = value;
            }
        }

        public int BrojSobe
        {
            get
            {
                return brojSobe;
            }

            set
            {
                brojSobe = value;
            }
        }

        public string TipSobe
        {
            get
            {
                return tipSobe;
            }

            set
            {
                tipSobe = value;
            }
        }

        public int Fk_Hotel
        {
            get
            {
                return fk_hotel;
            }

            set
            {
                fk_hotel = value;
            }
        }
    }
}
