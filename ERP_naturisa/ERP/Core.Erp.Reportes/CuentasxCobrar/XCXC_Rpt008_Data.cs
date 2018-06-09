using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt008_Data
    {
        string mensaje ="";
        tb_Empresa_Data empresaData = new tb_Empresa_Data();
        tb_Empresa_Info Cbt = new tb_Empresa_Info();

        public List<XCXC_Rpt008_Info> get_ReporteCarteraVencida(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, DateTime FechaCorte)
        {
            try
            {
                List<XCXC_Rpt008_Info> lstRpt = new List<XCXC_Rpt008_Info>();

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.spCXC_Rpt008(IdEmpresa, IdSucursalIni, IdSucursalFin, FechaCorte)
                                 select q;

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XCXC_Rpt008_Info infoRpt = new XCXC_Rpt008_Info();

                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.Monto = item.Monto;
                        infoRpt.TotalCobrado = item.TotalCobrado;
                        infoRpt.Valor_Vencido = item.Valor_Vencido;
                        infoRpt.Valor_x_Vencer = item.Valor_x_Vencer;
                        infoRpt.Logo = Cbt.em_logo_Image;

                        lstRpt.Add(infoRpt);
                    }
                    
                }

                return lstRpt;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return new List<XCXC_Rpt008_Info>();
            }
        }


    }
}
