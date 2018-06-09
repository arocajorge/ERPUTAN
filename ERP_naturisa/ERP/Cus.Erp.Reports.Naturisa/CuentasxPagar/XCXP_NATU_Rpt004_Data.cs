using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt004_Data
    {
        public List<XCXP_NATU_Rpt004_Info> consultar_Data(int IdEmpresa, decimal ProveedorIni, decimal ProveedorFin, DateTime FechaIni, DateTime FechaFin, ref string mensaje, int IdClaseProveedor, string IdUsuario)
        {
            try
            {
                List<XCXP_NATU_Rpt004_Info> listadedatos = new List<XCXP_NATU_Rpt004_Info>();
                 tb_Empresa_Info Cbt = new tb_Empresa_Info();
                 tb_Empresa_Data empresaData = new tb_Empresa_Data();

                 DateTime Fecha_Ini = Convert.ToDateTime(FechaIni.ToShortDateString());
                 DateTime Fecha_Fin = Convert.ToDateTime(FechaFin.ToShortDateString());

                 decimal ProveIni = 0;
                 decimal ProveFin = 0;

                 int IdClase_ini = IdClaseProveedor;
                 int IdClase_fin = IdClaseProveedor == 0 ? 99999 : IdClaseProveedor;

                 ProveIni = (ProveedorIni == 0) ? 0 : ProveedorIni;
                 ProveFin = (ProveedorFin == 0) ? 9999999 : ProveedorFin;

                 using (EntitiesCXP_Rpt_Naturisa facturaProvee = new EntitiesCXP_Rpt_Naturisa())
               {
                     facturaProvee.SetCommandTimeOut(3000);

                   var select = from h in facturaProvee.spCXP_NATU_Rpt004(IdEmpresa,ProveIni,ProveFin,Fecha_Ini,Fecha_Fin,IdClase_ini,IdClase_fin, IdUsuario)
                              select h;
                          
                   foreach (var item in select)
                   {
                       XCXP_NATU_Rpt004_Info itemInfo = new XCXP_NATU_Rpt004_Info();
                       itemInfo.IdEmpresa = item.IdEmpresa;
                       itemInfo.IdProveedor = item.IdProveedor;
                       itemInfo.nom_proveedor = item.nom_proveedor;
                       itemInfo.Saldo_inicial = item.Saldo_inicial;
                       itemInfo.Debitos= Convert.ToDouble(item.Debitos);
                       itemInfo.Creditos= Convert.ToDouble(item.Creditos);
                       itemInfo.Saldo = Convert.ToDouble(item.Saldo);
                       itemInfo.IdClaseProveedor = item.IdClaseProveedor;
                       itemInfo.descripcion_clas_prove = item.descripcion_clas_prove;
                      
                       listadedatos.Add(itemInfo);
                   }
               }
               return listadedatos;
            }
            catch (Exception)
            {
                return new List<XCXP_NATU_Rpt004_Info>();
            }
        }
    }
}

