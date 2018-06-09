using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxPagar
{
   public class XCXP_Rpt027_Data
   {
       public List<XCXP_Rpt027_Info> consultar_data(int idempresa, decimal IdConciliacion_Caja, ref string mensaje)
       {
           tb_Empresa_Data dataEmp = new tb_Empresa_Data();
           tb_Empresa_Info infoEmp = new tb_Empresa_Info();

           List<XCXP_Rpt027_Info> listadatos = new List<XCXP_Rpt027_Info>();
           try
           {

               using (EntitiesCXP_General OEnti = new EntitiesCXP_General())
               {

                   var select = from q in OEnti.vwCXP_Rpt027
                                where q.IdEmpresa == idempresa
                                && q.IdConciliacion_Caja == IdConciliacion_Caja
                                select q;
                   infoEmp = dataEmp.Get_Info_Empresa(idempresa);
                   foreach (var item in select)
                   {

                       XCXP_Rpt027_Info info = new XCXP_Rpt027_Info();
                         info.IdEmpresa=item.IdEmpresa;
                         info. IdConciliacion_Caja =info. IdConciliacion_Caja;
                         info. Secuencia=item.Secuencia;
                         info. IdEmpresa_movcaja =item.IdEmpresa_movcaja;
                         info. IdCbteCble_movcaja =item.IdConciliacion_Caja;
                         info. IdTipocbte_movcaja =item.IdTipocbte_movcaja;
                         info. IdCtaCble =item.IdCtaCble;
                         info.cm_valor =item.cm_valor;
                         info. cm_beneficiario =item.cm_beneficiario;
                         info. IdTipoMovi =item.IdTipoMovi;
                         info. tm_descripcion =item.tm_descripcion;
                         info.cm_observacion = item.cm_observacion;
                         info.pc_Cuenta = item.pc_Cuenta;

                       listadatos.Add(info);
                   }
               }
               return listadatos;

           }
           catch (Exception ex)
           {

               return new List<XCXP_Rpt027_Info>(); ;
           }

       }
       
    }
}
