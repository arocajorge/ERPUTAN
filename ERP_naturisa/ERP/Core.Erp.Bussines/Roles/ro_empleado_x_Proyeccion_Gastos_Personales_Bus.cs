/*CLASE: ro_empleado_x_Proyeccion_Gastos_Personales_Bus
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 04-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{

    public class ro_empleado_x_Proyeccion_Gastos_Personales_Bus
    {

        ro_empleado_x_Proyeccion_Gastos_Personales_Data oData = new ro_empleado_x_Proyeccion_Gastos_Personales_Data();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<ro_empleado_x_Proyeccion_Gastos_Personales_Info> Get_List_empleado_x_Proyeccion_Gastos_Personales(int IdEmpresa, decimal IdEmpleado, int AnioFiscal)
        {
            try
            {
                return oData.Get_List_empleado_x_Proyeccion_Gastos_Personales(IdEmpresa, IdEmpleado,AnioFiscal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_x_Proyeccion_Gastos_Personales", ex.Message), ex) { EntityType = typeof(ro_empleado_x_Proyeccion_Gastos_Personales_Bus) };
            }

        }

        public List<ro_empleado_x_Proyeccion_Gastos_Personales_Info> Get_List_empleado_x_Proyeccion_Gastos_Personales(int IdEmpresa, int anioFiscal)
        {
            try
            {
                return oData.Get_List_empleado_x_Proyeccion_Gastos_Personales(IdEmpresa, anioFiscal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_empleado_x_Proyeccion_Gastos_Personales", ex.Message), ex) { EntityType = typeof(ro_empleado_x_Proyeccion_Gastos_Personales_Bus) };
            }

        }



        public Boolean GrabarBD(ro_empleado_x_Proyeccion_Gastos_Personales_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                //MODIFICA
                if(oData.GetExiste(info, ref msg)){
                    info.UsuarioModifica = param.IdUsuario;
                    info.FechaModifica = param.Fecha_Transac;

                    valorRetornar = oData.ModificarBD(info, ref msg);
                }else{//GRABA
                    info.UsuarioIngresa = param.IdUsuario;
                    info.FechaIngresa = param.Fecha_Transac;
                    
                    valorRetornar = oData.GrabarBD(info, ref msg);                
                              
                }

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_empleado_x_Proyeccion_Gastos_Personales_Bus) };
            }

        }


        public decimal Get_Proyeccion_Anual(int IdEmpresa, int IdEmpleado, int Anio_Fiscal)
        {
            try
            {
                return oData.Get_Proyeccion_Anual(IdEmpresa, IdEmpleado,Anio_Fiscal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Proyeccion_Anual", ex.Message), ex) { EntityType = typeof(ro_empleado_x_Proyeccion_Gastos_Personales_Bus) };
            }
        }

    





    }
}
