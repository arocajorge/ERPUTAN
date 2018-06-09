using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt028_Data
    {
       public List<XCXP_Rpt028_Info> consultar_data(int idempresa, decimal IdConciliacion_Caja, ref string mensaje)
       {
           tb_Empresa_Data dataEmp = new tb_Empresa_Data();
           tb_Empresa_Info infoEmp = new tb_Empresa_Info();

           List<XCXP_Rpt028_Info> listadatos = new List<XCXP_Rpt028_Info>();
           try
           {

               using (EntitiesCXP_General OEnti = new EntitiesCXP_General())
               {

                   var select = from q in OEnti.vwCXP_Rpt028
                                where q.IdEmpresa == idempresa
                                && q.IdConciliacion_Caja == IdConciliacion_Caja
                                select q;
                   infoEmp = dataEmp.Get_Info_Empresa(idempresa);
                   foreach (var item in select)
                   {

                       XCXP_Rpt028_Info info = new XCXP_Rpt028_Info();


                         info.IdEmpresa = info.IdEmpresa;
                         info.IdConciliacion_Caja = item.IdConciliacion_Caja;
                         info. Fecha =item.Fecha;
                         info. IdCaja =item.IdCaja;
                         info. IdEstadoCierre =item.IdEstadoCierre;
                         info. Observacion =item.Observacion;
                         info. IdOrdenPago =item.IdOrdenPago;
                         info. IdTipo_Persona =item.IdTipo_Persona;
                         info. IdPersona =item.IdPersona;
                         info. IdTipo_op =item.IdTipo_op;
                         info. Fecha_OP =item.Fecha_OP;
                         info. Valor_a_pagar =item.Valor_a_pagar;
                         info. Referencia =item.Referencia;
                         info.pe_nombreCompleto =item.pe_nombreCompleto;
                         info.IdCtaCble=item.IdCtaCble;
                         info.pc_Cuenta=item.pc_Cuenta;
                         if (item.dc_Valor > 0)
                         {

                             info.debe = item.dc_Valor;
                         }
                         else
                         {
                             info.haber = item.dc_Valor * -1;
                         }
                         info.SubCentroCosto=item.SubCentroCosto;
                         info.Centro_costo=item.Centro_costo;
                         info.Observacion_OP = item.Observacion_OP;

                       
                       listadatos.Add(info);
                   }
               }
               return listadatos;

           }
           catch (Exception ex)
           {

               return new List<XCXP_Rpt028_Info>(); ;
           }

       }
    }
}
