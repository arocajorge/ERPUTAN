using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Cus.Erp.Reports.Talme.Facturacion
{
   public  class Xrp_Fa_Report1_Data
    {

       List<Xrp_Fa_Report1_Info> listado = new List<Xrp_Fa_Report1_Info>();
       
       public List<Xrp_Fa_Report1_Info> Obtener_data(ref string  mensaje)
       {
        
               try
               {

                   
                   using (EntitiesFacturacion_Rpt DB = new EntitiesFacturacion_Rpt())
                   {


                       var Consulta = from q in DB.vwFAC_CUS_TAL_Rpt001
                                      select q;


                       foreach (var item in Consulta)
                       {
                           Xrp_Fa_Report1_Info Info = new Xrp_Fa_Report1_Info();
                           Info.IdEmpresa = item.IdEmpresa;
                          // Info.Codigo = item.Codigo;
                           Info.em_nombre = item.em_nombre;
                           Info.IdCliente = item.IdCliente;
                           Info.IdEmpresa = item.IdEmpresa;
                           Info.IdSucursal = item.IdSucursal;
                        //   Info.pe_apellido = item.pe_apellido;
                        //   Info.pe_nombre = item.pe_nombre;
                           Info.pe_nombreCompleto = item.pe_nombreCompleto;
                         //  Info.pe_razonSocial = item.pe_razonSocial;
                           Info.Su_Descripcion = item.Su_Descripcion;
                           listado.Add(Info);
                       }
                   }
                   //return Lst;
                   return listado;    
               }
               catch (Exception ex)
               {
                   //string arreglo = ToString();
                   //tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                   //tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                   //oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                   //mensaje = ex.InnerException + " " + ex.Message;
                   return new List<Xrp_Fa_Report1_Info>();
               }

            
          
          
       }




    }
}
