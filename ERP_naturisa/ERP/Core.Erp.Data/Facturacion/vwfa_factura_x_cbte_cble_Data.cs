using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;



namespace Core.Erp.Data.Facturacion
{
   public class vwfa_factura_x_cbte_cble_Data
    {
       string mensaje = "";




       public List<vwfa_factura_x_cbte_cble_Info> Get_List_factura_x_cbte_cble(int IdEmpresa, DateTime Fecha_Ini, DateTime Fecha_Fin, bool Mostar_no_contabilizado)
       {
           try
           {
               Fecha_Ini = Convert.ToDateTime(Fecha_Ini.ToShortDateString());
               Fecha_Fin = Convert.ToDateTime(Fecha_Fin.ToShortDateString());


               List<vwfa_factura_x_cbte_cble_Info> lista = new List<vwfa_factura_x_cbte_cble_Info>();

               EntitiesFacturacion oEnt = new EntitiesFacturacion();

               if (Mostar_no_contabilizado == true)
               {
                   var select = from q in oEnt.vwfa_factura_x_cbte_cble
                                where q.IdEmpresa == IdEmpresa
                                && q.vt_fecha >= Fecha_Ini && q.vt_fecha <= Fecha_Fin
                                && q.IdCbteCble == null
                                select q;

                   foreach (var item in select)
                   {
                       vwfa_factura_x_cbte_cble_Info info = new vwfa_factura_x_cbte_cble_Info();

                       info.IdEmpresa = item.IdEmpresa;
                       info.IdSucursal = item.IdSucursal;
                       info.IdCbteVta = item.IdCbteVta;
                       info.Su_Descripcion = item.Su_Descripcion;
                       info.CodCbteVta = item.CodCbteVta;
                       info.num_factura = item.num_factura;
                       info.vt_fecha = item.vt_fecha;
                       info.vt_Observacion = item.vt_Observacion;
                       info.IdCliente = item.IdCliente;
                       info.pe_nombreCompleto = item.pe_nombreCompleto;
                       info.vt_Subtotal = item.vt_Subtotal;
                       info.vt_iva = item.vt_iva;
                       info.vt_total = item.vt_total;
                       info.IdCbteCble = item.IdCbteCble;
                       info.nom_tipo_cbte = item.nom_tipo_cbte;
                       info.cb_Fecha = item.cb_Fecha;
                       info.cb_Valor = item.cb_Valor;
                       info.cb_Observacion = item.cb_Observacion;
                       info.BContabilizar = (info.IdCbteCble == null) ? true : false;

                       lista.Add(info);
                   }
               }
               else
               {

                   var select = from q in oEnt.vwfa_factura_x_cbte_cble
                                where q.IdEmpresa == IdEmpresa
                                && q.vt_fecha >= Fecha_Ini && q.vt_fecha <= Fecha_Fin
                                select q;

                   foreach (var item in select)
                   {
                       vwfa_factura_x_cbte_cble_Info info = new vwfa_factura_x_cbte_cble_Info();

                       info.IdEmpresa = item.IdEmpresa;
                       info.IdSucursal = item.IdSucursal;
                       info.IdCbteVta = item.IdCbteVta;
                       info.Su_Descripcion = item.Su_Descripcion;
                       info.CodCbteVta = item.CodCbteVta;
                       info.num_factura = item.num_factura;
                       info.vt_fecha = item.vt_fecha;
                       info.vt_Observacion = item.vt_Observacion;
                       info.IdCliente = item.IdCliente;
                       info.pe_nombreCompleto = item.pe_nombreCompleto;
                       info.vt_Subtotal = item.vt_Subtotal;
                       info.vt_iva = item.vt_iva;
                       info.vt_total = item.vt_total;
                       info.IdCbteCble = item.IdCbteCble;
                       info.nom_tipo_cbte = item.nom_tipo_cbte;
                       info.cb_Fecha = item.cb_Fecha;
                       info.cb_Valor = item.cb_Valor;
                       info.cb_Observacion = item.cb_Observacion;
                       info.BContabilizar = (info.IdCbteCble == null) ? true : false;

                       lista.Add(info);
                   }
               }

               
               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }

    }
}
