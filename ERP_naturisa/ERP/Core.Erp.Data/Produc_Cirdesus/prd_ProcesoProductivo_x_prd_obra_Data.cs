using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_ProcesoProductivo_x_prd_obra_Data
    {
        string mensaje = "";
        public List<prd_ProcesoProductivo_x_prd_obra_Info> ObtenerProcesProductivo_x_CentroCosto(int idempresa, string CodObra)
        {
            try
            {
                List<prd_ProcesoProductivo_x_prd_obra_Info> lm = new List<prd_ProcesoProductivo_x_prd_obra_Info>();
                EntitiesProduccion_Cidersus OEprocesoproductivo = new EntitiesProduccion_Cidersus();
                var registros = from A in OEprocesoproductivo.vwprd_ProcesoProductivo_x_prd_obra
                                where A.IdEmpresa_obra == idempresa && A.CodObra == CodObra
                                select A;
                foreach (var item in registros)
                {
                    prd_ProcesoProductivo_x_prd_obra_Info info = new prd_ProcesoProductivo_x_prd_obra_Info();
                    info.IdEmpresa = item.IdEmpresa_obra;
                    info.CodObra = item.CodObra;
                    info.IdEmpresa_Pr = item.IdEmpresa_Pr;
                    info.IdProcesoProductivo = item.IdProcesoProductivo;
                    info.NombreModelo = item.Nombre;
                    //info.NombreModelo = item.NombreModelo;
                    lm.Add(info);
                }
                return lm;
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

        public prd_ProcesoProductivo_x_prd_obra_Info Obtener1ProcesProductivo_x_CentroCosto(int idempresa, string CodObra)
        {
            try
            {
                prd_ProcesoProductivo_x_prd_obra_Info info = new prd_ProcesoProductivo_x_prd_obra_Info();
                EntitiesProduccion_Cidersus OEprocesoproductivo = new EntitiesProduccion_Cidersus();
                var registros = from A in OEprocesoproductivo.prd_ProcesoProductivo_x_prd_obra
                                where A.IdEmpresa_obra == idempresa && A.CodObra == CodObra
                                select A;

                foreach (var item in registros)
                {
                    info.IdEmpresa = item.IdEmpresa_obra;
                    info.CodObra = item.CodObra;
                    info.IdEmpresa_Pr = item.IdEmpresa_Pr;
                    info.IdProcesoProductivo = item.IdProcesoProductivo;
                }
                return info;
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
