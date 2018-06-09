using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Cus.Erp.Reports.Cidersus.Produccion
{
   public class XPRO_CUS_CID_Rpt002_Data
   {
       string mensaje = "";
       public List<XPRO_CUS_CID_Rpt002_Info> OptenerData_spPRD_Rpt_RPRD002(int IdEmpresa, int idOrdenCompra)
       {
           try
           {
               List<XPRO_CUS_CID_Rpt002_Info> ListData = new List<XPRO_CUS_CID_Rpt002_Info>();
               int s = 0;

               using (EntitiesProduccion_Edehsa_Rpt base_ = new EntitiesProduccion_Edehsa_Rpt())
               {

                   var q = from C in base_.vwprd_OrdenCompraCidersus
                           where C.IdEmpresa == IdEmpresa && C.IdOrdenCompra == idOrdenCompra
                           select C;

                   foreach (var item in q)
                   {
                       s = s + 1;
                       XPRO_CUS_CID_Rpt002_Info info = new XPRO_CUS_CID_Rpt002_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdSucursal = item.IdSucursal;
                       info.IdOrdenCompra = item.IdOrdenCompra;
                       info.IdProveedor = item.IdProveedor;
                       info.em_nombre = item.em_nombre;
                       info.pr_nombre = item.pr_nombre;
                       info.oc_plazo = item.oc_plazo;
                       info.oc_fecha = item.oc_fecha;
                       info.pr_codigo = item.pr_codigo;
                       info.pr_codigo = item.pr_codigo;
                       info.pr_descripcion = item.pr_descripcion;
                       info.do_Cantidad = item.do_Cantidad;
                       info.IdUnidadMedida = item.IdUnidadMedida;
                       if (item.pr_contribuyenteEspecial == "S")
                       {
                           info.pr_contribuyenteEspecial = true;
                           info.proveedor_es_contribuyente_especial = "X";
                       }
                       else
                       {
                           info.pr_contribuyenteEspecial = false;
                           info.proveedor_no_es_contribuyente_especial = "X";
                       }

                       info.do_precioCompra = item.do_precioCompra;
                       info.do_subtotal = item.do_subtotal;
                       info.do_iva = item.do_iva;
                       info.do_total = item.do_total;
                       info.do_descuento = item.do_descuento;
                       info.do_porc_des = item.do_porc_des;
                       info.Usuario_Aprueba = item.Usuario_Aprueba;
                       info.Usuario_Solicitante = item.Usuario_Solicitante;
                       info.oc_NumDocumento = item.oc_NumDocumento;

                       if (item.TerminoPago == "CRED")
                       {
                           info.escredito = "X";
                           info.escontado = "";
                       }
                       if (item.TerminoPago == "CONTADO")
                       {
                           info.escredito = "";
                           info.escontado = "X";
                       }

                       info.UnidadMedidaConsumo = item.UnidadMedidaConsumo;

                       info.Secuencia = s;
                       ListData.Add(info);
                   }

               }

               return ListData;

           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.ToString() + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }
    
    
    }
}
