using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Bancos
{
    public class ba_Banco_Cuenta_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ba_Banco_Cuenta_Data data = new ba_Banco_Cuenta_Data();

        private Boolean Validar_Objeto(ba_Banco_Cuenta_Info info, ref string MensajeError)
        {
            try
            {

                if (info.ba_descripcion == "")
                {
                    MensajeError = "Debe Ingresar la descripcion";
                    return false;
                }


                if (info.IdCtaCble == "")
                {
                    MensajeError = "Debe Ingresar la cta cble";
                    return false;
                }


                return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_Objeto", ex.Message), ex) { EntityType = typeof(ba_Banco_Cuenta_Bus) };
                
            }
        }

        public List<ba_Banco_Cuenta_Info> Get_list_Banco_Cuenta(int IdEmpresa)
        {
            try
            {
             return data.Get_list_Banco_Cuenta(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Banco_Cuenta", ex.Message), ex) { EntityType = typeof(ba_Banco_Cuenta_Bus) };
            }
        }

        public List<ba_Banco_Cuenta_Info> Get_list_Banco_Cuenta_Todos(int IdEmpres)
        {
            try
            {
                return data.Get_list_Banco_Cuenta_Todos(IdEmpres);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Banco_Cuenta_Todos", ex.Message), ex) { EntityType = typeof(ba_Banco_Cuenta_Bus) };
            }
        }

        public Boolean Get_Cuenta_Existe(int IdEmpresa, string NumCtaCble, ref string Mensaje)
        {
            try
            {
                return data.Get_Cuenta_Existe(IdEmpresa, NumCtaCble, ref Mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Talonario_cheques_x_banco_Bus) };
            }
        }

        public Boolean Verificar_Si_Existe_Cuenta_x_CtaCble(int IdEmpresa, string IdCtaCble)
        {

            try
            {
               return  data.Verificar_Si_Existe_Cuenta_x_CtaCble(IdEmpresa, IdCtaCble);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Banco_Cuenta_Bus) };
            }
        }

        public Boolean GrabarDB(ba_Banco_Cuenta_Info info, ref int idBan,ref string MensajeError)
        {
            try
            {
                Boolean res=false;


                if (Validar_Objeto(info, ref MensajeError))
                { 
                    res=data.GrabarDB(info, ref idBan);
                }

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Banco_Cuenta_Bus) };
            }
 
        }
        
        public Boolean ActualizarEstado(ba_Banco_Cuenta_Info info)
        {
            try
            {
             return data.ActualizarEstado(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarEstado", ex.Message), ex) { EntityType = typeof(ba_Banco_Cuenta_Bus) };
            }

        }
        
        public Boolean ModificarDB(ba_Banco_Cuenta_Info info)
        {
            try
            {
               return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ba_Banco_Cuenta_Bus) };
            }

        }

        public ba_Banco_Cuenta_Info Get_Info_Banco_Cuenta(int IdEmpresa, int Idbanco)
        {
            try
            {
                 return data.Get_Info_Banco_Cuenta(IdEmpresa, Idbanco);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Banco_Cuenta", ex.Message), ex) { EntityType = typeof(ba_Banco_Cuenta_Bus) };
            }

        }

        public ba_Banco_Cuenta_Bus()
        {
           
        }

    }

}
