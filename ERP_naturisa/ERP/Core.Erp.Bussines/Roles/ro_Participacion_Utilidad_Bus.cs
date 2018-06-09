/*CLASE: ro_Participacion_Utilidad_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 28-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Participacion_Utilidad_Bus
    {
        ro_Participacion_Utilidad_Data oData = new ro_Participacion_Utilidad_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        ro_Participacion_Utilidad_Empleado_Bus oRo_Participacion_Utilidad_Empleado_Bus = new ro_Participacion_Utilidad_Empleado_Bus();

        string mensaje = "";

        public List<ro_Participacion_Utilidad_Info> GetListGeneral(int idEmpresa, ref string msg)
        {
            try
            {
                return oData.GetListGeneral(idEmpresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListGeneral", ex.Message), ex) { EntityType = typeof(ro_Participacion_Utilidad_Bus) };
            }
        }

        public ro_Participacion_Utilidad_Info GetInfoPorIdPeriodo(int idEmpresa, int idPeriodo, ref string msg)
        {
            try
            {
                return oData.GetInfoPorIdPeriodo(idEmpresa, idPeriodo,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoPorIdPeriodo", ex.Message), ex) { EntityType = typeof(ro_Participacion_Utilidad_Bus) };
            }
        }


        public Boolean GuardarBD(ro_Participacion_Utilidad_Info info, ref string msg) {
            try {
                Boolean valorRetornar = false;

                //MODIFICA
                if(oData.GetExiste(info,ref msg)){
                    info.UsuarioIngresa = param.IdUsuario;
                    info.FechaIngresa = param.Fecha_Transac;
                    valorRetornar = oData.ModificarBD(info,ref msg);
                }else{//GRABA
                    info.UsuarioIngresa = param.IdUsuario;
                    info.FechaIngresa = param.Fecha_Transac;
                    valorRetornar = oData.GuardarBD(info, ref msg);                
                }

                //ELIMINA EL DETALLE
                oRo_Participacion_Utilidad_Empleado_Bus.EliminarBD(info.IdEmpresa, info.IdPeriodo, ref msg);

                //GUARDA EL DETALLE
                if (valorRetornar)
                {
                    foreach (ro_Participacion_Utilidad_Empleado_Info item in info.oListRo_Participacion_Utilidad_Empleado_Info)
                    {
                        if (!oRo_Participacion_Utilidad_Empleado_Bus.GuardarBD(item, ref msg)) {
                            valorRetornar = false;
                            break;
                        }                    
                    }                               
                }
                
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Participacion_Utilidad_Bus) };
            }       
        }






    }
}
