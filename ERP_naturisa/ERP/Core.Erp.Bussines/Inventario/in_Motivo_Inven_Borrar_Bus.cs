using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Inventario
{
   public  class in_Motivo_Inven_Borrar_Bus
    {

       in_Motivo_Inven_Borrar_Data Odata = new in_Motivo_Inven_Borrar_Data();


       public List<in_Motivo_Inven_Borrar_Info > consultar(int IdEmpresa)
       {
           try
           {

               return Odata.consultar(IdEmpresa);
               
           }
           catch (Exception ex)
           {

               return new List<in_Motivo_Inven_Borrar_Info>();
           }
       }

       public List<in_Motivo_Inven_Borrar_Info> consultar(int IdEmpresa,int Ran_inicial, int Ran_final)
       {
           try
           {

               return Odata.consultar(IdEmpresa, Ran_inicial, Ran_final);

           }
           catch (Exception ex)
           {

               return new List<in_Motivo_Inven_Borrar_Info>();
           }
       }


       public Boolean GrabarDB(in_Motivo_Inven_Borrar_Info Info, ref int Id, ref string msg)
       {
           try
           {

               return Odata.GrabarDB(Info, ref Id, ref msg);
           }
           catch (Exception ex)
           {

               return false;
           }

       }


       public Boolean ModificarDB(in_Motivo_Inven_Borrar_Info Info,  ref string msg)
       {

           try
           {

               return Odata.ModificarDB(Info,  ref msg);
           }
           catch (Exception ex)
           {

               return false;
           }
       }

       public Boolean AnularDB(in_Motivo_Inven_Borrar_Info Info, ref string msg)
         {
             try
             {

                 return Odata.AnularDB(Info,  ref msg);
             }
             catch (Exception ex)
             {

                 return false;
             }
         }
    }
}
