using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogic
{
  public class Konekcija
    {

        private string konkcijskiString_Local = "Data Source=.;Initial Catalog=KORHoteliApp;Integrated Security=True"; //lokalni sever

        public string KonkcijskiString_Lokal

        {
            get { return konkcijskiString_Local; }

        }


    }
}
