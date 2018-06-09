using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
   public class tb_region_Data
    {
       public List<tb_region_Info> Get_List_Region()
       {
           try
           {
               string mensaje = "";

               List<tb_region_Info> lstCiudad = new List<tb_region_Info>();

               using (EntitiesGeneral Base = new EntitiesGeneral())
               {
                   var vciudad = from c in Base.tb_region
                                 select c;
                   foreach (var item in vciudad)
                   {
                       tb_region_Info infoCiudad = new tb_region_Info();
                       infoCiudad.Cod_Region = item.Cod_Region;
                       infoCiudad.Nom_region = item.Nom_region;                      
                       lstCiudad.Add(infoCiudad);
                   }
               }
               return lstCiudad;
           }
           catch (Exception ex)
           {
               return new List<tb_region_Info>();
           }
       }

    }
}
