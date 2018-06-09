using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt014_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XCXC_Rpt014_Info> Get_Data_Reporte(int IdEmpresa, int IdVendedor, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                int IdVendedorIni, IdVendedorFin;
                List<XCXC_Rpt014_Info> lstRpt = new List<XCXC_Rpt014_Info>();
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
                IdVendedorIni = (IdVendedor == 0) ? 0 : IdVendedor;
                IdVendedorFin = (IdVendedor == 0) ? 9999999 : IdVendedor;

                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from q in listado.vwCXC_Rpt014
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdVendedor >= IdVendedorIni
                                 && q.IdVendedor <= IdVendedorFin
                                 && q.vt_fecha >= FechaIni
                                 && q.vt_fecha <= FechaFin
                                 select q;

                    foreach (var item in select)
                    {
                        XCXC_Rpt014_Info Info = new XCXC_Rpt014_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.em_nombre = item.em_nombre;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdCbteVta = item.IdCbteVta;
                        Info.vt_NumFactura = item.vt_NumFactura;
                        Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        Info.vt_cantidad = item.vt_cantidad;
                        Info.vt_total = item.vt_total;
                        Info.vt_fecha = item.vt_fecha;
                        Info.pr_codigo = item.pr_codigo;
                        Info.pr_descripcion = item.pr_descripcion;
                        Info.IdVendedor = item.IdVendedor;
                        Info.Ve_Vendedor = item.Ve_Vendedor;

                        lstRpt.Add(Info);
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
                return new List<XCXC_Rpt014_Info>();
            }
        }
    }
}
