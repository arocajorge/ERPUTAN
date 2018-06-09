using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Data.Contabilidad;


namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_EficienciaPiezas_Rpt_Data
    {
        string mensaje = "";
        public prd_EficienciaPiezas_Rpt_Info ObtenerReporte(int idempresa, int idsucursal, string IdCentroCosto)
        {
            try
            {
                prd_EficienciaPiezas_Rpt_Info Datos = new prd_EficienciaPiezas_Rpt_Info();

                //tb_Empresa_Data Empresa_D = new tb_Empresa_Data();
                //ct_Centro_costo_Data CentroCosto_D = new ct_Centro_costo_Data();
                //prd_OrdenTaller_Data OrdenTaller_D = new prd_OrdenTaller_Data();

                //Datos.Empresa = Empresa_D.ObtenerEmpresa(idempresa);
                //Datos.InfoCentroCosto = CentroCosto_D.ObtenerUnCentroCosto(idempresa, IdCentroCosto);
                //Datos.LmOrdenTaller = OrdenTaller_D.ObtenerListaOT_x_CentroCosto(idempresa, IdCentroCosto);

                return Datos;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
