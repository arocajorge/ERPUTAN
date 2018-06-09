using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class ba_tipo_nota_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_tipo_nota_Data Data = new ba_tipo_nota_Data();


        public List<ba_tipo_nota_Info> Get_List_tipo_nota(int IdEmpresa, string tipo)
        {
            try
            {
                return Data.Get_List_tipo_nota(IdEmpresa, tipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_tipo_nota", ex.Message), ex) { EntityType = typeof(ba_tipo_nota_Bus) };
            }
            
        }

        public List<ba_tipo_nota_Info> Get_List_tipo_nota(int IdEmpresa)
        {
            try
            {
                return Data.Get_List_tipo_nota(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_tipo_nota", ex.Message), ex) { EntityType = typeof(ba_tipo_nota_Bus) };
            }

        }

        public Boolean ActualizarDB(ba_tipo_nota_Info Info)
        {
            try
            {
                return Data.ActualizarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(ba_tipo_nota_Bus) };
            }
        }

        public Boolean Eliminar(ba_tipo_nota_Info Info, ref string msg)
        {
            try
            {
                return Data.AnularDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_tipo_nota", ex.Message), ex) { EntityType = typeof(ba_tipo_nota_Bus) };
            }
        }

        public ba_tipo_nota_Info Get_Info_tipo_nota(int IdEmpresa, int idTipoNota)
        {
            try
            {
                return Data.Get_Info_tipo_nota(IdEmpresa, idTipoNota);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_tipo_nota", ex.Message), ex) { EntityType = typeof(ba_tipo_nota_Bus) };
            }
        }

        public Boolean GuardarDB(ba_tipo_nota_Info Info)
        {
            try
            {
                Boolean res = false;
                string mesn="";

                if (ValidarObjeto(Info, ref mesn) == true)
                {
                   res= Data.GuardarDB(Info); 
                }
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ba_tipo_nota_Bus) };
            }
        }


        public Boolean ValidarObjeto(ba_tipo_nota_Info Info, ref string MensajeError)
        {

            try
            {

                Boolean res = true;


                if (Info.IdEmpresa == 0 )
                {
                    MensajeError = "el objeto esta errado los PK IdEmpresa , IdTipoCbte no pueden estar en cero";
                    return false;
                }

                if (Info.IdCentroCosto == "")
                {
                    Info.IdCentroCosto = null;
                }

              

              

              
                return res;


            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarObjeto", ex.Message), ex) { EntityType = typeof(ba_tipo_nota_Bus) };
            }


        }

    }
}
