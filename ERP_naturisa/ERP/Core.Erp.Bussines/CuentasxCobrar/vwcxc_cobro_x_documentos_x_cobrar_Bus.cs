using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Business.General;



namespace Core.Erp.Business.CuentasxCobrar
{
    public class vwcxc_cobro_x_documentos_x_cobrar_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        vwcxc_cobro_x_documentos_x_cobrar_Data data = new vwcxc_cobro_x_documentos_x_cobrar_Data();
        public List<vwcxc_cobro_x_documentos_x_cobrar_Info> ListarVista(int IdEmpresa, int IdSucursal, decimal IdCliente, string IdEstadoCobro, DateTime FechaIni
            , DateTime FechaFin, Cl_Enumeradores.eTipo_Fecha_buscar_cobro tipo, string IdCobro_tipo)
        {
            try
            {
                return data.Get_List_cobro_x_documentos_x_cobrar(IdEmpresa, IdSucursal, IdCliente, IdEstadoCobro, FechaIni, FechaFin, tipo, IdCobro_tipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_documentos_x_cobrar", ex.Message), ex) { EntityType = typeof(vwcxc_cobro_x_documentos_x_cobrar_Bus) };
            }
        }
    }
}
