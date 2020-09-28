using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data
{
    public class ConexionERP
    {
        
        public static string GetConnectionString()
        {

            string ip = "192.168.50.8";
            string password = "@dmin*2015.12";

            //string ip = "localhost";
            //string password = "admin*2016";
            
            string user = "sa";
            string InitialCatalog = "DBERP_NAT_PROD";

            return "data source=" + ip + ";initial catalog=" + InitialCatalog + ";user id=" + user + ";password=" + password + ";MultipleActiveResultSets=True;";
        }
    }
}
