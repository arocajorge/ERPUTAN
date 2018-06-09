using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt011_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XCXC_Rpt011_Info> get_List_EstadoCtaResumido(int IdEmpresa, int IdSucursal, decimal IdClienteIni, decimal IdClienteFin, DateTime FechaCorte, int Idtipo_cliente)
        {
            try
            {
                int IdTipo_ini = Idtipo_cliente;
                int IdTipo_fin = Idtipo_cliente == 0 ? 9999 : Idtipo_cliente;

                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

                List<XCXC_Rpt011_Info> lstInfo = new List<XCXC_Rpt011_Info>();
                using (Entities_CuentasxCobrar listado = new Entities_CuentasxCobrar())
                {
                    var select = from group_ in listado.vwCXC_Rpt011
                                 where group_.IdEmpresa == IdEmpresa
                                 && IdSucursal_ini <= group_.IdSucursal && group_.IdSucursal <= IdSucursal_fin
                                && group_.vt_fecha <= FechaCorte
                                && group_.IdCliente >= IdClienteIni && group_.IdCliente <= IdClienteFin
                                && IdTipo_ini <= group_.Idtipo_cliente && group_.Idtipo_cliente <= IdTipo_fin
                                 group group_ by new
                                 {
                                     group_.IdEmpresa,
                                     group_.IdSucursal,
                                     group_.IdCliente,
                                     group_.Su_Descripcion,
                                     group_.pe_nombreCompleto,
                                     group_.pe_cedulaRuc,
                                     group_.Idtipo_cliente,
                                     group_.Descripcion_tip_cliente
                                 } into grouping
                                 select new { grouping.Key, v_Total_Debe = grouping.Sum(q => q.Total_Debe), v_Total_Haber = grouping.Sum(q => q.Total_Haber) };

                    foreach (var item in select)
                    {
                        XCXC_Rpt011_Info Info = new XCXC_Rpt011_Info();
                        Info.IdEmpresa = item.Key.IdEmpresa;
                        Info.IdSucursal = item.Key.IdSucursal;
                        Info.IdCliente = item.Key.IdCliente;
                        Info.Su_Descripcion = item.Key.Su_Descripcion;
                        Info.pe_nombreCompleto = item.Key.pe_nombreCompleto;
                        Info.pe_cedulaRuc = item.Key.pe_cedulaRuc;
                        Info.Descripcion_tip_cliente = item.Key.Descripcion_tip_cliente;
                        Info.Idtipo_cliente = item.Key.Idtipo_cliente;
                        Info.Total_Debe = item.v_Total_Debe;
                        Info.Total_Haber = item.v_Total_Haber;
                        Info.Logo = Cbt.em_logo_Image;

                        lstInfo.Add(Info);
                    }
                                
                                 
                }
                return lstInfo;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return new List<XCXC_Rpt011_Info>();
            }
        }
    }
}
