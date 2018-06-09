using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt010_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XCXC_Rpt010_Info> get_DetalleDiasxVencer(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, DateTime FechaCorte)
        {
            try
            {
                List<XCXC_Rpt010_Info> lstRpt = new List<XCXC_Rpt010_Info>();

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.spCXC_Rpt010(IdEmpresa, IdSucursalIni, IdSucursalFin, FechaCorte)
                                 select q;

                    Cbt = empresaData.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
                    {
                        XCXC_Rpt010_Info infoRpt = new XCXC_Rpt010_Info();
                        infoRpt.IdCliente = item.IdCliente;
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.Monto = item.Monto;
                        infoRpt.pe_cedulaRuc = item.pe_cedulaRuc;
                        infoRpt.pe_nombreCompleto = item.pe_nombreCompleto;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.TotalCobrado = item.TotalCobrado;
                        infoRpt.Valor_Vencido = item.Valor_Vencido;
                        infoRpt.x_Ven_0_30 = item.x_Ven_0_30;
                        infoRpt.x_Ven_181_999 = item.x_Ven_181_999;
                        infoRpt.x_Ven_31_60 = item.x_Ven_31_60;
                        infoRpt.x_Ven_61_90 = item.x_Ven_61_90;
                        infoRpt.x_Ven_91_180 = item.x_Ven_91_180;
                        infoRpt.Logo = Cbt.em_logo_Image;

                        lstRpt.Add(infoRpt);
                    }

                }

                return lstRpt; ;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return new List<XCXC_Rpt010_Info>();
            }
        }

    }
}
