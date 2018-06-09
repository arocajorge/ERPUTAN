/*CLASE: vwro_empleado_por_novedades_Data
 *CREADA POR: ALBERTO MENA
 *FECHA: 09-03-2015
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
    public class vwro_empleado_por_novedades_Data
    {
        private string mensaje = "";
        private List<vwro_empleado_por_novedades_Info> listado = new List<vwro_empleado_por_novedades_Info>();

       public List<vwro_empleado_por_novedades_Info> ConsultaGeneral(int idEmpresa)
        { 
            try{
                    using (EntitiesRoles db = new EntitiesRoles()){

                        var datos =(from a in db.vwro_empleado_por_novedades
                                        where a.IdEmpresa==idEmpresa
                                        select a);
                        foreach(var item in datos){
                            vwro_empleado_por_novedades_Info reg = new vwro_empleado_por_novedades_Info();
                            reg.IdEmpresa = item.IdEmpresa;
                            reg.IdTransaccion = item.IdTransaccion;
                           // reg.IdEmpleado = item.IdEmpleado;
                           // reg.NombreCompleto = item.NombreCompleto;
                            reg.IdRubro = item.IdRubro;
                            reg.DescripcionRubro = item.DescripcionRubro;
                            reg.TipoNomina = item.TipoNomina;
                            reg.DescripcionNomina = item.DescripcionNomina;
                            reg.TipoLiquidacion = item.TipoLiquidacion;
                            reg.DescripcionProceso = item.DescripcionProceso;
                            reg.Observacion = item.Observacion;
                            //reg.Estado = item.Estado;
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
    }
}
