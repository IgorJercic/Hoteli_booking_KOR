using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration.Provider;
using System.Configuration;

namespace DatabaseLogic
{
  public class Konekcija
    {

        // private string konkcijskiString_Local = @"Data Source=DESKTOP-1QD058U\SQLEXPRESS;Initial Catalog=KORHoteliApp; Trusted_Connection=True;"; //lokalni sever

        private string konkcijskiString_Local = "Data Source=.;Initial Catalog=KORHoteliApp; Trusted_Connection=True;";

        public string KonkcijskiString_Lokal

        {
            get { return konkcijskiString_Local; }

        }


    }
}
