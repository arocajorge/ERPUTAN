using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt013_Data
    {
        public List<XCXP_Rpt013_Info> GetData(int IdEmpresa, DateTime Fechacorte, decimal IdProveedor) 
        {
            try
            {
                 List<XCXP_Rpt013_Info> Result = new List<XCXP_Rpt013_Info>();
                 List<spCXP_Rpt013_Result> ResponseSp = new List<spCXP_Rpt013_Result>();
                 using (EntitiesCXP_General conexion = new EntitiesCXP_General())
                 {
                     if (IdProveedor == 0)
                     {
                        ResponseSp =  conexion.spCXP_Rpt013(IdEmpresa, Fechacorte, 0, 9999999999).ToList() ;
                     }
                     else
                     {
                         ResponseSp = conexion.spCXP_Rpt013(IdEmpresa, Fechacorte,IdProveedor, IdProveedor).ToList();
                     }
                 }
                 Result = (from q in ResponseSp
                           select new XCXP_Rpt013_Info {  cb_Fecha= q.cb_Fecha, co_fechaOg=q.co_fechaOg, cod_tipo_doc = q.cod_tipo_doc, Documento = q.Documento, IdCbteCble_Ogiro
                            =q.IdCbteCble_Ogiro,  IdEmpresa = q.IdEmpresa, IdOrden_giro_Tipo= q.IdOrden_giro_Tipo, IdProveedor=q.IdProveedor, IdTipoCbte_Ogiro=q.IdTipoCbte_Ogiro,
                            MontoAplicado = q.MontoAplicado, nom_proveedor= q.nom_proveedor, nom_tipo_doc =q.nom_tipo_doc, Ruc_Proveedor= q.Ruc_Proveedor, Saldo=q.Saldo,
                            Ven_1_30 = q.Ven_1_30 , Ven_180_9999 = q.Ven_180_9999, Ven_31_60=q.Ven_31_60, Ven_61_180 =q.Ven_61_180, Valor_a_pagar= q.Valor_a_pagar}).ToList();

                return Result;

            }
            catch (Exception)
            {

                return new List<XCXP_Rpt013_Info>();
            }
        }
    }
}
