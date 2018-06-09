using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
//version 24062013
namespace Core.Erp.Data.Produc_Cirdesus
{
    public class prd_SubGrupoTrabajoDetalle_Data
    {
        string mensaje = "";
        public List<prd_SubGrupoTrabajoDetalle_Info> ObtenerGrupoTrabDetalle( decimal IdGrupoTrabajo, int idempresa, int IdSucursal)
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();

                List<prd_SubGrupoTrabajoDetalle_Info> lM = new List<prd_SubGrupoTrabajoDetalle_Info>();
                var select = from C in OEProduccion.vwprd_GrupoTrabajo_Det
                             where C.IdEmpresa == idempresa && C.IdSucursal == IdSucursal &&  C.IdGrupotrabajo == IdGrupoTrabajo
                             orderby C.Secuencia ascending
                             select C;

                foreach (var item in select)
                {
                    prd_SubGrupoTrabajoDetalle_Info info = new prd_SubGrupoTrabajoDetalle_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdGrupotrabajo=item.IdGrupotrabajo;
                    info.Secuencia=item.Secuencia;
                    info.IdEmpleado=item.IdEmpleado;
                    info.Observacion=item.Observacion;
                    
                    info.Pe_NombreCompeto = item.pe_nombreCompleto.Trim();

                    lM.Add(info);
                }
                return lM;
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

        public Boolean grabarDB(List<prd_SubGrupoTrabajoDetalle_Info> lmDetalleInfo, int idempresa, decimal IdGrupoTrabajo, ref string msg)
        {
            try
            {
                int sec = 0;
                using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
                {
                    foreach (var item in lmDetalleInfo)
                    {
                        var address = new prd_GrupoTrabajo_Det();

                        address.IdEmpresa = item.IdEmpresa ;
                        address.IdSucursal = item.IdSucursal;
                        
                        address.IdGrupotrabajo = IdGrupoTrabajo;
                        address.Secuencia = ++sec;
                        address.IdEmpleado = item.IdEmpleado;
                        address.Observacion = (item.Observacion == null) ? "" : item.Observacion;


                        context.prd_GrupoTrabajo_Det.Add(address);
                        context.SaveChanges();
                    }
                    context.Dispose();

                }
                msg = "Guardado con exito";
                return true;
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

        public Boolean eliminarregistrotabla(List<prd_SubGrupoTrabajoDetalle_Info> lmDetalleInfo, int idempresa, decimal IdGrupoTrabajo, ref string msg)
        {
            try
            {

                using (EntitiesProduccion_Cidersus contex1 = new EntitiesProduccion_Cidersus())
                {

                    foreach (var item in lmDetalleInfo)
                    {
                        var address = contex1.prd_GrupoTrabajo_Det.FirstOrDefault(A => A.IdEmpresa == idempresa && A.IdSucursal == item.IdSucursal   && A.IdGrupotrabajo == IdGrupoTrabajo && A.Secuencia == item.Secuencia);
                        if (address != null)
                        {
                            contex1.prd_GrupoTrabajo_Det.Remove(address);
                            contex1.SaveChanges();
                        }
                    }
                }
                msg = "Guardado con exito";
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString().ToString());
            }
        }

        public List<prd_SubGrupoTrabajoDetalle_Info> ObtenerGrupoTrabDetalle(int IdEtapa, int IdProcesoProductivo)
        {
            try
            {
                EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();

                List<prd_SubGrupoTrabajoDetalle_Info> lM = new List<prd_SubGrupoTrabajoDetalle_Info>();
                var select = from C in OEProduccion.vwprd_GrupoTrabajoEtapa
                             where C.IdEtapa == IdEtapa 
                             && C.IdProcesoProductivo == IdProcesoProductivo
                             select C;

                foreach (var item in select)
                {
                    prd_SubGrupoTrabajoDetalle_Info info = new prd_SubGrupoTrabajoDetalle_Info();

                    info.IdEtapa = item.IdEtapa;
                    info.IdProcesoProductivo = item.IdProcesoProductivo;
                    info.Pe_NombreCompeto = item.pe_nombreCompleto;
                    info.Observacion_operador = item.Observacion;
                    info.Descripcion = item.Descripcion;
                    lM.Add(info);
                }
                return lM;
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