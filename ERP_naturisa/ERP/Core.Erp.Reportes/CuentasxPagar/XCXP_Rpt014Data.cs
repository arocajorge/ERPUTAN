using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt014Data
    {
        public List<XCXP_Rpt014_Info> GetData(int IdEmpresa, DateTime Fechacorte, decimal IdProveedor) 
        {
            try
            {
                using (EntitiesCXP_General conexion = new EntitiesCXP_General())
                {

                    List<XCXP_Rpt014_Info> Result = new List<XCXP_Rpt014_Info>();
                    List<spCXP_Rpt014_Result> ResponseSp = new List<spCXP_Rpt014_Result>();
                    
                        if (IdProveedor == 0)
                        {
                            ResponseSp = conexion.spCXP_Rpt014(IdEmpresa, Fechacorte, 0, 9999999999).ToList();
                        }
                        else
                        {
                            ResponseSp = conexion.spCXP_Rpt014(IdEmpresa, Fechacorte, IdProveedor, IdProveedor).ToList();
                        }
                        Result = (from q in ResponseSp select new XCXP_Rpt014_Info() { IdEmpresa = q.IdEmpresa, IdProveedor = q.IdProveedor
                        , MontoAplicado= q.MontoAplicado, nom_proveedor = q.nom_proveedor,  Ruc_Proveedor = q.Ruc_Proveedor
                        , Saldo=q.Saldo, Tipo_cbte = q.Tipo_cbte, Valor_a_pagar = q.Valor_a_pagar, Ven_1_30 =q.Ven_1_30, Ven_180_9999=q.Ven_180_9999
                        , Ven_31_60=q.Ven_31_60, Ven_61_180= q.Ven_61_180 , x_Ven_1_30 =   q.x_Ven_1_30, x_Ven_180_9999 = q.x_Ven_180_9999
                        , x_Ven_31_60 =q.x_Ven_31_60 , x_Ven_61_180 =q.x_Ven_61_180}).ToList();

                        return Result;
                    
                     
                }
            }
            catch (Exception)
            {
                
                return new List<XCXP_Rpt014_Info>();
            }
        }
    }
}
