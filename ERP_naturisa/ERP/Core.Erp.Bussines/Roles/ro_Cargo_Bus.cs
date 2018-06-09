using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Cargo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog=new tb_sis_Log_Error_Vzen_Bus();
        string mensaje="";
        ro_Cargo_Data oData = new ro_Cargo_Data();

        public List<ro_Cargo_Info> ObtenerLstCargoxDep(int idempresa, int IdDepart)
        {

            try
            {
                return oData.Get_List_Cargo(idempresa, IdDepart);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLstCargoxDep", ex.Message), ex) { EntityType = typeof(ro_Cargo_Bus) };

            }
        }

        
        public List<ro_Cargo_Info> ObtenerLstCargo(int idempresa)
        {

            try
            {
                return oData.Get_List_Cargo(idempresa);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLstCargo", ex.Message), ex) { EntityType = typeof(ro_Cargo_Bus) };

            }



        }

        public ro_Cargo_Info ObtenerTipoCargo(int idempresa, int IdDepart, int IdTipoCargo)
        {
            try
            {

                return oData.Get_Info_Cargo(idempresa, IdDepart, IdTipoCargo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTipoCargo", ex.Message), ex) { EntityType = typeof(ro_Cargo_Bus) };

            }

          }
        public Boolean GrabarDB(ro_Cargo_Info info, ref int IdCargo, ref string msg)
        {
            try
            {
                Boolean valorRetornar=false;
                if(oData.GetExiste(info, ref msg)){
                    valorRetornar = oData.ModificarDB(info, ref  msg);
                    IdCargo = info.IdCargo;
                }else{
                    valorRetornar = oData.GrabarDB(info, ref  IdCargo, ref msg);
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Cargo_Bus) };
                ;
            }



        }
        public int getId(int idempresa)
        {
            try
            {

                return oData.GetId(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(ro_Cargo_Bus) };

            }



        }

        public Boolean ModificarDB(ro_Cargo_Info info, ref  string msg)
        {
            try
            {

                return oData.ModificarDB(info, ref   msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Cargo_Bus) };

            }



        }
        public Boolean EliminarDB(ro_Cargo_Info info, ref  string msg)
        {
            try
            {
                return oData.EliminarDB(info, ref   msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_Cargo_Bus) };

            }

        }

        public ro_Cargo_Info Obtener1Cargo(int idempresa, int IdCargo)
        {
            try
            {
                return oData.Get_Info_Cargo(idempresa, IdCargo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Obtener1Cargo", ex.Message), ex) { EntityType = typeof(ro_Cargo_Bus) };

            }

        }
    }
}
