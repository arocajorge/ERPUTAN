using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Salario_Digno_Bus
    {

        ro_Salario_Digno_Data oData = new ro_Salario_Digno_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<ro_Salario_Digno_Info> GetListConsultaGeneral(int idEmpresa, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_Salario_Digno_Bus) };
            }
        }

              public List<ro_Salario_Digno_Info> GetListConsultaPorNomina(int idEmpresa,int idNominaTipo, int idPeriodo,ref string msg)
        {
            try
            {
                return oData.GetListConsultaPorNomina(idEmpresa,idNominaTipo, idPeriodo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorNomina", ex.Message), ex) { EntityType = typeof(ro_Salario_Digno_Bus) };
            }
        }


              public Boolean GuardarBD(ro_Salario_Digno_Info info, ref string msg)
              {
                  try
                  {
                      Boolean valorRetornar = false;

                      if(oData.GetExiste(info, ref msg)){//MODIFICA

                          info.UsuarioModifica = param.IdUsuario;
                          info.FechaModifica = param.Fecha_Transac;

                          valorRetornar = oData.ModificarBD(info, ref msg);

                      }else{//GRABA

                          info.UsuarioIngresa= param.IdUsuario;
                          info.FechaIngresa = param.Fecha_Transac;
                          info.UsuarioModifica = param.IdUsuario;
                          info.FechaModifica = param.Fecha_Transac;

                          valorRetornar = oData.GuardarBD(info, ref msg);
                      
                      }

                      //ELIMINAR VALORES PREVIOS
                      ro_Salario_Digno_Empleado_Bus oRo_Salario_Digno_Empleado_Bus = new ro_Salario_Digno_Empleado_Bus();
                      oRo_Salario_Digno_Empleado_Bus.EliminarBD(info.IdEmpresa,info.IdNominaTipo,info.IdPeriodo, ref msg);

                      if (valorRetornar)
                      {
                          foreach (ro_Salario_Digno_Empleado_Info item in info.oListRo_Salario_Digno_Empleado_Info)
                          {
                              //GUARDAR EL DETALLE
                              if (!oRo_Salario_Digno_Empleado_Bus.GuardarBD(item, ref msg)) {
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
                      throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Salario_Digno_Bus) };
                  }
              }



  
    }
}
