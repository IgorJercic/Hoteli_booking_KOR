using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;


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






        public Assits()
        {

            TipSobe = new ArrayList();
            TipSobe.Add("Obiteljska soba");
            TipSobe.Add("Apartman");
            TipSobe.Add("Dvokrevetna");
            TipSobe.Add("Jednokrevetna");
        }









       
    }
}
