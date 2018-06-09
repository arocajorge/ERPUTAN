/*CLASE: vwro_empleado_por_novedades_cabecera_Data
 *CREADA POR: ALBERTO MENA
 *FECHA: 10-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;

namespace Core.Erp.Data.Roles
{
    public class vwro_empleado_por_novedades_cabecera_Data
    {
        private string mensaje = "";
       

        public List<vwro_empleado_por_novedades_cabecera_Info> ConsultaGeneral(int idEmpresa) {
            try
            {
                List<vwro_empleado_por_novedades_cabecera_Info> listado = new List<vwro_empleado_por_novedades_cabecera_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var datos = (from a in db.vwro_empleado_por_novedades_cabecera
                                 where a.IdEmpresa == idEmpresa
                                 select a);
                    foreach (var item in datos)
                    {
                        vwro_empleado_por_novedades_cabecera_Info reg = new vwro_empleado_por_novedades_cabecera_Info();
                        reg.IdEmpresa = item.IdEmpresa;
                        reg.IdTransaccion = item.IdTransaccion;
                        reg.IdRubro = item.IdRubro;
                        reg.DescripcionRubro = item.DescripcionRubro;
                        reg.TipoNomina = item.TipoNomina;
                        reg.DescripcionNomina = item.DescripcionNomina;
                        reg.TipoLiquidacion = item.TipoLiquidacion;
                        reg.DescripcionProceso = item.DescripcionProceso;
                        reg.Observacion = item.Observacion;
                        reg.Estado = item.estado;
                        reg.Fecha = item.Fecha;

                        listado.Add(reg);
                    }
                }
                return listado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<vwro_empleado_por_novedades_cabecera_Info> ConsultaGeneral(int idEmpresa, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                List<vwro_empleado_por_novedades_cabecera_Info> listado = new List<vwro_empleado_por_novedades_cabecera_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    var datos = (from a in db.vwro_empleado_por_novedades_cabecera
                                 where a.IdEmpresa == idEmpresa && ((a.Fecha >= fechaIni) && (a.Fecha<= fechaFin))
                                 select a);

       //where a.IdEmpresa == IdEmpresa && a.Fecha>= fechaIni && a.Fecha<= fechaFin
       
                    foreach (var item in datos)
                    {
                        vwro_empleado_por_novedades_cabecera_Info reg = new vwro_empleado_por_novedades_cabecera_Info();
                        reg.IdEmpresa = item.IdEmpresa;
                        reg.IdTransaccion = item.IdTransaccion;
                        reg.IdRubro = item.IdRubro;
                        reg.DescripcionRubro = item.DescripcionRubro;
                        reg.TipoNomina = item.TipoNomina;
                        reg.DescripcionNomina = item.DescripcionNomina;
                        reg.TipoLiquidacion = item.TipoLiquidacion;
                        reg.DescripcionProceso = item.DescripcionProceso;
                        reg.Observacion = item.Observacion;
                        reg.Estado = item.estado;
                        reg.Fecha = item.Fecha;

                        listado.Add(reg);
                    }
                }
                return listado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public vwro_empleado_por_novedades_cabecera_Info ConsultaById(int idEmpresa,decimal id)
        {
            try
            {
                vwro_empleado_por_novedades_cabecera_Info reg = new vwro_empleado_por_novedades_cabecera_Info();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    vwro_empleado_por_novedades_cabecera item = (from a in db.vwro_empleado_por_novedades_cabecera
                                 where a.IdEmpresa == idEmpresa && a.IdTransaccion==id
                                 select a).FirstOrDefault();
                        reg.IdEmpresa = item.IdEmpresa;
                        reg.IdTransaccion = item.IdTransaccion;
                        reg.IdRubro = item.IdRubro;
                        reg.DescripcionRubro = item.DescripcionRubro;
                        reg.TipoNomina = item.TipoNomina;
                        reg.DescripcionNomina = item.DescripcionNomina;
                        reg.TipoLiquidacion = item.TipoLiquidacion;
                        reg.DescripcionProceso = item.DescripcionProceso;
                        reg.Observacion = item.Observacion;
                        reg.Estado = item.estado;
                        reg.Fecha = item.Fecha;
                }
                return reg;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
